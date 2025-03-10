namespace lab5
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            listBoxBooks = new ListBox();
            Add = new Button();
            btnShowBooks = new Button();
            btnUpdateBook = new Button();
            txtBookID = new TextBox();
            btnDeleteBook = new Button();
            btnSearchBook = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(136, 37);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(125, 27);
            txtAuthorName.TabIndex = 0;
            txtAuthorName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(136, 73);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(125, 27);
            txtBookTitle.TabIndex = 1;
            txtBookTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(278, 37);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(499, 324);
            listBoxBooks.TabIndex = 2;
            listBoxBooks.SelectedIndexChanged += listBoxBooks_SelectedIndexChanged;
            // 
            // Add
            // 
            Add.Location = new Point(136, 150);
            Add.Name = "Add";
            Add.Size = new Size(125, 29);
            Add.TabIndex = 3;
            Add.Text = "ADD BOOK";
            Add.UseVisualStyleBackColor = true;
            Add.Click += btnAddBook_Click;
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(136, 194);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(125, 29);
            btnShowBooks.TabIndex = 5;
            btnShowBooks.Text = "SHOW BOOK";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(136, 241);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(125, 29);
            btnUpdateBook.TabIndex = 6;
            btnUpdateBook.Text = "UPDATE BOOK";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(136, 106);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(125, 27);
            txtBookID.TabIndex = 7;
            txtBookID.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(136, 288);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(125, 29);
            btnDeleteBook.TabIndex = 8;
            btnDeleteBook.Text = "DELETE BOOK";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Location = new Point(136, 332);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(125, 29);
            btnSearchBook.TabIndex = 9;
            btnSearchBook.Text = "SEARCH BOOK";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 37);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 11;
            label2.Text = "Book Author:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 80);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 12;
            label3.Text = "Book Title:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 117);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 13;
            label4.Text = "Book ID:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSearchBook);
            Controls.Add(btnDeleteBook);
            Controls.Add(txtBookID);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnShowBooks);
            Controls.Add(Add);
            Controls.Add(listBoxBooks);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private ListBox listBoxBooks;
        private Button Add;
        private Button btnShowBooks;
        private Button btnUpdateBook;
        private TextBox txtBookID;
        private Button btnDeleteBook;
        private Button btnSearchBook;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
