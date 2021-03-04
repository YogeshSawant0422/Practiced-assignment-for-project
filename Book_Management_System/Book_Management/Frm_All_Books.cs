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
    public partial class dgv_all_book_details : Form
    {
        public dgv_all_book_details()
        {
            InitializeComponent();
        }

        private void btn_add_new_book_Click(object sender, EventArgs e)
        {
            frm_Add_New_Book fanb = new frm_Add_New_Book();

            fanb.Show();

            this.Hide();
        }

        private void btn_log_out2_Click(object sender, EventArgs e)
        {
            frm_Login_form flg = new frm_Login_form();

            flg.Show();

            this.Hide();

        }

        private void dgv_all_book_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'book_Managment_DBDataSet1.Book_Details' table. You can move, or remove it, as needed.
            this.book_DetailsTableAdapter2.Fill(this.book_Managment_DBDataSet1.Book_Details);
            // TODO: This line of code loads data into the 'book_Managment_DBDataSet.Book_Details' table. You can move, or remove it, as needed.
            this.book_DetailsTableAdapter1.Fill(this.book_Managment_DBDataSet.Book_Details);
            // TODO: This line of code loads data into the 'dataSet1.Book_Details' table. You can move, or remove it, as needed.
            //this.book_DetailsTableAdapter.Fill(this.dataSet1.Book_Details);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
