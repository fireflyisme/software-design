namespace lab7
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
            lblPageNumber = new Label();
            btnNextPage = new Button();
            btnPreviousPage = new Button();
            listBoxBooks = new ListBox();
            btnAddBook = new Button();
            label1 = new Label();
            label2 = new Label();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            btnExportBooks = new Button();
            btnSearchBook = new Button();
            btnImportBooks = new Button();
            SuspendLayout();
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageNumber.Location = new Point(12, 9);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(45, 17);
            lblPageNumber.TabIndex = 0;
            lblPageNumber.Text = "Page:";
            // 
            // btnNextPage
            // 
            btnNextPage.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextPage.Location = new Point(223, 392);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(94, 29);
            btnNextPage.TabIndex = 1;
            btnNextPage.Text = "NEXT";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPreviousPage.Location = new Point(12, 392);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(94, 29);
            btnPreviousPage.TabIndex = 2;
            btnPreviousPage.Text = "PREVIOUS";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(336, 57);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(436, 364);
            listBoxBooks.TabIndex = 3;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddBook.Location = new Point(115, 182);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(145, 33);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "ADD BOOK";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 57);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 5;
            label1.Text = "Author:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 121);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 6;
            label2.Text = "Book Title:";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(115, 52);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(145, 27);
            txtAuthorName.TabIndex = 7;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(115, 116);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(145, 27);
            txtBookTitle.TabIndex = 8;
            // 
            // btnExportBooks
            // 
            btnExportBooks.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportBooks.Location = new Point(115, 292);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(145, 29);
            btnExportBooks.TabIndex = 9;
            btnExportBooks.Text = "EXPORT BOOK";
            btnExportBooks.UseVisualStyleBackColor = true;
            btnExportBooks.Click += btnExportBooks_Click;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchBook.Location = new Point(115, 238);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(145, 29);
            btnSearchBook.TabIndex = 10;
            btnSearchBook.Text = "SEARCH BOOK";
            btnSearchBook.UseVisualStyleBackColor = true;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // btnImportBooks
            // 
            btnImportBooks.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImportBooks.Location = new Point(115, 343);
            btnImportBooks.Name = "btnImportBooks";
            btnImportBooks.Size = new Size(145, 29);
            btnImportBooks.TabIndex = 11;
            btnImportBooks.Text = "IMPORT BOOK";
            btnImportBooks.UseVisualStyleBackColor = true;
            btnImportBooks.Click += btnImportBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImportBooks);
            Controls.Add(btnSearchBook);
            Controls.Add(btnExportBooks);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddBook);
            Controls.Add(listBoxBooks);
            Controls.Add(btnPreviousPage);
            Controls.Add(btnNextPage);
            Controls.Add(lblPageNumber);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageNumber;
        private Button btnNextPage;
        private Button btnPreviousPage;
        private ListBox listBoxBooks;
        private Button btnAddBook;
        private Label label1;
        private Label label2;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button btnExportBooks;
        private Button btnSearchBook;
        private Button btnImportBooks;
    }
}
