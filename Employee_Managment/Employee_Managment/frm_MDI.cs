using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Managment
{
    public partial class frm_MDI : Form
    {
        public frm_MDI()
        {
            InitializeComponent();
        }

        private void frm_MDI_Load(object sender, EventArgs e)
        {
            lbl_Welcome.Text = Employee_User.Username;

        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Employee fae = new frm_Add_Employee();
            fae.MdiParent = this;
            fae.WindowState = FormWindowState.Maximized;
            fae.Show();
        }

        private void singleEmployeeSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Employee fse = new frm_Search_Employee();
            fse.WindowState = FormWindowState.Maximized;
            fse.MdiParent = this;
            fse.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.Exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }

        private void allStudentViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_All_Employee fae = new frm_All_Employee();
            fae.WindowState = FormWindowState.Maximized;
            fae.MdiParent = this;
            fae.Show();

        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Employee fue = new frm_Update_Employee();
            fue.MdiParent = this;
            fue.Show();
        }

       
          
    }
}
