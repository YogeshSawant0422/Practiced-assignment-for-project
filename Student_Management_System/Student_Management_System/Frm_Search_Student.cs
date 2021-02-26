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
    public partial class Frm_Search_Student : Form
    {
        public Frm_Search_Student()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_System_DB(4);Integrated Security=True");

        void con_open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        void con_close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
                            

        private void tb_Roll_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void dtp_Date_Of_Birth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void tb_Course_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            con_open();
            if (tb_Roll_No.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select * from Student_Details where Roll_No= " + tb_Roll_No.Text + "", con);
                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Roll_No.Text = obj["Roll_No"].ToString();
                    tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                    dtp_Date_Of_Birth.Text = obj.GetString(obj.GetOrdinal("Date_Of_Birth"));
                    tb_Course.Text = obj.GetString(obj.GetOrdinal("Course"));
                }
                else
                {
                    MessageBox.Show("Invalid  Roll No", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("First Fill Roll No","Fill The Record",MessageBoxButtons.OK,MessageBoxIcon.Error);
                tb_Roll_No.Clear();
                tb_Roll_No.Focus();
            }
            con_close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            dtp_Date_Of_Birth.Text = "";
            tb_Course.Clear();
        }
    }
}
