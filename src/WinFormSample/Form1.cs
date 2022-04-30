using BookHouse.SyncApi.Core;
using BookHouse.SyncApi.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSample
{
    public partial class Form1 : Form
    {
        private BookHouseClient _client;

        public Form1()
        {
            InitializeComponent();



            logTextbox.ReadOnly = true;
            getRequestButton.Click += async (s, e) => await getRequestButton_Click(s, e);

            postRequestButton.Click += async (s, e) => await postRequestButton_Click(s, e);

            checkApiKeyButton.Click += async (s, e) => await checkApiKeyButton_Click(s, e);


            _client = new BookHouseClient(appTokenTextBox.Text, sellerTokenTextBox.Text, apiAddressTextBox.Text);
            _client.ProgressChanged += (s, e) =>
            {
                LoggToText(e);
            };

        }

        private async Task getRequestButton_Click(object sender, EventArgs e)
        {
            if (_client == null)
                _client = new BookHouseClient(appTokenTextBox.Text, sellerTokenTextBox.Text, apiAddressTextBox.Text);
            else
            {
                if (!_client.IsBusy())
                {
                    _client.UpdateCredential(appTokenTextBox.Text, sellerTokenTextBox.Text);
                }
            }

            var res = await _client.GetOnlineOrders(DateTime.Now);

            LoggToText(res.StoreTitle + " - " + res.StartDateTime.ToString() + " - " + res.Books.Count());
            LoggToText(JsonSerializer.Serialize(res));

        }

        private async Task postRequestButton_Click(object sender, EventArgs e)
        {
            if (_client == null)
                _client = new BookHouseClient(appTokenTextBox.Text, sellerTokenTextBox.Text, apiAddressTextBox.Text);
            else
            {
                if (_client.IsBusy())
                    return;
                _client.UpdateCredential(appTokenTextBox.Text, sellerTokenTextBox.Text);
            }

            //Sample Data
            var books = new List<Book>
            {
                new Book
                {
                    ISBN = "978-622-6179-44-7",
                    PrintVersion = 1,
                    Quantity = 20,
                },
                new Book
                {
                    ISBN ="978-622-6322-54-6",
                    PrintVersion = 1,
                    Quantity = 30,
                },
                new Book
                {
                    ISBN ="978-600-6947-37-2",
                    PrintVersion = 1,
                    Quantity = 40,
                },
            };

            //Sample Data From File
            //var books = JsonSerializer.Deserialize<List<Book>>(File.ReadAllText("data.json"));


            try
            {
                var res = await _client.ImportBooks(books);
            }
            catch (Exception ex)
            {
                LoggToText(ex.Message);
            }
        }


        private async Task checkApiKeyButton_Click(object sender, EventArgs e)
        {
            if (_client == null)
                _client = new BookHouseClient(appTokenTextBox.Text, sellerTokenTextBox.Text, apiAddressTextBox.Text);
            else
            {
                if (!_client.IsBusy())
                {
                    _client.UpdateCredential(appTokenTextBox.Text, sellerTokenTextBox.Text);
                }
            }
            LoggToText("در حال بررسی ارتباط");

            var res = await _client.CheckApiKey();

            LoggToText($"{res.Title} - {res.Description}");


        }

        private void LoggToText(string text)
        {
            logTextbox.AppendText($"{DateTime.Now}:: {text}");
            logTextbox.AppendText("\r\n");
        }
    }
}
