using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Frm_View_All_Student : Form
    {
        public Frm_View_All_Student()
        {
            InitializeComponent();
        }

        private void Frm_View_All_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Student_Management_System_DB_4_DataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this._Student_Management_System_DB_4_DataSet.Student_Details);

        }
    }
}
