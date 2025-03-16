namespace lab6
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
            btnFetchBooks = new Button();
            ListBoxBooks = new ListBox();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            label1 = new Label();
            label2 = new Label();
            btnUpdateBook = new Button();
            btnDeleteBook = new Button();
            btnSearchBook = new Button();
            txtBookID = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFetchBooks.Location = new Point(115, 196);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(125, 29);
            btnFetchBooks.TabIndex = 0;
            btnFetchBooks.Text = "Fetch Book";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // ListBoxBooks
            // 
            ListBoxBooks.FormattingEnabled = true;
            ListBoxBooks.Location = new Point(256, 48);
            ListBoxBooks.Name = "ListBoxBooks";
            ListBoxBooks.Size = new Size(521, 364);
            ListBoxBooks.TabIndex = 1;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(115, 48);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(125, 27);
            txtAuthorName.TabIndex = 2;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(115, 100);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(125, 27);
            txtBookTitle.TabIndex = 3;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBook.Location = new Point(115, 244);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(125, 29);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 48);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 5;
            label1.Text = "Author:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 100);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 6;
            label2.Text = "Book:";
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateBook.Location = new Point(115, 291);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(125, 29);
            btnUpdateBook.TabIndex = 7;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteBook.Location = new Point(115, 338);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(125, 29);
            btnDeleteBook.TabIndex = 8;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchBook.Location = new Point(115, 383);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(125, 29);
            btnSearchBook.TabIndex = 9;
            btnSearchBook.Text = "Search Book";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(115, 148);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(125, 27);
            txtBookID.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 158);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 11;
            label3.Text = "Book ID:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtBookID);
            Controls.Add(btnSearchBook);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnUpdateBook);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddBook);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(ListBoxBooks);
            Controls.Add(btnFetchBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFetchBooks;
        private ListBox ListBoxBooks;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnAddBook;
        private Label label1;
        private Label label2;
        private Button btnUpdateBook;
        private Button btnDeleteBook;
        private Button btnSearchBook;
        private TextBox txtBookID;
        private Label label3;
    }
}
