using BookHouse.SyncApi.Core;
using BookHouse.SyncApi.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private async Task getRequestButton_Click(object sender, EventArgs e)
        {
            if (_client == null)
                _client = new BookHouseClient(appTokenTextBox.Text, sellerTokenTextBox.Text, apiAddressTextBox.Text);
            else
            {
                _client.UpdateCredential(appTokenTextBox.Text, sellerTokenTextBox.Text);
            }

            var res = await _client.GetOnlineOrders(DateTime.Now);

            logTextbox.Text = res.StoreTitle + "\r\n" + res.StartDateTime.ToString() + "\r\n" + res.Books.Count();
            logTextbox.Text += "\r\n \r\n" + JsonSerializer.Serialize(res);

        }

        private async Task postRequestButton_Click(object sender, EventArgs e)
        {
            if (_client == null)
                _client = new BookHouseClient(appTokenTextBox.Text, sellerTokenTextBox.Text, apiAddressTextBox.Text);
            else
            {
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


            try
            {
                var res = await _client.ImportBooks(books);

                logTextbox.Text = JsonSerializer.Serialize(res);
            }
            catch (Exception ex)
            {
                logTextbox.Text = "خطا در آپدیت موجودی ها";
            }
        }


        private async Task checkApiKeyButton_Click(object sender, EventArgs e)
        {
            if (_client == null)
                _client = new BookHouseClient(appTokenTextBox.Text, sellerTokenTextBox.Text, apiAddressTextBox.Text);
            else
            {
                _client.UpdateCredential(appTokenTextBox.Text, sellerTokenTextBox.Text);
            }
            logTextbox.AppendText("در حال بررسی ارتباط");
            logTextbox.AppendText("\r\n");

            var res = await _client.CheckApiKey();

            logTextbox.AppendText($"{res.Title} - {res.Description}");
            logTextbox.AppendText("\r\n");


        }
    }
}
