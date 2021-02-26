namespace Student_Management_System
{
    partial class Frm_Student_Details_By_Course_Dynamic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Dynamic = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.dgv_Student_Details = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh_Grid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Dynamic
            // 
            this.lbl_Dynamic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Dynamic.AutoSize = true;
            this.lbl_Dynamic.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dynamic.ForeColor = System.Drawing.Color.Red;
            this.lbl_Dynamic.Location = new System.Drawing.Point(211, 22);
            this.lbl_Dynamic.Name = "lbl_Dynamic";
            this.lbl_Dynamic.Size = new System.Drawing.Size(427, 34);
            this.lbl_Dynamic.TabIndex = 0;
            this.lbl_Dynamic.Text = "View Student Details By Course";
            // 
            // lbl_Course
            // 
            this.lbl_Course.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Course.Location = new System.Drawing.Point(104, 84);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(113, 32);
            this.lbl_Course.TabIndex = 0;
            this.lbl_Course.Text = "Course :";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Roll_No.Location = new System.Drawing.Point(104, 143);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(103, 28);
            this.lbl_Roll_No.TabIndex = 0;
            this.lbl_Roll_No.Text = "Roll No :";
            // 
            // cmb_Course
            // 
            this.cmb_Course.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Location = new System.Drawing.Point(267, 91);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(217, 27);
            this.cmb_Course.TabIndex = 1;
            this.cmb_Course.SelectedIndexChanged += new System.EventHandler(this.cmb_Course_SelectedIndexChanged);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_Roll_No.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(267, 152);
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(217, 26);
            this.tb_Roll_No.TabIndex = 2;
            // 
            // dgv_Student_Details
            // 
            this.dgv_Student_Details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Student_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Student_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Student_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_Details.Location = new System.Drawing.Point(12, 201);
            this.dgv_Student_Details.Name = "dgv_Student_Details";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Student_Details.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Student_Details.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Student_Details.Size = new System.Drawing.Size(892, 275);
            this.dgv_Student_Details.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Search.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(574, 143);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(117, 40);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh_Grid
            // 
            this.btn_Refresh_Grid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Refresh_Grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Refresh_Grid.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh_Grid.Location = new System.Drawing.Point(720, 143);
            this.btn_Refresh_Grid.Name = "btn_Refresh_Grid";
            this.btn_Refresh_Grid.Size = new System.Drawing.Size(147, 40);
            this.btn_Refresh_Grid.TabIndex = 4;
            this.btn_Refresh_Grid.Text = "Refresh Grid";
            this.btn_Refresh_Grid.UseVisualStyleBackColor = false;
            this.btn_Refresh_Grid.Click += new System.EventHandler(this.btn_Refresh_Grid_Click);
            // 
            // Frm_Student_Details_By_Course_Dynamic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 488);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh_Grid);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgv_Student_Details);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Dynamic);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Frm_Student_Details_By_Course_Dynamic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Details By Course Dynamically";
            this.Load += new System.EventHandler(this.Frm_Student_Details_By_Course_Dynamic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Dynamic;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.DataGridView dgv_Student_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh_Grid;
    }
}