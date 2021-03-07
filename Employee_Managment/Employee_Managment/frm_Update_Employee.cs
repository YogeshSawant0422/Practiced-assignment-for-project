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
    public partial class frm_Update_Employee : Form
    {
        public frm_Update_Employee()
        {
            InitializeComponent();
        }

        private void frm_Update_Employee_Load(object sender, EventArgs e)
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
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        void Controls_Enable()
        {
            tb_Name.Enabled = true;
            tb_Address.Enabled = true;
            tb_Mobile_Number.Enabled = true;
            dtp_Date_Of_Birth.Enabled = true;

            tb_Employee_ID.Enabled = false;
        }

        void Controls_Disable()
        {
            tb_Name.Enabled = false;
            tb_Address.Enabled = false;
            tb_Mobile_Number.Enabled = false;
            dtp_Date_Of_Birth.Enabled = false;

            tb_Employee_ID.Enabled = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            Connection_Open();
            if (tb_Employee_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select * From Employee_Details Where Employee_Id = " + tb_Employee_ID.Text + " ", con);

                var obj = Cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                    tb_Address.Text = obj.GetString(obj.GetOrdinal("Address"));
                    tb_Mobile_Number.Text = (obj["Mobile_Number"].ToString());
                    dtp_Date_Of_Birth.Text = (obj["Date_Of_Birth"].ToString());

                    Controls_Enable();
                }
                else
                {
                    MessageBox.Show("Invalid Employee ID!!!", "Whats Wrong", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    tb_Employee_ID.Clear();
                    tb_Employee_ID.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Employee ID");
            }
            Connection_Closed();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employee_ID.Clear();
            tb_Name.Clear();
            tb_Address.Clear();
            tb_Mobile_Number.Clear();

            tb_Employee_ID.Focus();

            Controls_Disable();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Connection_Open();
            if (tb_Employee_ID.Text != "" && tb_Name.Text != "" && tb_Address.Text != "" && tb_Mobile_Number.Text != "" && dtp_Date_Of_Birth.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Update Employee_Details Set Name='" + tb_Name.Text + "', Address ='" + tb_Address.Text + "',Mobile_Number=" + tb_Mobile_Number.Text + ",Date_Of_Birth ='" + dtp_Date_Of_Birth.Text + "'where Employee_Id = " + tb_Employee_ID.Text + "", con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Update Successfully!!!","Updated",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btn_Reset.PerformClick();
            }
            else 
            {
                MessageBox.Show("First fill all records !!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Connection_Closed();
        }

        private void tb_Employee_ID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void tb_Mobile_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
