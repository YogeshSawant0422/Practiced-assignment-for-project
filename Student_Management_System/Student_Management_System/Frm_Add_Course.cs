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
    public partial class Frm_Add_Course : Form
    {
        public Frm_Add_Course()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_System_DB(4);Integrated Security=True");
        
        void connection_open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        void connection_close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        int AutoIncr()
        {
            connection_open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand(" Select Count(*) From Course_Details ", Con);

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cnt = Cnt + 1;

            connection_close();

            return Cnt;
        }

        private void tb_CID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Course_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            connection_open();

            if (tb_Course_Name.Text != "")
            {
                SqlCommand cmd = new SqlCommand(" Insert into Course_Details values (" + tb_Course_ID.Text + " ,'" + tb_Course_Name.Text + "')", Con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Course Add Succefully !!!!");
                tb_Course_ID.Clear();
                tb_Course_Name.Clear();
                tb_Course_ID.Text = Convert.ToString(AutoIncr());
            }
            else
            {
                MessageBox.Show("1st Enter Course Name!!!");
            }

            connection_close();
        }

        private void Frm_Add_Course_Load(object sender, EventArgs e)
        {
             tb_Course_ID.Text = Convert.ToString(AutoIncr());
        }
    }
}
