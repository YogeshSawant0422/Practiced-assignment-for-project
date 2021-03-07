using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Managment
{
    public partial class frm_All_Employee : Form
    {
        public frm_All_Employee()
        {
            InitializeComponent();
        }

        private void lbl_All_Emloyee_Click(object sender, EventArgs e)
        {

        }

        private void frm_All_Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_Managment_DBDataSet.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.employee_Managment_DBDataSet.Employee_Details);

        }
    }
}
