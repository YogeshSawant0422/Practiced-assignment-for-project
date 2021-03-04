using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Book_Managment
{
    public partial class frm_Add_New_Book : Form
    {
        public frm_Add_New_Book()
        {
            InitializeComponent();
        }

        private void frm_Add_New_Book_Load(object sender, EventArgs e)
        {
            
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Book_Managment_DB;Integrated Security=True");

        void Connection_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }

        }

        void Connection_Closed()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }

        }
            
        private void btn_log_out_Click(object sender, EventArgs e)
        {
            frm_Login_form flf = new frm_Login_form();

            flf.Show();

            this.Hide();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;

            }
        }

        private void Alpha_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {

                e.Handled = true;
            }

        }

        private void Is_Price(object sender, KeyPressEventArgs e)
        {

            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }

        }

        private void btn_view_all_book_Click(object sender, EventArgs e)
        {
            dgv_all_book_details dgv = new dgv_all_book_details();

            dgv.Show();

            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection_Open();
            if (tb_BooK_ID.Text != "" && tb_Book_Name.Text != "" && tb_Publication.Text != "" && tb_Book_Price.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Insert Into Book_Details Values (" + tb_BooK_ID.Text + ",'" + tb_Book_Name.Text + "','" + tb_Publication.Text + "'," + tb_Book_Price.Text + ")",Con);
                    
                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Save Successfully !!!");

                tb_BooK_ID.Clear();
                tb_Book_Name.Clear();
                tb_Publication.Clear();
                tb_Book_Price.Clear();

                tb_BooK_ID.Focus();
            }
            else
            {
                MessageBox.Show("First fill All the fields !!!");
            }

              Connection_Closed();
        }
    }
}
