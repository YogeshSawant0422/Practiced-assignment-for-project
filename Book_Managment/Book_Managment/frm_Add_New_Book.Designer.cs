namespace Book_Managment
{
    partial class frm_Add_New_Book
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
            this.lbl_Add_book = new System.Windows.Forms.Label();
            this.lbl_Book_ID = new System.Windows.Forms.Label();
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            this.lbl_Book_Price = new System.Windows.Forms.Label();
            this.lbl_Publication = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.tb_BooK_ID = new System.Windows.Forms.TextBox();
            this.tb_Book_Name = new System.Windows.Forms.TextBox();
            this.tb_Publication = new System.Windows.Forms.TextBox();
            this.tb_Book_Price = new System.Windows.Forms.TextBox();
            this.btn_view_all_book = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Add_book
            // 
            this.lbl_Add_book.BackColor = System.Drawing.Color.Red;
            this.lbl_Add_book.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_book.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_Add_book.Location = new System.Drawing.Point(225, 2);
            this.lbl_Add_book.Name = "lbl_Add_book";
            this.lbl_Add_book.Size = new System.Drawing.Size(197, 36);
            this.lbl_Add_book.TabIndex = 0;
            this.lbl_Add_book.Text = "Add Book";
            this.lbl_Add_book.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Book_ID
            // 
            this.lbl_Book_ID.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Book_ID.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Book_ID.Location = new System.Drawing.Point(141, 58);
            this.lbl_Book_ID.Name = "lbl_Book_ID";
            this.lbl_Book_ID.Size = new System.Drawing.Size(121, 39);
            this.lbl_Book_ID.TabIndex = 0;
            this.lbl_Book_ID.Text = "Book ID";
            this.lbl_Book_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Book_Name.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Book_Name.Location = new System.Drawing.Point(141, 110);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.Size = new System.Drawing.Size(121, 41);
            this.lbl_Book_Name.TabIndex = 0;
            this.lbl_Book_Name.Text = "Book Name";
            this.lbl_Book_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Book_Price
            // 
            this.lbl_Book_Price.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Book_Price.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Book_Price.Location = new System.Drawing.Point(142, 239);
            this.lbl_Book_Price.Name = "lbl_Book_Price";
            this.lbl_Book_Price.Size = new System.Drawing.Size(120, 43);
            this.lbl_Book_Price.TabIndex = 0;
            this.lbl_Book_Price.Text = "Book Price";
            this.lbl_Book_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Publication
            // 
            this.lbl_Publication.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Publication.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Publication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Publication.Location = new System.Drawing.Point(142, 169);
            this.lbl_Publication.Name = "lbl_Publication";
            this.lbl_Publication.Size = new System.Drawing.Size(125, 48);
            this.lbl_Publication.TabIndex = 0;
            this.lbl_Publication.Text = "Publication";
            this.lbl_Publication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Save.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Save.Location = new System.Drawing.Point(185, 293);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(119, 42);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.SystemColors.Control;
            this.btn_log_out.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_log_out.Location = new System.Drawing.Point(542, 15);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(117, 36);
            this.btn_log_out.TabIndex = 7;
            this.btn_log_out.Text = "Log out";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // tb_BooK_ID
            // 
            this.tb_BooK_ID.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BooK_ID.Location = new System.Drawing.Point(333, 58);
            this.tb_BooK_ID.MaxLength = 8;
            this.tb_BooK_ID.Name = "tb_BooK_ID";
            this.tb_BooK_ID.Size = new System.Drawing.Size(174, 23);
            this.tb_BooK_ID.TabIndex = 1;
            this.tb_BooK_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Book_Name
            // 
            this.tb_Book_Name.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Name.Location = new System.Drawing.Point(333, 124);
            this.tb_Book_Name.MaxLength = 20;
            this.tb_Book_Name.Name = "tb_Book_Name";
            this.tb_Book_Name.Size = new System.Drawing.Size(174, 23);
            this.tb_Book_Name.TabIndex = 2;
            this.tb_Book_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Publication
            // 
            this.tb_Publication.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Publication.Location = new System.Drawing.Point(333, 187);
            this.tb_Publication.MaxLength = 20;
            this.tb_Publication.Name = "tb_Publication";
            this.tb_Publication.Size = new System.Drawing.Size(174, 23);
            this.tb_Publication.TabIndex = 3;
            this.tb_Publication.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alpha_Numeric);
            // 
            // tb_Book_Price
            // 
            this.tb_Book_Price.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Price.Location = new System.Drawing.Point(333, 254);
            this.tb_Book_Price.MaxLength = 5;
            this.tb_Book_Price.Name = "tb_Book_Price";
            this.tb_Book_Price.Size = new System.Drawing.Size(174, 23);
            this.tb_Book_Price.TabIndex = 4;
            this.tb_Book_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Price);
            // 
            // btn_view_all_book
            // 
            this.btn_view_all_book.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_view_all_book.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_all_book.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_view_all_book.Location = new System.Drawing.Point(359, 295);
            this.btn_view_all_book.Name = "btn_view_all_book";
            this.btn_view_all_book.Size = new System.Drawing.Size(248, 39);
            this.btn_view_all_book.TabIndex = 6;
            this.btn_view_all_book.Text = "View All Book";
            this.btn_view_all_book.UseVisualStyleBackColor = false;
            this.btn_view_all_book.Click += new System.EventHandler(this.btn_view_all_book_Click);
            // 
            // frm_Add_New_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(688, 344);
            this.Controls.Add(this.btn_view_all_book);
            this.Controls.Add(this.tb_Book_Price);
            this.Controls.Add(this.tb_Publication);
            this.Controls.Add(this.tb_Book_Name);
            this.Controls.Add(this.tb_BooK_ID);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Publication);
            this.Controls.Add(this.lbl_Book_Price);
            this.Controls.Add(this.lbl_Book_Name);
            this.Controls.Add(this.lbl_Book_ID);
            this.Controls.Add(this.lbl_Add_book);
            this.Name = "frm_Add_New_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.frm_Add_New_Book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_book;
        private System.Windows.Forms.Label lbl_Book_ID;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.Label lbl_Book_Price;
        private System.Windows.Forms.Label lbl_Publication;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.TextBox tb_BooK_ID;
        private System.Windows.Forms.TextBox tb_Book_Name;
        private System.Windows.Forms.TextBox tb_Publication;
        private System.Windows.Forms.TextBox tb_Book_Price;
        private System.Windows.Forms.Button btn_view_all_book;
    }
}