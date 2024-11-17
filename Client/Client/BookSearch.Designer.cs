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
            txtSearch.Location = new Point(81, 48);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(704, 39);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(816, 45);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(81, 174);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 82;
            dgvBooks.Size = new Size(884, 530);
            dgvBooks.TabIndex = 2;
            dgvBooks.CellContentClick += DataGridView1_CellContentClick;
            // 
            // pgbBookSearch
            // 
            pgbBookSearch.Location = new Point(81, 742);
            pgbBookSearch.Name = "pgbBookSearch";
            pgbBookSearch.Size = new Size(884, 46);
            pgbBookSearch.TabIndex = 3;
            // 
            // btnCreateBookshelf
            // 
            btnCreateBookshelf.Location = new Point(681, 109);
            btnCreateBookshelf.Name = "btnCreateBookshelf";
            btnCreateBookshelf.Size = new Size(284, 46);
            btnCreateBookshelf.TabIndex = 4;
            btnCreateBookshelf.Text = "Create new bookshelf";
            btnCreateBookshelf.UseVisualStyleBackColor = true;
            btnCreateBookshelf.Click += btnCreateBookshelf_Click;
            // 
            // BookSearch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 822);
            Controls.Add(btnCreateBookshelf);
            Controls.Add(pgbBookSearch);
            Controls.Add(dgvBooks);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "BookSearch";
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