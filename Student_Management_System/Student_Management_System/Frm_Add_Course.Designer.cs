namespace Student_Management_System
{
    partial class Frm_Add_Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Add_Course));
            this.lbl_Add_New_Course = new System.Windows.Forms.Label();
            this.lbl_Course_Name = new System.Windows.Forms.Label();
            this.lbl_Course_ID = new System.Windows.Forms.Label();
            this.tb_Course_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Course_Name = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Course
            // 
            this.lbl_Add_New_Course.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Add_New_Course.AutoSize = true;
            this.lbl_Add_New_Course.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Course.ForeColor = System.Drawing.Color.Red;
            this.lbl_Add_New_Course.Location = new System.Drawing.Point(290, 27);
            this.lbl_Add_New_Course.Name = "lbl_Add_New_Course";
            this.lbl_Add_New_Course.Size = new System.Drawing.Size(259, 36);
            this.lbl_Add_New_Course.TabIndex = 17;
            this.lbl_Add_New_Course.Text = "Add New Course";
            // 
            // lbl_Course_Name
            // 
            this.lbl_Course_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Course_Name.AutoSize = true;
            this.lbl_Course_Name.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Course_Name.Location = new System.Drawing.Point(162, 238);
            this.lbl_Course_Name.Name = "lbl_Course_Name";
            this.lbl_Course_Name.Size = new System.Drawing.Size(169, 28);
            this.lbl_Course_Name.TabIndex = 19;
            this.lbl_Course_Name.Text = "Course Name :";
            // 
            // lbl_Course_ID
            // 
            this.lbl_Course_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Course_ID.AutoSize = true;
            this.lbl_Course_ID.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_ID.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Course_ID.Location = new System.Drawing.Point(162, 148);
            this.lbl_Course_ID.Name = "lbl_Course_ID";
            this.lbl_Course_ID.Size = new System.Drawing.Size(126, 28);
            this.lbl_Course_ID.TabIndex = 18;
            this.lbl_Course_ID.Text = "Course ID:";
            // 
            // tb_Course_ID
            // 
            this.tb_Course_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Course_ID.Enabled = false;
            this.tb_Course_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_ID.Location = new System.Drawing.Point(409, 149);
            this.tb_Course_ID.MaxLength = 8;
            this.tb_Course_ID.Name = "tb_Course_ID";
            this.tb_Course_ID.Size = new System.Drawing.Size(233, 29);
            this.tb_Course_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(162, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Course Name :";
            // 
            // tb_Course_Name
            // 
            this.tb_Course_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Name.Location = new System.Drawing.Point(409, 239);
            this.tb_Course_Name.MaxLength = 8;
            this.tb_Course_Name.Name = "tb_Course_Name";
            this.tb_Course_Name.Size = new System.Drawing.Size(233, 29);
            this.tb_Course_Name.TabIndex = 2;
            this.tb_Course_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Course_Name_KeyPress);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Navy;
            this.btn_Save.Location = new System.Drawing.Point(322, 348);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(129, 45);
            this.btn_Save.TabIndex = 27;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Frm_Add_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 481);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Course_Name);
            this.Controls.Add(this.tb_Course_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Course_Name);
            this.Controls.Add(this.lbl_Course_ID);
            this.Controls.Add(this.lbl_Add_New_Course);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Add_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Course";
            this.Load += new System.EventHandler(this.Frm_Add_Course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Course;
        private System.Windows.Forms.Label lbl_Course_Name;
        private System.Windows.Forms.Label lbl_Course_ID;
        private System.Windows.Forms.TextBox tb_Course_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Course_Name;
        private System.Windows.Forms.Button btn_Save;
    }
}