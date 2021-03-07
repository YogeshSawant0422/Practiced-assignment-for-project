﻿namespace Employee_Managment
{
    partial class frm_Search_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Search_Employee));
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            this.tb_Mobile_Number = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Employee_ID = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Employee_ID = new System.Windows.Forms.Label();
            this.lbl_Search_Employee = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(532, 412);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(144, 47);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtp_Date_Of_Birth
            // 
            this.dtp_Date_Of_Birth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_Date_Of_Birth.Enabled = false;
            this.dtp_Date_Of_Birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date_Of_Birth.Location = new System.Drawing.Point(508, 348);
            this.dtp_Date_Of_Birth.Name = "dtp_Date_Of_Birth";
            this.dtp_Date_Of_Birth.Size = new System.Drawing.Size(236, 26);
            this.dtp_Date_Of_Birth.TabIndex = 5;
            // 
            // tb_Mobile_Number
            // 
            this.tb_Mobile_Number.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Mobile_Number.Enabled = false;
            this.tb_Mobile_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_Number.Location = new System.Drawing.Point(508, 280);
            this.tb_Mobile_Number.MaxLength = 10;
            this.tb_Mobile_Number.Name = "tb_Mobile_Number";
            this.tb_Mobile_Number.Size = new System.Drawing.Size(236, 26);
            this.tb_Mobile_Number.TabIndex = 4;
            this.tb_Mobile_Number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Digit);
            // 
            // tb_Address
            // 
            this.tb_Address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Address.Enabled = false;
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(508, 212);
            this.tb_Address.MaxLength = 20;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(236, 26);
            this.tb_Address.TabIndex = 3;
            this.tb_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.only_Char);
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tb_Name.Location = new System.Drawing.Point(508, 153);
            this.tb_Name.MaxLength = 25;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(236, 26);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Employee_ID
            // 
            this.tb_Employee_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Employee_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tb_Employee_ID.Location = new System.Drawing.Point(508, 95);
            this.tb_Employee_ID.MaxLength = 5;
            this.tb_Employee_ID.Name = "tb_Employee_ID";
            this.tb_Employee_ID.Size = new System.Drawing.Size(236, 26);
            this.tb_Employee_ID.TabIndex = 1;
            this.tb_Employee_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Digit);
            // 
            // lbl_Address
            // 
            this.lbl_Address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Address.Location = new System.Drawing.Point(220, 219);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(92, 23);
            this.lbl_Address.TabIndex = 0;
            this.lbl_Address.Text = "Address :";
            this.lbl_Address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_DOB.Location = new System.Drawing.Point(220, 345);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(134, 23);
            this.lbl_DOB.TabIndex = 0;
            this.lbl_DOB.Text = "Date Of Birth :";
            this.lbl_DOB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(220, 280);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(157, 23);
            this.lbl_Mobile_No.TabIndex = 0;
            this.lbl_Mobile_No.Text = "Mobile Number :";
            this.lbl_Mobile_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Name.Location = new System.Drawing.Point(220, 153);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(72, 23);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name :";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Employee_ID
            // 
            this.lbl_Employee_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Employee_ID.AutoSize = true;
            this.lbl_Employee_ID.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Employee_ID.Location = new System.Drawing.Point(220, 99);
            this.lbl_Employee_ID.Name = "lbl_Employee_ID";
            this.lbl_Employee_ID.Size = new System.Drawing.Size(131, 23);
            this.lbl_Employee_ID.TabIndex = 0;
            this.lbl_Employee_ID.Text = "Employee ID :";
            this.lbl_Employee_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Search_Employee
            // 
            this.lbl_Search_Employee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Search_Employee.AutoSize = true;
            this.lbl_Search_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Search_Employee.Location = new System.Drawing.Point(380, 32);
            this.lbl_Search_Employee.Name = "lbl_Search_Employee";
            this.lbl_Search_Employee.Size = new System.Drawing.Size(181, 25);
            this.lbl_Search_Employee.TabIndex = 0;
            this.lbl_Search_Employee.Text = "Search Employee";
            this.lbl_Search_Employee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(299, 412);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(144, 47);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // frm_Search_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 471);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dtp_Date_Of_Birth);
            this.Controls.Add(this.tb_Mobile_Number);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Employee_ID);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Employee_ID);
            this.Controls.Add(this.lbl_Search_Employee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Search_Employee";
            this.ShowIcon = false;
            this.Text = "Search Employee";
            this.Load += new System.EventHandler(this.frm_Search_Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_Date_Of_Birth;
        private System.Windows.Forms.TextBox tb_Mobile_Number;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Employee_ID;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Employee_ID;
        private System.Windows.Forms.Label lbl_Search_Employee;
        private System.Windows.Forms.Button btn_Clear;
    }
}