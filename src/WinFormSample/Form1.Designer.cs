namespace WinFormSample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.apiAddressTextBox = new System.Windows.Forms.TextBox();
            this.appTokenTextBox = new System.Windows.Forms.TextBox();
            this.sellerTokenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getRequestButton = new System.Windows.Forms.Button();
            this.logTextbox = new System.Windows.Forms.TextBox();
            this.postRequestButton = new System.Windows.Forms.Button();
            this.checkApiKeyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apiAddressTextBox
            // 
            this.apiAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apiAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apiAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiAddressTextBox.Location = new System.Drawing.Point(12, 24);
            this.apiAddressTextBox.Name = "apiAddressTextBox";
            this.apiAddressTextBox.Size = new System.Drawing.Size(362, 26);
            this.apiAddressTextBox.TabIndex = 0;
            this.apiAddressTextBox.Text = "https://storemiddleapi.darkube.app";
            // 
            // appTokenTextBox
            // 
            this.appTokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appTokenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appTokenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTokenTextBox.Location = new System.Drawing.Point(12, 80);
            this.appTokenTextBox.Name = "appTokenTextBox";
            this.appTokenTextBox.Size = new System.Drawing.Size(362, 26);
            this.appTokenTextBox.TabIndex = 1;
            this.appTokenTextBox.Text = "__APPLICATION_TOKEN___";
            // 
            // sellerTokenTextBox
            // 
            this.sellerTokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellerTokenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sellerTokenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerTokenTextBox.Location = new System.Drawing.Point(12, 126);
            this.sellerTokenTextBox.Name = "sellerTokenTextBox";
            this.sellerTokenTextBox.Size = new System.Drawing.Size(362, 26);
            this.sellerTokenTextBox.TabIndex = 2;
            this.sellerTokenTextBox.Text = "__SELLER_TOKEN__";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Api Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "App Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SellerToken";
            // 
            // getRequestButton
            // 
            this.getRequestButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getRequestButton.Location = new System.Drawing.Point(12, 164);
            this.getRequestButton.Name = "getRequestButton";
            this.getRequestButton.Size = new System.Drawing.Size(185, 27);
            this.getRequestButton.TabIndex = 6;
            this.getRequestButton.Text = "Get Request";
            this.getRequestButton.UseVisualStyleBackColor = true;
            // 
            // logTextbox
            // 
            this.logTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextbox.Location = new System.Drawing.Point(12, 230);
            this.logTextbox.Multiline = true;
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.Size = new System.Drawing.Size(362, 208);
            this.logTextbox.TabIndex = 7;
            // 
            // postRequestButton
            // 
            this.postRequestButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postRequestButton.Location = new System.Drawing.Point(203, 164);
            this.postRequestButton.Name = "postRequestButton";
            this.postRequestButton.Size = new System.Drawing.Size(171, 27);
            this.postRequestButton.TabIndex = 8;
            this.postRequestButton.Text = "Post Request";
            this.postRequestButton.UseVisualStyleBackColor = true;
            // 
            // checkApiKeyButton
            // 
            this.checkApiKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkApiKeyButton.Location = new System.Drawing.Point(12, 197);
            this.checkApiKeyButton.Name = "checkApiKeyButton";
            this.checkApiKeyButton.Size = new System.Drawing.Size(185, 27);
            this.checkApiKeyButton.TabIndex = 9;
            this.checkApiKeyButton.Text = "CheckApiKey";
            this.checkApiKeyButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.checkApiKeyButton);
            this.Controls.Add(this.postRequestButton);
            this.Controls.Add(this.logTextbox);
            this.Controls.Add(this.getRequestButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sellerTokenTextBox);
            this.Controls.Add(this.appTokenTextBox);
            this.Controls.Add(this.apiAddressTextBox);
            this.Name = "Form1";
            this.Text = "BookHouse Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apiAddressTextBox;
        private System.Windows.Forms.TextBox appTokenTextBox;
        private System.Windows.Forms.TextBox sellerTokenTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getRequestButton;
        private System.Windows.Forms.TextBox logTextbox;
        private System.Windows.Forms.Button postRequestButton;
        private System.Windows.Forms.Button checkApiKeyButton;
    }
}

