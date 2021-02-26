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
    public partial class Frm_Update_Student : Form
    {
        public Frm_Update_Student()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_System_DB(4);Integrated Security=True");

        void con_Open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        void con_closed()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        void Controls_Enable()
        {
            tb_Name.Enabled = true;
            dtp_Date_Of_Birth.Enabled = true;
            cmb_Course.Enabled = true;

            tb_Roll_No.Enabled = false;

        }
        void Controls_Disable()
        {
            tb_Name.Enabled = false;
            dtp_Date_Of_Birth.Enabled = false;
            cmb_Course.Enabled = false;

            tb_Roll_No.Enabled = true;
        }
 
        private void btn_Search_Click(object sender, EventArgs e)
        {
            con_Open();
            if (tb_Roll_No.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select * from Student_Details Where Roll_NO = " + tb_Roll_No.Text + "", con);
                var obj = cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                    dtp_Date_Of_Birth.Text = (obj["Date_Of_Birth"].ToString());
                    
                    cmb_Course.Text = Convert.ToString((obj["Course"].ToString()));

                    Controls_Enable();
                }
                else
                {
                    MessageBox.Show("Invalid Roll No", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Roll_No.Clear();
                    tb_Roll_No.Focus();
                }
            }
            else
            {
                MessageBox.Show("First Fill The Roll_NO","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void btn_Update_Student_Click(object sender, EventArgs e)
        {
            con_Open();
            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && cmb_Course.Text != "" && dtp_Date_Of_Birth.Text != "")
            {
                    SqlCommand cmd = new SqlCommand("Update Student_Details set Name = '" + tb_Name.Text + "',Date_Of_Birth = '" + dtp_Date_Of_Birth.Text + "',Course = '" + cmb_Course.Text + "' where Roll_No = " + tb_Roll_No.Text + "", con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Update Succesfully", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("First Fill All Records !!!");
            }

            con_closed();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            cmb_Course.Text = "";
            dtp_Date_Of_Birth.Text = "";

            Controls_Disable();
           
        }

        private void tb_Roll_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void dtp_Date_Of_Birth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void cmb_Course_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }
    }
}
