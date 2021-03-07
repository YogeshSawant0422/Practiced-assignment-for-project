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
    public partial class frm_Search_Employee : Form
    {
        public frm_Search_Employee()
        {
            InitializeComponent();
        }

        private void frm_Search_Employee_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Employee_Managment_DB;Integrated Security=True");
        void Connection_Open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        void Connection_Closed()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection_Open();

            if (tb_Employee_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select * From Employee_Details Where Employee_ID = " + tb_Employee_ID.Text + " ", con);

                var obj = Cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                    tb_Address.Text = obj.GetString(obj.GetOrdinal("Address"));
                    tb_Mobile_Number.Text = (obj["Mobile_Number"].ToString());
                    dtp_Date_Of_Birth.Text = (obj["Date_Of_Birth"].ToString());
                }
                else
                {
                    MessageBox.Show("Invalid Employee ID!!!", "Opss", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    tb_Employee_ID.Clear();
                    tb_Employee_ID.Focus();
                }
            }
            else
            {
                MessageBox.Show("Enter an Employee ID!!!", "Opss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Employee_ID.Focus();
            }
            

            Connection_Closed();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Employee_ID.Clear();
            tb_Name.Clear();
            tb_Address.Clear();
            tb_Mobile_Number.Clear();

            tb_Employee_ID.Focus();
        }

        private void Is_Digit(object sender, KeyPressEventArgs e)
        {
            if(!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if(!( (char.IsLetter(e.KeyChar)) || (e.KeyChar ==(char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void only_Char(object sender, KeyPressEventArgs e)
        {
            if (((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Digit(object sender, KeyPressEventArgs e)
        {
            if(!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Space)) || (e.KeyChar == (char)Keys.Back) )
            {
                e.Handled = true;
            }
        }
    }
}
