namespace Client
{
    partial class BookSearch
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
            textBox1 = new TextBox();
            btnSearch = new Button();
            dgvBooks = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            ReleaseDate = new DataGridViewTextBoxColumn();
            BookCode = new DataGridViewTextBoxColumn();
            pgbBookSearch = new ProgressBar();
            btnCreateBookshelf = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(704, 39);
            textBox1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(816, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { Title, Author, ReleaseDate, BookCode });
            dgvBooks.Location = new Point(82, 174);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 82;
            dgvBooks.Size = new Size(884, 529);
            dgvBooks.TabIndex = 2;
            dgvBooks.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 10;
            Title.Name = "Title";
            Title.Width = 200;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.MinimumWidth = 10;
            Author.Name = "Author";
            Author.Width = 200;
            // 
            // ReleaseDate
            // 
            ReleaseDate.HeaderText = "Release Date";
            ReleaseDate.MinimumWidth = 10;
            ReleaseDate.Name = "ReleaseDate";
            ReleaseDate.Width = 200;
            // 
            // BookCode
            // 
            BookCode.HeaderText = "Book Code";
            BookCode.MinimumWidth = 10;
            BookCode.Name = "BookCode";
            BookCode.Width = 200;
            // 
            // pgbBookSearch
            // 
            pgbBookSearch.Location = new Point(82, 742);
            pgbBookSearch.Name = "pgbBookSearch";
            pgbBookSearch.Size = new Size(884, 46);
            pgbBookSearch.TabIndex = 3;
            // 
            // btnCreateBookshelf
            // 
            btnCreateBookshelf.Location = new Point(681, 108);
            btnCreateBookshelf.Name = "btnCreateBookshelf";
            btnCreateBookshelf.Size = new Size(285, 46);
            btnCreateBookshelf.TabIndex = 4;
            btnCreateBookshelf.Text = "Create new bookshelf";
            btnCreateBookshelf.UseVisualStyleBackColor = true;
            // 
            // BookSearch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 823);
            Controls.Add(btnCreateBookshelf);
            Controls.Add(pgbBookSearch);
            Controls.Add(dgvBooks);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Name = "BookSearch";
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnSearch;
        private DataGridView dgvBooks;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn ReleaseDate;
        private DataGridViewTextBoxColumn BookCode;
        private ProgressBar pgbBookSearch;
        private Button btnCreateBookshelf;
    }
}