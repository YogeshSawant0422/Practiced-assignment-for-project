using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class MDI_Student_Information : Form
    {
        public MDI_Student_Information()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Student ans = new Frm_Add_New_Student();
            ans.MdiParent = this;
            ans.WindowState = FormWindowState.Maximized;
            ans.Show();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            Frm_Login obj = new Frm_Login();
            obj.Show();
            this.Hide();
            Var_User.Username = "";
            Var_User.U_Roll = 0;

            updateStudentToolStripMenuItem.Visible = false;
            courseToolStripMenuItem.Visible = false;
            calculatorToolStripMenuItem.Visible = false;

        }

        private void searchSingleStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Search_Student obj = new Frm_Search_Student();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.Show();
        }

        private void viewAllStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_View_All_Student obj = new Frm_View_All_Student();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.Show();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Update_Student obj = new Frm_Update_Student();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.Show();
        }

        private void addNewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Course obj = new Frm_Add_Course();
            
            obj.Show();
        }

        private void MDI_Student_Information_Load(object sender, EventArgs e)
        {
            lbl_Welcome.Text = Var_User.Username;

            if (Var_User.U_Roll == 1)
            {
                updateStudentToolStripMenuItem.Visible = true;
                courseToolStripMenuItem.Visible = true;
                calculatorToolStripMenuItem.Visible = true;
            }
            else if (Var_User.U_Roll == 2)
            {
                updateStudentToolStripMenuItem.Visible = false;
                courseToolStripMenuItem.Visible = false;
                calculatorToolStripMenuItem.Visible = true;
            }
        }

        private void dynamicViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Student_Details_By_Course_Dynamic obj = new Frm_Student_Details_By_Course_Dynamic();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}
