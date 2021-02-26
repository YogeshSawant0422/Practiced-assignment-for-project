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
    public partial class Frm_Student_Details_By_Course_Dynamic : Form
    {
        public Frm_Student_Details_By_Course_Dynamic()
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
        void Connection_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void Frm_Student_Details_By_Course_Dynamic_Load(object sender, EventArgs e)
        {
            Connection_Open();
            SqlCommand Cmd = new SqlCommand("Select Distinct(Course) from Student_Details",Con);
            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Course.Items.Add(obj.GetString(obj.GetOrdinal("Course")));
            }
            obj.Dispose();

            SqlDataAdapter sda = new SqlDataAdapter("select * from student_details",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_Student_Details.DataSource = dt;

            Connection_Close();
        }

        private void cmb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection_Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Student_Details where Course='" + cmb_Course.Text + "'",Con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_Student_Details.DataSource = dt;
            Connection_Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection_Open();
            if (cmb_Course.Text != "" && tb_Roll_No.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from Student_Details Where Roll_No = " + tb_Roll_No.Text + " And Course = '" + cmb_Course.Text + "'", Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                dgv_Student_Details.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Enetr Roll Number !!!!");
            }
            Connection_Close();
        }

        private void btn_Refresh_Grid_Click(object sender, EventArgs e)
        {
            Connection_Open();
            cmb_Course.SelectedIndex = -1;
            tb_Roll_No.Clear();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Student_Details",Con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_Student_Details.DataSource = dt;

            Connection_Close();
        }
    }
}
