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
    public partial class Frm_Add_New_Student : Form
    {
        public Frm_Add_New_Student()
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
        void Connection_close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
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
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
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

        int Auto_Incr()
        {
            int cnt = 0;
            Connection_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(Roll_No) from Student_Details",Con);

            cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select MAX(Roll_No) from Student_Details";
                cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                cnt = cnt + 1;
            }
            else
            {
                cnt = 101;
            }

            Connection_close();
            return cnt;

        }
        void Clear_Controls()
        {
            tb_Name.Clear();
            dtp_Date_Of_Birth.Text = "";
            cmb_Course.Text = "";
            cmb_Course.SelectedIndex = -1;
            tb_Roll_No.Focus();

            tb_Roll_No.Text = Convert.ToString(Auto_Incr());
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection_Open();
            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert into Student_Details values(" + tb_Roll_No.Text + ",'" + tb_Name.Text + "','" + dtp_Date_Of_Birth.Text + "','" + cmb_Course.Text + "')", Con);

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Record Save Successfully !!!", "SAVE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All Records !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            Connection_close();
        }

        private void Frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            Connection_Open();
            cmb_Course.Items.Clear();

            SqlCommand cmd = new SqlCommand("select Distinct(Course_Name) from Course_Details",Con);
            SqlDataReader obj = cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Course.Items.Add(obj.GetString(obj.GetOrdinal("Course_Name")));
            }

            obj.Dispose();
            

            tb_Name.Focus();
            cmb_Course.SelectedIndex = -1;
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());

            Connection_close();
        }
    }
}

