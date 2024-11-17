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
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvBooks = new DataGridView();
            pgbBookSearch = new ProgressBar();
            btnCreateBookshelf = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(50, 30);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(435, 27);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(502, 28);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(50, 109);
            dgvBooks.Margin = new Padding(2, 2, 2, 2);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 82;
            dgvBooks.Size = new Size(544, 331);
            dgvBooks.TabIndex = 2;
            dgvBooks.CellContentClick += DataGridView1_CellContentClick;
            // 
            // pgbBookSearch
            // 
            pgbBookSearch.Location = new Point(50, 464);
            pgbBookSearch.Margin = new Padding(2, 2, 2, 2);
            pgbBookSearch.Name = "pgbBookSearch";
            pgbBookSearch.Size = new Size(544, 29);
            pgbBookSearch.TabIndex = 3;
            // 
            // btnCreateBookshelf
            // 
            btnCreateBookshelf.Location = new Point(419, 68);
            btnCreateBookshelf.Margin = new Padding(2, 2, 2, 2);
            btnCreateBookshelf.Name = "btnCreateBookshelf";
            btnCreateBookshelf.Size = new Size(175, 29);
            btnCreateBookshelf.TabIndex = 4;
            btnCreateBookshelf.Text = "Create new bookshelf";
            btnCreateBookshelf.UseVisualStyleBackColor = true;
            btnCreateBookshelf.Click += btnCreateBookshelf_Click;
            // 
            // BookSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 514);
            Controls.Add(btnCreateBookshelf);
            Controls.Add(pgbBookSearch);
            Controls.Add(dgvBooks);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Margin = new Padding(2, 2, 2, 2);
            Name = "BookSearch";
            Load += BookSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvBooks;
        private ProgressBar pgbBookSearch;
        private Button btnCreateBookshelf;
    }
}