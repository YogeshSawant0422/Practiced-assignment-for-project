namespace Student_Management_System
{
    partial class MDI_Student_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Student_Information));
            this.menuStrip_Student = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchSingleStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchSingleStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dynamicViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.menuStrip_Student.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Student
            // 
            this.menuStrip_Student.AutoSize = false;
            this.menuStrip_Student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip_Student.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip_Student.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.searchSingleStudentToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.courseToolStripMenuItem});
            this.menuStrip_Student.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Student.Name = "menuStrip_Student";
            this.menuStrip_Student.Size = new System.Drawing.Size(952, 49);
            this.menuStrip_Student.TabIndex = 2;
            this.menuStrip_Student.Text = "Student Information";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.updateStudentToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(51, 45);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // updateStudentToolStripMenuItem
            // 
            this.updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            this.updateStudentToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.updateStudentToolStripMenuItem.Text = "Update Student";
            this.updateStudentToolStripMenuItem.Visible = false;
            this.updateStudentToolStripMenuItem.Click += new System.EventHandler(this.updateStudentToolStripMenuItem_Click);
            // 
            // searchSingleStudentToolStripMenuItem
            // 
            this.searchSingleStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchSingleStudentToolStripMenuItem1,
            this.viewAllStudentToolStripMenuItem,
            this.dynamicViewToolStripMenuItem});
            this.searchSingleStudentToolStripMenuItem.Name = "searchSingleStudentToolStripMenuItem";
            this.searchSingleStudentToolStripMenuItem.Size = new System.Drawing.Size(57, 45);
            this.searchSingleStudentToolStripMenuItem.Text = "View";
            // 
            // searchSingleStudentToolStripMenuItem1
            // 
            this.searchSingleStudentToolStripMenuItem1.Name = "searchSingleStudentToolStripMenuItem1";
            this.searchSingleStudentToolStripMenuItem1.Size = new System.Drawing.Size(242, 24);
            this.searchSingleStudentToolStripMenuItem1.Text = "Search Single Student";
            this.searchSingleStudentToolStripMenuItem1.Click += new System.EventHandler(this.searchSingleStudentToolStripMenuItem1_Click);
            // 
            // viewAllStudentToolStripMenuItem
            // 
            this.viewAllStudentToolStripMenuItem.Name = "viewAllStudentToolStripMenuItem";
            this.viewAllStudentToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.viewAllStudentToolStripMenuItem.Text = "View All Student";
            this.viewAllStudentToolStripMenuItem.Click += new System.EventHandler(this.viewAllStudentToolStripMenuItem_Click);
            // 
            // dynamicViewToolStripMenuItem
            // 
            this.dynamicViewToolStripMenuItem.Name = "dynamicViewToolStripMenuItem";
            this.dynamicViewToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.dynamicViewToolStripMenuItem.Text = "Dynamic View";
            this.dynamicViewToolStripMenuItem.Click += new System.EventHandler(this.dynamicViewToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notepadToolStripMenuItem,
            this.calculatorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(60, 45);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Visible = false;
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCourseToolStripMenuItem});
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(71, 45);
            this.courseToolStripMenuItem.Text = "Course";
            this.courseToolStripMenuItem.Visible = false;
            // 
            // addNewCourseToolStripMenuItem
            // 
            this.addNewCourseToolStripMenuItem.Name = "addNewCourseToolStripMenuItem";
            this.addNewCourseToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.addNewCourseToolStripMenuItem.Text = "Add New Course";
            this.addNewCourseToolStripMenuItem.Click += new System.EventHandler(this.addNewCourseToolStripMenuItem_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Log_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Log_Out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Log_Out.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Log_Out.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.White;
            this.btn_Log_Out.Location = new System.Drawing.Point(816, 12);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(124, 30);
            this.btn_Log_Out.TabIndex = 4;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Welcome.Location = new System.Drawing.Point(665, 17);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(82, 20);
            this.lbl_Welcome.TabIndex = 6;
            this.lbl_Welcome.Text = "Welcome";
            // 
            // MDI_Student_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(952, 555);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.menuStrip_Student);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip_Student;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDI_Student_Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MDI_Student_Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Student_Information_Load);
            this.menuStrip_Student.ResumeLayout(false);
            this.menuStrip_Student.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Student;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchSingleStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchSingleStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAllStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dynamicViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCourseToolStripMenuItem;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_Welcome;


    }
}