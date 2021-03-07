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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Enter your Username and Password";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "y" & tb_Password.Text == "y" || tb_Username.Text == "u" & tb_Password.Text == "u") 

            {
                MessageBox.Show("Login Successfull !!!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Employee_User.Username = "Welcome " + tb_Username.Text;
                frm_MDI obj = new frm_MDI();
                obj.Show();
                this.Hide();
            }
            else
            { 
                MessageBox.Show("Invalid Username And Passsword !!!!!","Failed Login",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                tb_Username.Clear();
                tb_Password.Clear();

                tb_Username.Focus();
            }
        }
        private void tb_Username_TextChanged(object sender, EventArgs e)
        { 
          tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
           btn_Submit.Enabled = true;        
        }

    }
}
