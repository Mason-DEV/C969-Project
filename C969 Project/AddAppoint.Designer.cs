namespace C969_Project
{
    partial class AddAppoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAppoint));
            this.custComboBox = new System.Windows.Forms.ComboBox();
            this.appointLabel = new System.Windows.Forms.Label();
            this.custLabel = new System.Windows.Forms.Label();
            this.createCusButton = new System.Windows.Forms.Button();
            this.contactTextbox = new System.Windows.Forms.TextBox();
            this.locationTextbox = new System.Windows.Forms.TextBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.startDTP = new System.Windows.Forms.DateTimePicker();
            this.endDTP = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.typeCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // custComboBox
            // 
            this.custComboBox.FormattingEnabled = true;
            this.custComboBox.Location = new System.Drawing.Point(154, 44);
            this.custComboBox.Name = "custComboBox";
            this.custComboBox.Size = new System.Drawing.Size(192, 21);
            this.custComboBox.TabIndex = 0;
            // 
            // appointLabel
            // 
            this.appointLabel.AutoSize = true;
            this.appointLabel.Location = new System.Drawing.Point(113, 9);
            this.appointLabel.Name = "appointLabel";
            this.appointLabel.Size = new System.Drawing.Size(210, 13);
            this.appointLabel.TabIndex = 34;
            this.appointLabel.Text = "Please enter new appointment  information:";
            // 
            // custLabel
            // 
            this.custLabel.AutoSize = true;
            this.custLabel.Location = new System.Drawing.Point(57, 47);
            this.custLabel.Name = "custLabel";
            this.custLabel.Size = new System.Drawing.Size(54, 13);
            this.custLabel.TabIndex = 35;
            this.custLabel.Text = "Customer:";
            // 
            // createCusButton
            // 
            this.createCusButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.createCusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCusButton.ForeColor = System.Drawing.SystemColors.Control;
            this.createCusButton.Location = new System.Drawing.Point(60, 413);
            this.createCusButton.Name = "createCusButton";
            this.createCusButton.Size = new System.Drawing.Size(96, 31);
            this.createCusButton.TabIndex = 36;
            this.createCusButton.Text = "Create";
            this.createCusButton.UseVisualStyleBackColor = false;
            this.createCusButton.Click += new System.EventHandler(this.CreateCusButton_Click);
            // 
            // contactTextbox
            // 
            this.contactTextbox.Location = new System.Drawing.Point(154, 225);
            this.contactTextbox.Name = "contactTextbox";
            this.contactTextbox.Size = new System.Drawing.Size(192, 20);
            this.contactTextbox.TabIndex = 46;
            // 
            // locationTextbox
            // 
            this.locationTextbox.Location = new System.Drawing.Point(154, 191);
            this.locationTextbox.Name = "locationTextbox";
            this.locationTextbox.Size = new System.Drawing.Size(192, 20);
            this.locationTextbox.TabIndex = 45;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(154, 123);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(192, 52);
            this.descriptionTextbox.TabIndex = 44;
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(154, 84);
            this.titleTextbox.MaxLength = 255;
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(192, 20);
            this.titleTextbox.TabIndex = 43;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(57, 263);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 42;
            this.typeLabel.Text = "Type:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(57, 228);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(47, 13);
            this.contactLabel.TabIndex = 40;
            this.contactLabel.Text = "Contact:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(57, 194);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 39;
            this.locationLabel.Text = "Location:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(57, 123);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 38;
            this.descriptionLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(57, 84);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 37;
            this.titleLabel.Text = "Title:";
            // 
            // startDTP
            // 
            this.startDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.startDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDTP.Location = new System.Drawing.Point(154, 306);
            this.startDTP.Name = "startDTP";
            this.startDTP.Size = new System.Drawing.Size(192, 20);
            this.startDTP.TabIndex = 50;
            // 
            // endDTP
            // 
            this.endDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.endDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDTP.Location = new System.Drawing.Point(154, 355);
            this.endDTP.Name = "endDTP";
            this.endDTP.Size = new System.Drawing.Size(192, 20);
            this.endDTP.TabIndex = 51;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(57, 312);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(58, 13);
            this.startLabel.TabIndex = 52;
            this.startLabel.Text = "Start Time:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(57, 361);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(55, 13);
            this.endLabel.TabIndex = 53;
            this.endLabel.Text = "End Time:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelButton.Location = new System.Drawing.Point(250, 413);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 31);
            this.cancelButton.TabIndex = 54;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // typeCombobox
            // 
            this.typeCombobox.FormattingEnabled = true;
            this.typeCombobox.Items.AddRange(new object[] {
            "Event",
            "Follow Up",
            "Initial Consultation",
            "Lab Visit",
            "Other",
            "Physical",
            "Surgery"});
            this.typeCombobox.Location = new System.Drawing.Point(154, 263);
            this.typeCombobox.Name = "typeCombobox";
            this.typeCombobox.Size = new System.Drawing.Size(192, 21);
            this.typeCombobox.TabIndex = 55;
            // 
            // AddAppoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 487);
            this.Controls.Add(this.typeCombobox);
            this.Controls.Add(this.cancelButton);
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
            this.Controls.Add(this.createCusButton);
            this.Controls.Add(this.custLabel);
            this.Controls.Add(this.appointLabel);
            this.Controls.Add(this.custComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAppoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox custComboBox;
        private System.Windows.Forms.Label appointLabel;
        private System.Windows.Forms.Label custLabel;
        private System.Windows.Forms.Button createCusButton;
        private System.Windows.Forms.TextBox contactTextbox;
        private System.Windows.Forms.TextBox locationTextbox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DateTimePicker startDTP;
        private System.Windows.Forms.DateTimePicker endDTP;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox typeCombobox;
    }
}