using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Employee_Managment
{
    public partial class frm_Add_Employee : Form
    {
        public frm_Add_Employee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Employee_Managment_DB;Integrated Security=True");
        void Connection_Open()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        void Connection_Closed()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
            
        private void tb_Employee_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsDigit(e.KeyChar)) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;   
            }
        }

        private void tb_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void tb_Mobile_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection_Open();
            {
                if (tb_Employee_ID.Text != "" && tb_Name.Text != "" && tb_Address.Text != "" && tb_Mobile_Number.Text != "" && dtp_Date_Of_Birth.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("Insert into Employee_Details Values (" + tb_Employee_ID.Text + ",'" + tb_Name.Text + "','" + tb_Address.Text + "'," + tb_Mobile_Number.Text + ",'" + dtp_Date_Of_Birth.Text + "')", con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Save Successfully !!!! ","Correct",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    tb_Employee_ID.Clear();
                    tb_Name.Clear();
                    tb_Address.Clear();
                    tb_Mobile_Number.Clear();

                    tb_Employee_ID.Focus();
                }
                else 
                {
                    MessageBox.Show("First Fill All Records","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }

            }
            Connection_Closed();  
        } 
    }
}
