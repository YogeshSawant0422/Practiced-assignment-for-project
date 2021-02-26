namespace Student_Management_System
{
    partial class Frm_Search_Student
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
            this.btn_Clear = new System.Windows.Forms.Button();
            this.dtp_Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_Date_Of_Birth = new System.Windows.Forms.Label();
            this.lbl_Student_Name = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Search_Student = new System.Windows.Forms.Label();
            this.tb_Course = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Clear.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Navy;
            this.btn_Clear.Location = new System.Drawing.Point(399, 424);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(129, 45);
            this.btn_Clear.TabIndex = 15;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // dtp_Date_Of_Birth
            // 
            this.dtp_Date_Of_Birth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_Date_Of_Birth.Enabled = false;
            this.dtp_Date_Of_Birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtp_Date_Of_Birth.Location = new System.Drawing.Point(495, 247);
            this.dtp_Date_Of_Birth.Name = "dtp_Date_Of_Birth";
            this.dtp_Date_Of_Birth.Size = new System.Drawing.Size(233, 29);
            this.dtp_Date_Of_Birth.TabIndex = 13;
            this.dtp_Date_Of_Birth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtp_Date_Of_Birth_KeyPress);
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(495, 181);
            this.tb_Name.MaxLength = 25;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(233, 29);
            this.tb_Name.TabIndex = 12;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Roll_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(495, 110);
            this.tb_Roll_No.MaxLength = 8;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(233, 29);
            this.tb_Roll_No.TabIndex = 11;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Roll_No_KeyPress);
            // 
            // lbl_Course
            // 
            this.lbl_Course.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Course.Location = new System.Drawing.Point(217, 330);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(101, 28);
            this.lbl_Course.TabIndex = 8;
            this.lbl_Course.Text = "Course :";
            // 
            // lbl_Date_Of_Birth
            // 
            this.lbl_Date_Of_Birth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Date_Of_Birth.AutoSize = true;
            this.lbl_Date_Of_Birth.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Of_Birth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Date_Of_Birth.Location = new System.Drawing.Point(217, 248);
            this.lbl_Date_Of_Birth.Name = "lbl_Date_Of_Birth";
            this.lbl_Date_Of_Birth.Size = new System.Drawing.Size(169, 28);
            this.lbl_Date_Of_Birth.TabIndex = 7;
            this.lbl_Date_Of_Birth.Text = "Date Of Birth :";
            // 
            // lbl_Student_Name
            // 
            this.lbl_Student_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Student_Name.AutoSize = true;
            this.lbl_Student_Name.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Student_Name.Location = new System.Drawing.Point(217, 180);
            this.lbl_Student_Name.Name = "lbl_Student_Name";
            this.lbl_Student_Name.Size = new System.Drawing.Size(87, 28);
            this.lbl_Student_Name.TabIndex = 10;
            this.lbl_Student_Name.Text = "Name :";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Roll_No.Location = new System.Drawing.Point(217, 109);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(103, 28);
            this.lbl_Roll_No.TabIndex = 9;
            this.lbl_Roll_No.Text = "Roll No :";
            // 
            // lbl_Search_Student
            // 
            this.lbl_Search_Student.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Search_Student.AutoSize = true;
            this.lbl_Search_Student.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Student.ForeColor = System.Drawing.Color.Red;
            this.lbl_Search_Student.Location = new System.Drawing.Point(341, 26);
            this.lbl_Search_Student.Name = "lbl_Search_Student";
            this.lbl_Search_Student.Size = new System.Drawing.Size(241, 36);
            this.lbl_Search_Student.TabIndex = 6;
            this.lbl_Search_Student.Text = "Search Student";
            // 
            // tb_Course
            // 
            this.tb_Course.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Course.Enabled = false;
            this.tb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course.Location = new System.Drawing.Point(495, 331);
            this.tb_Course.MaxLength = 25;
            this.tb_Course.Name = "tb_Course";
            this.tb_Course.Size = new System.Drawing.Size(233, 29);
            this.tb_Course.TabIndex = 12;
            this.tb_Course.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Course_KeyPress);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Search.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Navy;
            this.btn_Search.Location = new System.Drawing.Point(760, 100);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(129, 45);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Frm_Search_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 495);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dtp_Date_Of_Birth);
            this.Controls.Add(this.tb_Course);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Date_Of_Birth);
            this.Controls.Add(this.lbl_Student_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Search_Student);
            this.Name = "Frm_Search_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Student ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DateTimePicker dtp_Date_Of_Birth;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_Date_Of_Birth;
        private System.Windows.Forms.Label lbl_Student_Name;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Search_Student;
        private System.Windows.Forms.TextBox tb_Course;
        private System.Windows.Forms.Button btn_Search;
    }
}