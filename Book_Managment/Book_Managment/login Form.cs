using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_Managment
{
    public partial class frm_Login_form : Form
    {
        public frm_Login_form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Login_form_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Please enter your username && password";

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "yogesh" && txt_Password.Text == "y123")
            {
                MessageBox.Show("Login Successfull !!!!");

                frm_Add_New_Book obj = new frm_Add_New_Book();
                obj.Show();

                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Please enter valid details.";
                lbl_Note.ForeColor = Color.Red;
                   
            }
            txt_username.Text = "";
            txt_Password.Text = "";

            txt_username.Focus();

        }

        
    }
}
