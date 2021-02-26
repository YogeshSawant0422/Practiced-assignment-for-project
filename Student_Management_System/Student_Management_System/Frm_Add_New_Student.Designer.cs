namespace Student_Management_System
{
    partial class Frm_Add_New_Student
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
            this.lbl_Add_New_Student = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Student_Name = new System.Windows.Forms.Label();
            this.lbl_Date_Of_Birth = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.dtp_Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Student
            // 
            this.lbl_Add_New_Student.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Add_New_Student.AutoSize = true;
            this.lbl_Add_New_Student.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Student.ForeColor = System.Drawing.Color.Red;
            this.lbl_Add_New_Student.Location = new System.Drawing.Point(284, 44);
            this.lbl_Add_New_Student.Name = "lbl_Add_New_Student";
            this.lbl_Add_New_Student.Size = new System.Drawing.Size(275, 36);
            this.lbl_Add_New_Student.TabIndex = 0;
            this.lbl_Add_New_Student.Text = "Add New Student";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Roll_No.Location = new System.Drawing.Point(160, 127);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(103, 28);
            this.lbl_Roll_No.TabIndex = 1;
            this.lbl_Roll_No.Text = "Roll No :";
            // 
            // lbl_Student_Name
            // 
            this.lbl_Student_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Student_Name.AutoSize = true;
            this.lbl_Student_Name.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Student_Name.Location = new System.Drawing.Point(160, 198);
            this.lbl_Student_Name.Name = "lbl_Student_Name";
            this.lbl_Student_Name.Size = new System.Drawing.Size(87, 28);
            this.lbl_Student_Name.TabIndex = 1;
            this.lbl_Student_Name.Text = "Name :";
            // 
            // lbl_Date_Of_Birth
            // 
            this.lbl_Date_Of_Birth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Date_Of_Birth.AutoSize = true;
            this.lbl_Date_Of_Birth.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Of_Birth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Date_Of_Birth.Location = new System.Drawing.Point(160, 266);
            this.lbl_Date_Of_Birth.Name = "lbl_Date_Of_Birth";
            this.lbl_Date_Of_Birth.Size = new System.Drawing.Size(169, 28);
            this.lbl_Date_Of_Birth.TabIndex = 1;
            this.lbl_Date_Of_Birth.Text = "Date Of Birth :";
            // 
            // lbl_Course
            // 
            this.lbl_Course.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Course.Location = new System.Drawing.Point(160, 348);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(101, 28);
            this.lbl_Course.TabIndex = 1;
            this.lbl_Course.Text = "Course :";
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Roll_No.Enabled = false;
            this.tb_Roll_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(438, 128);
            this.tb_Roll_No.MaxLength = 8;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(233, 29);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.TextChanged += new System.EventHandler(this.tb_Roll_No_TextChanged);
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Roll_No_KeyPress);
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(438, 199);
            this.tb_Name.MaxLength = 25;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(233, 29);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // dtp_Date_Of_Birth
            // 
            this.dtp_Date_Of_Birth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_Date_Of_Birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtp_Date_Of_Birth.Location = new System.Drawing.Point(438, 265);
            this.dtp_Date_Of_Birth.Name = "dtp_Date_Of_Birth";
            this.dtp_Date_Of_Birth.Size = new System.Drawing.Size(233, 29);
            this.dtp_Date_Of_Birth.TabIndex = 3;
            this.dtp_Date_Of_Birth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtp_Date_Of_Birth_KeyPress);
            // 
            // cmb_Course
            // 
            this.cmb_Course.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Location = new System.Drawing.Point(438, 348);
            this.cmb_Course.MaxDropDownItems = 10;
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(233, 32);
            this.cmb_Course.TabIndex = 4;
            this.cmb_Course.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Course_KeyPress);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Navy;
            this.btn_Save.Location = new System.Drawing.Point(342, 442);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(129, 45);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Frm_Add_New_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 509);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_Date_Of_Birth);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Date_Of_Birth);
            this.Controls.Add(this.lbl_Student_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Add_New_Student);
            this.Name = "Frm_Add_New_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Student";
            this.Load += new System.EventHandler(this.Frm_Add_New_Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Student;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Student_Name;
        private System.Windows.Forms.Label lbl_Date_Of_Birth;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.DateTimePicker dtp_Date_Of_Birth;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Button btn_Save;
    }
}