﻿using System;

namespace C969_Project
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.dashLabel = new System.Windows.Forms.Label();
            this.apptGroupbox = new System.Windows.Forms.GroupBox();
            this.monthViewRadio = new System.Windows.Forms.RadioButton();
            this.weekViewRadio = new System.Windows.Forms.RadioButton();
            this.deleteApptButton = new System.Windows.Forms.Button();
            this.updateApptButton = new System.Windows.Forms.Button();
            this.addApptButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.custGroupbox = new System.Windows.Forms.GroupBox();
            this.deleteCusButton = new System.Windows.Forms.Button();
            this.updateCusButton = new System.Windows.Forms.Button();
            this.createCusButton = new System.Windows.Forms.Button();
            this.reportsGroupbox = new System.Windows.Forms.GroupBox();
            this.cusReportButton = new System.Windows.Forms.Button();
            this.schedButton = new System.Windows.Forms.Button();
            this.numApptButton = new System.Windows.Forms.Button();
            this.apptGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.custGroupbox.SuspendLayout();
            this.reportsGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashLabel
            // 
            this.dashLabel.AutoSize = true;
            this.dashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dashLabel.Location = new System.Drawing.Point(414, 9);
            this.dashLabel.Name = "dashLabel";
            this.dashLabel.Size = new System.Drawing.Size(140, 29);
            this.dashLabel.TabIndex = 0;
            this.dashLabel.Text = "Dashboard";
            // 
            // apptGroupbox
            // 
            this.apptGroupbox.Controls.Add(this.monthViewRadio);
            this.apptGroupbox.Controls.Add(this.weekViewRadio);
            this.apptGroupbox.Controls.Add(this.deleteApptButton);
            this.apptGroupbox.Controls.Add(this.updateApptButton);
            this.apptGroupbox.Controls.Add(this.addApptButton);
            this.apptGroupbox.Controls.Add(this.dataGridView1);
            this.apptGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptGroupbox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.apptGroupbox.Location = new System.Drawing.Point(12, 183);
            this.apptGroupbox.Name = "apptGroupbox";
            this.apptGroupbox.Size = new System.Drawing.Size(941, 330);
            this.apptGroupbox.TabIndex = 1;
            this.apptGroupbox.TabStop = false;
            this.apptGroupbox.Text = "Appointments";
            // 
            // monthViewRadio
            // 
            this.monthViewRadio.AutoSize = true;
            this.monthViewRadio.Checked = true;
            this.monthViewRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthViewRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.monthViewRadio.Location = new System.Drawing.Point(615, 38);
            this.monthViewRadio.Name = "monthViewRadio";
            this.monthViewRadio.Size = new System.Drawing.Size(89, 19);
            this.monthViewRadio.TabIndex = 8;
            this.monthViewRadio.TabStop = true;
            this.monthViewRadio.Text = "Month View";
            this.monthViewRadio.UseVisualStyleBackColor = true;
            // 
            // weekViewRadio
            // 
            this.weekViewRadio.AutoSize = true;
            this.weekViewRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weekViewRadio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.weekViewRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.weekViewRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.weekViewRadio.Location = new System.Drawing.Point(489, 38);
            this.weekViewRadio.Name = "weekViewRadio";
            this.weekViewRadio.Size = new System.Drawing.Size(85, 19);
            this.weekViewRadio.TabIndex = 7;
            this.weekViewRadio.Text = "Week View";
            this.weekViewRadio.UseVisualStyleBackColor = true;
            // 
            // deleteApptButton
            // 
            this.deleteApptButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.deleteApptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteApptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteApptButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteApptButton.Location = new System.Drawing.Point(128, 160);
            this.deleteApptButton.Name = "deleteApptButton";
            this.deleteApptButton.Size = new System.Drawing.Size(96, 31);
            this.deleteApptButton.TabIndex = 5;
            this.deleteApptButton.Text = "Delete";
            this.deleteApptButton.UseVisualStyleBackColor = false;
            // 
            // updateApptButton
            // 
            this.updateApptButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateApptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateApptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateApptButton.ForeColor = System.Drawing.SystemColors.Control;
            this.updateApptButton.Location = new System.Drawing.Point(128, 109);
            this.updateApptButton.Name = "updateApptButton";
            this.updateApptButton.Size = new System.Drawing.Size(96, 31);
            this.updateApptButton.TabIndex = 4;
            this.updateApptButton.Text = "Update";
            this.updateApptButton.UseVisualStyleBackColor = false;
            // 
            // addApptButton
            // 
            this.addApptButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addApptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addApptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addApptButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addApptButton.Location = new System.Drawing.Point(128, 58);
            this.addApptButton.Name = "addApptButton";
            this.addApptButton.Size = new System.Drawing.Size(96, 31);
            this.addApptButton.TabIndex = 3;
            this.addApptButton.Text = "Add";
            this.addApptButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(315, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // custGroupbox
            // 
            this.custGroupbox.Controls.Add(this.deleteCusButton);
            this.custGroupbox.Controls.Add(this.updateCusButton);
            this.custGroupbox.Controls.Add(this.createCusButton);
            this.custGroupbox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.custGroupbox.Location = new System.Drawing.Point(12, 41);
            this.custGroupbox.Name = "custGroupbox";
            this.custGroupbox.Size = new System.Drawing.Size(458, 106);
            this.custGroupbox.TabIndex = 2;
            this.custGroupbox.TabStop = false;
            this.custGroupbox.Text = "Customer Records";
            // 
            // deleteCusButton
            // 
            this.deleteCusButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.deleteCusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCusButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteCusButton.Location = new System.Drawing.Point(274, 42);
            this.deleteCusButton.Name = "deleteCusButton";
            this.deleteCusButton.Size = new System.Drawing.Size(96, 31);
            this.deleteCusButton.TabIndex = 2;
            this.deleteCusButton.Text = "Delete";
            this.deleteCusButton.UseVisualStyleBackColor = false;
            this.deleteCusButton.Click += new System.EventHandler(this.deleteCusButton_Click);
            // 
            // updateCusButton
            // 
            this.updateCusButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.updateCusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCusButton.ForeColor = System.Drawing.SystemColors.Control;
            this.updateCusButton.Location = new System.Drawing.Point(172, 42);
            this.updateCusButton.Name = "updateCusButton";
            this.updateCusButton.Size = new System.Drawing.Size(96, 31);
            this.updateCusButton.TabIndex = 1;
            this.updateCusButton.Text = "Update";
            this.updateCusButton.UseVisualStyleBackColor = false;
            this.updateCusButton.Click += new System.EventHandler(this.updateCusButton_Click);
            // 
            // createCusButton
            // 
            this.createCusButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.createCusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCusButton.ForeColor = System.Drawing.SystemColors.Control;
            this.createCusButton.Location = new System.Drawing.Point(70, 42);
            this.createCusButton.Name = "createCusButton";
            this.createCusButton.Size = new System.Drawing.Size(96, 31);
            this.createCusButton.TabIndex = 0;
            this.createCusButton.Text = "Create";
            this.createCusButton.UseVisualStyleBackColor = false;
            this.createCusButton.Click += new System.EventHandler(this.createCusButton_Click);
            // 
            // reportsGroupbox
            // 
            this.reportsGroupbox.Controls.Add(this.cusReportButton);
            this.reportsGroupbox.Controls.Add(this.schedButton);
            this.reportsGroupbox.Controls.Add(this.numApptButton);
            this.reportsGroupbox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.reportsGroupbox.Location = new System.Drawing.Point(501, 41);
            this.reportsGroupbox.Name = "reportsGroupbox";
            this.reportsGroupbox.Size = new System.Drawing.Size(452, 106);
            this.reportsGroupbox.TabIndex = 3;
            this.reportsGroupbox.TabStop = false;
            this.reportsGroupbox.Text = "Reports";
            // 
            // cusReportButton
            // 
            this.cusReportButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.cusReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cusReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusReportButton.ForeColor = System.Drawing.SystemColors.Control;
            this.cusReportButton.Location = new System.Drawing.Point(312, 38);
            this.cusReportButton.Name = "cusReportButton";
            this.cusReportButton.Size = new System.Drawing.Size(121, 31);
            this.cusReportButton.TabIndex = 5;
            this.cusReportButton.Text = "Customer Report";
            this.cusReportButton.UseVisualStyleBackColor = false;
            this.cusReportButton.Click += new System.EventHandler(this.cusReportButton_Click);
            // 
            // schedButton
            // 
            this.schedButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.schedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.schedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.schedButton.ForeColor = System.Drawing.SystemColors.Control;
            this.schedButton.Location = new System.Drawing.Point(178, 38);
            this.schedButton.Name = "schedButton";
            this.schedButton.Size = new System.Drawing.Size(128, 31);
            this.schedButton.TabIndex = 4;
            this.schedButton.Text = "Consultant Schedules";
            this.schedButton.UseVisualStyleBackColor = false;
            this.schedButton.Click += new System.EventHandler(this.schedButton_Click);
            // 
            // numApptButton
            // 
            this.numApptButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.numApptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numApptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numApptButton.ForeColor = System.Drawing.SystemColors.Control;
            this.numApptButton.Location = new System.Drawing.Point(30, 38);
            this.numApptButton.Name = "numApptButton";
            this.numApptButton.Size = new System.Drawing.Size(142, 31);
            this.numApptButton.TabIndex = 3;
            this.numApptButton.Text = "Number of Appointments";
            this.numApptButton.UseVisualStyleBackColor = false;
            this.numApptButton.Click += new System.EventHandler(this.numApptButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(965, 525);
            this.Controls.Add(this.reportsGroupbox);
            this.Controls.Add(this.custGroupbox);
            this.Controls.Add(this.apptGroupbox);
            this.Controls.Add(this.dashLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.apptGroupbox.ResumeLayout(false);
            this.apptGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.custGroupbox.ResumeLayout(false);
            this.reportsGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label dashLabel;
        private System.Windows.Forms.GroupBox apptGroupbox;
        private System.Windows.Forms.GroupBox custGroupbox;
        private System.Windows.Forms.GroupBox reportsGroupbox;
        private System.Windows.Forms.Button createCusButton;
        private System.Windows.Forms.Button updateCusButton;
        private System.Windows.Forms.Button deleteCusButton;
        private System.Windows.Forms.Button cusReportButton;
        private System.Windows.Forms.Button schedButton;
        private System.Windows.Forms.Button numApptButton;
        private System.Windows.Forms.RadioButton monthViewRadio;
        private System.Windows.Forms.RadioButton weekViewRadio;
        private System.Windows.Forms.Button deleteApptButton;
        private System.Windows.Forms.Button updateApptButton;
        private System.Windows.Forms.Button addApptButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}