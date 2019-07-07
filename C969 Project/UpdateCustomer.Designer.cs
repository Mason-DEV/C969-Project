namespace C969_Project
{
    partial class UpdateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCustomer));
            this.createLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.noRadio = new System.Windows.Forms.RadioButton();
            this.yesRadio = new System.Windows.Forms.RadioButton();
            this.countryTextbox = new System.Windows.Forms.TextBox();
            this.zipTextbox = new System.Windows.Forms.TextBox();
            this.cityTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.activeLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.custComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // createLabel
            // 
            this.createLabel.AutoSize = true;
            this.createLabel.Location = new System.Drawing.Point(65, 9);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(142, 13);
            this.createLabel.TabIndex = 51;
            this.createLabel.Text = "Update customer information";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelButton.Location = new System.Drawing.Point(157, 400);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 31);
            this.cancelButton.TabIndex = 50;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Enabled = false;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.updateButton.Location = new System.Drawing.Point(15, 400);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 31);
            this.updateButton.TabIndex = 49;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // noRadio
            // 
            this.noRadio.AutoSize = true;
            this.noRadio.Enabled = false;
            this.noRadio.Location = new System.Drawing.Point(214, 320);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(39, 17);
            this.noRadio.TabIndex = 48;
            this.noRadio.TabStop = true;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = true;
            // 
            // yesRadio
            // 
            this.yesRadio.AutoSize = true;
            this.yesRadio.Enabled = false;
            this.yesRadio.Location = new System.Drawing.Point(110, 320);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(43, 17);
            this.yesRadio.TabIndex = 47;
            this.yesRadio.TabStop = true;
            this.yesRadio.Text = "Yes";
            this.yesRadio.UseVisualStyleBackColor = true;
            // 
            // countryTextbox
            // 
            this.countryTextbox.Enabled = false;
            this.countryTextbox.Location = new System.Drawing.Point(110, 285);
            this.countryTextbox.Name = "countryTextbox";
            this.countryTextbox.Size = new System.Drawing.Size(143, 20);
            this.countryTextbox.TabIndex = 46;
            // 
            // zipTextbox
            // 
            this.zipTextbox.Enabled = false;
            this.zipTextbox.Location = new System.Drawing.Point(110, 253);
            this.zipTextbox.Name = "zipTextbox";
            this.zipTextbox.Size = new System.Drawing.Size(143, 20);
            this.zipTextbox.TabIndex = 45;
            // 
            // cityTextbox
            // 
            this.cityTextbox.Enabled = false;
            this.cityTextbox.Location = new System.Drawing.Point(110, 218);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(143, 20);
            this.cityTextbox.TabIndex = 44;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Enabled = false;
            this.addressTextbox.Location = new System.Drawing.Point(110, 183);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(143, 20);
            this.addressTextbox.TabIndex = 43;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Enabled = false;
            this.phoneTextbox.Location = new System.Drawing.Point(110, 146);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(143, 20);
            this.phoneTextbox.TabIndex = 42;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Enabled = false;
            this.nameTextbox.Location = new System.Drawing.Point(110, 107);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(143, 20);
            this.nameTextbox.TabIndex = 41;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(12, 253);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(53, 13);
            this.zipLabel.TabIndex = 40;
            this.zipLabel.Text = "Zip Code:";
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Location = new System.Drawing.Point(12, 320);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(40, 13);
            this.activeLabel.TabIndex = 39;
            this.activeLabel.Text = "Active:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(12, 285);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(46, 13);
            this.countryLabel.TabIndex = 38;
            this.countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 218);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 37;
            this.cityLabel.Text = "City:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(13, 183);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 36;
            this.addressLabel.Text = "Address:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(13, 146);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 35;
            this.phoneLabel.Text = "Phone:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 107);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 34;
            this.nameLabel.Text = "Name:";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearButton.Location = new System.Drawing.Point(157, 349);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(96, 31);
            this.clearButton.TabIndex = 53;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.searchButton.Location = new System.Drawing.Point(16, 349);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(96, 31);
            this.searchButton.TabIndex = 52;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(12, 48);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(103, 13);
            this.idLabel.TabIndex = 54;
            this.idLabel.Text = "Customer Select:";
            // 
            // custComboBox
            // 
            this.custComboBox.FormattingEnabled = true;
            this.custComboBox.Location = new System.Drawing.Point(134, 45);
            this.custComboBox.Name = "custComboBox";
            this.custComboBox.Size = new System.Drawing.Size(144, 21);
            this.custComboBox.TabIndex = 56;
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 455);
            this.Controls.Add(this.custComboBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.createLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.noRadio);
            this.Controls.Add(this.yesRadio);
            this.Controls.Add(this.countryTextbox);
            this.Controls.Add(this.zipTextbox);
            this.Controls.Add(this.cityTextbox);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.activeLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateCustomer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.RadioButton noRadio;
        private System.Windows.Forms.RadioButton yesRadio;
        private System.Windows.Forms.TextBox countryTextbox;
        private System.Windows.Forms.TextBox zipTextbox;
        private System.Windows.Forms.TextBox cityTextbox;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ComboBox custComboBox;
    }
}