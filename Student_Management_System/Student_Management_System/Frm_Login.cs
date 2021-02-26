using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_System_DB(4);Integrated Security=True");

        void Connection_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        void Connection_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Please Enter Your Username And Password";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Connection_Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from User_Login Where Username ='" + tb_Username.Text + "' And Password ='" + tb_Password.Text + "' ",Con);
             
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if (cnt  >  0)
            {
                MessageBox.Show(" Login Succesfull !!!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Var_User.Username = "Welcome " + tb_Username.Text;

                if (tb_Username.Text == "A")
                {
                    Var_User.U_Roll = 1;
                }
                else if (tb_Username.Text == "q")
                {
                    Var_User.U_Roll = 2;
                }

                MDI_Student_Information obj = new MDI_Student_Information();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Invalid Details !!! Please enter your Valid Details";
                lbl_Note.ForeColor = Color.Red;

                tb_Username.Clear();
                tb_Password.Clear();

                tb_Username.Focus();
            }
            Connection_Close();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void cb_Show_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_Show.Checked)
            {
                tb_Password.UseSystemPasswordChar= true;
            }
            else
            {
                tb_Password.UseSystemPasswordChar= false;
            }
        }
    }
}