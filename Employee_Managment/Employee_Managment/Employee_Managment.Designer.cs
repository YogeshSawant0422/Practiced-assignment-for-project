namespace Employee_Managment
{
    partial class frm_Employee_MDI
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
            this.mst_Menu_Strip = new System.Windows.Forms.MenuStrip();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mst_Menu_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mst_Menu_Strip
            // 
            this.mst_Menu_Strip.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mst_Menu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.searchEmployeeToolStripMenuItem,
            this.allEmployeeToolStripMenuItem});
            this.mst_Menu_Strip.Location = new System.Drawing.Point(0, 0);
            this.mst_Menu_Strip.Name = "mst_Menu_Strip";
            this.mst_Menu_Strip.Size = new System.Drawing.Size(945, 32);
            this.mst_Menu_Strip.TabIndex = 0;
            this.mst_Menu_Strip.Text = "Menu Strip";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(137, 28);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            // 
            // searchEmployeeToolStripMenuItem
            // 
            this.searchEmployeeToolStripMenuItem.Name = "searchEmployeeToolStripMenuItem";
            this.searchEmployeeToolStripMenuItem.Size = new System.Drawing.Size(160, 28);
            this.searchEmployeeToolStripMenuItem.Text = "Search Employee";
            // 
            // allEmployeeToolStripMenuItem
            // 
            this.allEmployeeToolStripMenuItem.Name = "allEmployeeToolStripMenuItem";
            this.allEmployeeToolStripMenuItem.Size = new System.Drawing.Size(129, 28);
            this.allEmployeeToolStripMenuItem.Text = "All Employee";
            // 
            // frm_Employee_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(945, 453);
            this.Controls.Add(this.mst_Menu_Strip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mst_Menu_Strip;
            this.Name = "frm_Employee_MDI";
            this.Text = "Employee MDI";
            this.mst_Menu_Strip.ResumeLayout(false);
            this.mst_Menu_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip mst_Menu_Strip;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allEmployeeToolStripMenuItem;
    }
}



