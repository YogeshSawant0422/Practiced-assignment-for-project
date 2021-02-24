namespace Book_Managment
{
    partial class dgv_all_book_details
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_all_book_details = new System.Windows.Forms.Label();
            this.btn_add_new_book = new System.Windows.Forms.Button();
            this.btn_log_out2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.book_Managment_DBDataSet1 = new Book_Managment.Book_Managment_DBDataSet1();
            this.book_Managment_DBDataSet = new Book_Managment.Book_Managment_DBDataSet();
            this.bookDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.book_DetailsTableAdapter1 = new Book_Managment.Book_Managment_DBDataSetTableAdapters.Book_DetailsTableAdapter();
            this.bookDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Book_Managment.DataSet1();
            this.book_DetailsTableAdapter = new Book_Managment.DataSet1TableAdapters.Book_DetailsTableAdapter();
            this.book_DetailsTableAdapter2 = new Book_Managment.Book_Managment_DBDataSet1TableAdapters.Book_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_Managment_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_Managment_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_all_book_details
            // 
            this.lbl_all_book_details.BackColor = System.Drawing.Color.LightSalmon;
            this.lbl_all_book_details.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_all_book_details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_all_book_details.Location = new System.Drawing.Point(347, 9);
            this.lbl_all_book_details.Name = "lbl_all_book_details";
            this.lbl_all_book_details.Size = new System.Drawing.Size(203, 48);
            this.lbl_all_book_details.TabIndex = 0;
            this.lbl_all_book_details.Text = "View All Book\r\n";
            this.lbl_all_book_details.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btn_add_new_book
            // 
            this.btn_add_new_book.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_new_book.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_add_new_book.Location = new System.Drawing.Point(398, 289);
            this.btn_add_new_book.Name = "btn_add_new_book";
            this.btn_add_new_book.Size = new System.Drawing.Size(204, 42);
            this.btn_add_new_book.TabIndex = 2;
            this.btn_add_new_book.Text = "Add New Book";
            this.btn_add_new_book.UseVisualStyleBackColor = true;
            this.btn_add_new_book.Click += new System.EventHandler(this.btn_add_new_book_Click);
            // 
            // btn_log_out2
            // 
            this.btn_log_out2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out2.Location = new System.Drawing.Point(874, 12);
            this.btn_log_out2.Name = "btn_log_out2";
            this.btn_log_out2.Size = new System.Drawing.Size(94, 35);
            this.btn_log_out2.TabIndex = 2;
            this.btn_log_out2.Text = "Log out";
            this.btn_log_out2.UseVisualStyleBackColor = true;
            this.btn_log_out2.Click += new System.EventHandler(this.btn_log_out2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.publicationDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookDetailsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(970, 200);
            this.dataGridView1.TabIndex = 3;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publicationDataGridViewTextBoxColumn
            // 
            this.publicationDataGridViewTextBoxColumn.DataPropertyName = "Publication";
            this.publicationDataGridViewTextBoxColumn.HeaderText = "Publication";
            this.publicationDataGridViewTextBoxColumn.Name = "publicationDataGridViewTextBoxColumn";
            this.publicationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookDetailsBindingSource2
            // 
            this.bookDetailsBindingSource2.DataMember = "Book_Details";
            this.bookDetailsBindingSource2.DataSource = this.book_Managment_DBDataSet1;
            // 
            // book_Managment_DBDataSet1
            // 
            this.book_Managment_DBDataSet1.DataSetName = "Book_Managment_DBDataSet1";
            this.book_Managment_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book_Managment_DBDataSet
            // 
            this.book_Managment_DBDataSet.DataSetName = "Book_Managment_DBDataSet";
            this.book_Managment_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookDetailsBindingSource1
            // 
            this.bookDetailsBindingSource1.DataMember = "Book_Details";
            this.bookDetailsBindingSource1.DataSource = this.book_Managment_DBDataSet;
            // 
            // book_DetailsTableAdapter1
            // 
            this.book_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // bookDetailsBindingSource
            // 
            this.bookDetailsBindingSource.DataMember = "Book_Details";
            this.bookDetailsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book_DetailsTableAdapter
            // 
            this.book_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // book_DetailsTableAdapter2
            // 
            this.book_DetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // dgv_all_book_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 407);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_log_out2);
            this.Controls.Add(this.btn_add_new_book);
            this.Controls.Add(this.lbl_all_book_details);
            this.Name = "dgv_all_book_details";
            this.Text = "All Books";
            this.Load += new System.EventHandler(this.dgv_all_book_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_Managment_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_Managment_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_all_book_details;
        private System.Windows.Forms.Button btn_add_new_book;
        private System.Windows.Forms.Button btn_log_out2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bookDetailsBindingSource;
        private DataSet1TableAdapters.Book_DetailsTableAdapter book_DetailsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Book_Managment_DBDataSet book_Managment_DBDataSet;
        private System.Windows.Forms.BindingSource bookDetailsBindingSource1;
        private Book_Managment_DBDataSetTableAdapters.Book_DetailsTableAdapter book_DetailsTableAdapter1;
        private Book_Managment_DBDataSet1 book_Managment_DBDataSet1;
        private System.Windows.Forms.BindingSource bookDetailsBindingSource2;
        private Book_Managment_DBDataSet1TableAdapters.Book_DetailsTableAdapter book_DetailsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}