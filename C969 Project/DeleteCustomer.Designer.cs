namespace C969_Project
{
    partial class DeleteCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCustomer));
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
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
            this.idLabel = new System.Windows.Forms.Label();
            this.custComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearButton.Location = new System.Drawing.Point(157, 342);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(96, 31);
            this.clearButton.TabIndex = 73;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.searchButton.Location = new System.Drawing.Point(16, 342);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(96, 31);
            this.searchButton.TabIndex = 72;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Location = new System.Drawing.Point(76, 9);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(117, 13);
            this.deleteLabel.TabIndex = 71;
            this.deleteLabel.Text = "Delete customer record";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelButton.Location = new System.Drawing.Point(157, 393);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 31);
            this.cancelButton.TabIndex = 70;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Enabled = false;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteButton.Location = new System.Drawing.Point(15, 393);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 31);
            this.deleteButton.TabIndex = 69;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // noRadio
            // 
            this.noRadio.AutoSize = true;
            this.noRadio.Enabled = false;
            this.noRadio.Location = new System.Drawing.Point(214, 313);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(39, 17);
            this.noRadio.TabIndex = 68;
            this.noRadio.TabStop = true;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = true;
            // 
            // yesRadio
            // 
            this.yesRadio.AutoSize = true;
            this.yesRadio.Enabled = false;
            this.yesRadio.Location = new System.Drawing.Point(110, 313);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(43, 17);
            this.yesRadio.TabIndex = 67;
            this.yesRadio.TabStop = true;
            this.yesRadio.Text = "Yes";
            this.yesRadio.UseVisualStyleBackColor = true;
            // 
            // countryTextbox
            // 
            this.countryTextbox.Enabled = false;
            this.countryTextbox.Location = new System.Drawing.Point(110, 278);
            this.countryTextbox.Name = "countryTextbox";
            this.countryTextbox.Size = new System.Drawing.Size(143, 20);
            this.countryTextbox.TabIndex = 66;
            // 
            // zipTextbox
            // 
            this.zipTextbox.Enabled = false;
            this.zipTextbox.Location = new System.Drawing.Point(110, 246);
            this.zipTextbox.Name = "zipTextbox";
            this.zipTextbox.Size = new System.Drawing.Size(143, 20);
            this.zipTextbox.TabIndex = 65;
            // 
            // cityTextbox
            // 
            this.cityTextbox.Enabled = false;
            this.cityTextbox.Location = new System.Drawing.Point(110, 211);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(143, 20);
            this.cityTextbox.TabIndex = 64;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Enabled = false;
            this.addressTextbox.Location = new System.Drawing.Point(110, 176);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(143, 20);
            this.addressTextbox.TabIndex = 63;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Enabled = false;
            this.phoneTextbox.Location = new System.Drawing.Point(110, 139);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(143, 20);
            this.phoneTextbox.TabIndex = 62;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Enabled = false;
            this.nameTextbox.Location = new System.Drawing.Point(110, 100);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(143, 20);
            this.nameTextbox.TabIndex = 61;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(12, 246);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(53, 13);
            this.zipLabel.TabIndex = 60;
            this.zipLabel.Text = "Zip Code:";
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Location = new System.Drawing.Point(12, 313);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(40, 13);
            this.activeLabel.TabIndex = 59;
            this.activeLabel.Text = "Active:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(12, 278);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(46, 13);
            this.countryLabel.TabIndex = 58;
            this.countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 211);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 57;
            this.cityLabel.Text = "City:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(13, 176);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 56;
            this.addressLabel.Text = "Address:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(13, 139);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 55;
            this.phoneLabel.Text = "Phone:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 100);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 54;
            this.nameLabel.Text = "Name:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(12, 43);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(103, 13);
            this.idLabel.TabIndex = 74;
            this.idLabel.Text = "Customer Select:";
            // 
            // custComboBox
            // 
            this.custComboBox.FormattingEnabled = true;
            this.custComboBox.Location = new System.Drawing.Point(121, 40);
            this.custComboBox.Name = "custComboBox";
            this.custComboBox.Size = new System.Drawing.Size(144, 21);
            this.custComboBox.TabIndex = 76;
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 449);
            this.Controls.Add(this.custComboBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
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
            this.Name = "DeleteCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
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
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ComboBox custComboBox;
    }
}