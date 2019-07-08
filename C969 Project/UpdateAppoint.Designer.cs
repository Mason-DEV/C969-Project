namespace C969_Project
{
    partial class UpdateAppoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAppoint));
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endDTP = new System.Windows.Forms.DateTimePicker();
            this.startDTP = new System.Windows.Forms.DateTimePicker();
            this.contactTextbox = new System.Windows.Forms.TextBox();
            this.locationTextbox = new System.Windows.Forms.TextBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.appointSelectLabel = new System.Windows.Forms.Label();
            this.appointLabel = new System.Windows.Forms.Label();
            this.appointComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.typeCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(36, 393);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(55, 13);
            this.endLabel.TabIndex = 71;
            this.endLabel.Text = "End Time:";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(36, 344);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(58, 13);
            this.startLabel.TabIndex = 70;
            this.startLabel.Text = "Start Time:";
            // 
            // endDTP
            // 
            this.endDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.endDTP.Enabled = false;
            this.endDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDTP.Location = new System.Drawing.Point(133, 387);
            this.endDTP.Name = "endDTP";
            this.endDTP.Size = new System.Drawing.Size(192, 20);
            this.endDTP.TabIndex = 69;
            // 
            // startDTP
            // 
            this.startDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.startDTP.Enabled = false;
            this.startDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDTP.Location = new System.Drawing.Point(133, 338);
            this.startDTP.Name = "startDTP";
            this.startDTP.Size = new System.Drawing.Size(192, 20);
            this.startDTP.TabIndex = 68;
            // 
            // contactTextbox
            // 
            this.contactTextbox.Enabled = false;
            this.contactTextbox.Location = new System.Drawing.Point(133, 257);
            this.contactTextbox.Name = "contactTextbox";
            this.contactTextbox.Size = new System.Drawing.Size(192, 20);
            this.contactTextbox.TabIndex = 66;
            // 
            // locationTextbox
            // 
            this.locationTextbox.Enabled = false;
            this.locationTextbox.Location = new System.Drawing.Point(133, 223);
            this.locationTextbox.Name = "locationTextbox";
            this.locationTextbox.Size = new System.Drawing.Size(192, 20);
            this.locationTextbox.TabIndex = 65;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Enabled = false;
            this.descriptionTextbox.Location = new System.Drawing.Point(133, 155);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(192, 52);
            this.descriptionTextbox.TabIndex = 64;
            // 
            // titleTextbox
            // 
            this.titleTextbox.Enabled = false;
            this.titleTextbox.Location = new System.Drawing.Point(133, 116);
            this.titleTextbox.MaxLength = 255;
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(192, 20);
            this.titleTextbox.TabIndex = 63;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(36, 295);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 62;
            this.typeLabel.Text = "Type:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(36, 260);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(47, 13);
            this.contactLabel.TabIndex = 61;
            this.contactLabel.Text = "Contact:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(36, 226);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 60;
            this.locationLabel.Text = "Location:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(36, 155);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 59;
            this.descriptionLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(36, 116);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 58;
            this.titleLabel.Text = "Title:";
            // 
            // appointSelectLabel
            // 
            this.appointSelectLabel.AutoSize = true;
            this.appointSelectLabel.Location = new System.Drawing.Point(36, 42);
            this.appointSelectLabel.Name = "appointSelectLabel";
            this.appointSelectLabel.Size = new System.Drawing.Size(69, 13);
            this.appointSelectLabel.TabIndex = 56;
            this.appointSelectLabel.Text = "Appointment:";
            // 
            // appointLabel
            // 
            this.appointLabel.AutoSize = true;
            this.appointLabel.Location = new System.Drawing.Point(92, 4);
            this.appointLabel.Name = "appointLabel";
            this.appointLabel.Size = new System.Drawing.Size(196, 13);
            this.appointLabel.TabIndex = 55;
            this.appointLabel.Text = "Please update appointment  information:";
            // 
            // appointComboBox
            // 
            this.appointComboBox.FormattingEnabled = true;
            this.appointComboBox.Location = new System.Drawing.Point(133, 39);
            this.appointComboBox.Name = "appointComboBox";
            this.appointComboBox.Size = new System.Drawing.Size(192, 21);
            this.appointComboBox.TabIndex = 54;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearButton.Location = new System.Drawing.Point(210, 436);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(96, 31);
            this.clearButton.TabIndex = 75;
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
            this.searchButton.Location = new System.Drawing.Point(69, 436);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(96, 31);
            this.searchButton.TabIndex = 74;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelButton.Location = new System.Drawing.Point(210, 487);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 31);
            this.cancelButton.TabIndex = 73;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Enabled = false;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.updateButton.Location = new System.Drawing.Point(68, 487);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 31);
            this.updateButton.TabIndex = 72;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(36, 83);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(54, 13);
            this.customerLabel.TabIndex = 77;
            this.customerLabel.Text = "Customer:";
            // 
            // customerComboBox
            // 
            this.customerComboBox.Enabled = false;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(133, 80);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(192, 21);
            this.customerComboBox.TabIndex = 76;
            // 
            // typeCombobox
            // 
            this.typeCombobox.Enabled = false;
            this.typeCombobox.FormattingEnabled = true;
            this.typeCombobox.Items.AddRange(new object[] {
            "Event",
            "Follow Up",
            "Initial Consultation",
            "Lab Visit",
            "Other",
            "Physical",
            "Sugery"});
            this.typeCombobox.Location = new System.Drawing.Point(133, 292);
            this.typeCombobox.Name = "typeCombobox";
            this.typeCombobox.Size = new System.Drawing.Size(192, 21);
            this.typeCombobox.TabIndex = 78;
            // 
            // UpdateAppoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 550);
            this.Controls.Add(this.typeCombobox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.endDTP);
            this.Controls.Add(this.startDTP);
            this.Controls.Add(this.contactTextbox);
            this.Controls.Add(this.locationTextbox);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.appointSelectLabel);
            this.Controls.Add(this.appointLabel);
            this.Controls.Add(this.appointComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateAppoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAppoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker endDTP;
        private System.Windows.Forms.DateTimePicker startDTP;
        private System.Windows.Forms.TextBox contactTextbox;
        private System.Windows.Forms.TextBox locationTextbox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label appointSelectLabel;
        private System.Windows.Forms.Label appointLabel;
        private System.Windows.Forms.ComboBox appointComboBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.ComboBox typeCombobox;
    }
}