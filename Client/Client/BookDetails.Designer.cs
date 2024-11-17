namespace Client
{
    partial class BookDetails
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
            rtbBookDetails = new RichTextBox();
            btnAddToShelf = new Button();
            btnRemoveFromShelf = new Button();
            pgbBookDetails = new ProgressBar();
            SuspendLayout();
            // 
            // rtbBookDetails
            // 
            rtbBookDetails.Location = new Point(47, 37);
            rtbBookDetails.Margin = new Padding(2);
            rtbBookDetails.Name = "rtbBookDetails";
            rtbBookDetails.Size = new Size(519, 282);
            rtbBookDetails.TabIndex = 0;
            rtbBookDetails.Text = "";
            // 
            // btnAddToShelf
            // 
            btnAddToShelf.Location = new Point(116, 335);
            btnAddToShelf.Margin = new Padding(2);
            btnAddToShelf.Name = "btnAddToShelf";
            btnAddToShelf.Size = new Size(136, 29);
            btnAddToShelf.TabIndex = 1;
            btnAddToShelf.Text = "Add to shelf";
            btnAddToShelf.UseVisualStyleBackColor = true;
            btnAddToShelf.Click += btnAddToShelf_Click;
            // 
            // btnRemoveFromShelf
            // 
            btnRemoveFromShelf.Location = new Point(348, 335);
            btnRemoveFromShelf.Margin = new Padding(2);
            btnRemoveFromShelf.Name = "btnRemoveFromShelf";
            btnRemoveFromShelf.Size = new Size(151, 29);
            btnRemoveFromShelf.TabIndex = 2;
            btnRemoveFromShelf.Text = "Remove from shelf";
            btnRemoveFromShelf.UseVisualStyleBackColor = true;
            btnRemoveFromShelf.Click += btnRemoveFromShelf_Click;
            // 
            // pgbBookDetails
            // 
            pgbBookDetails.Location = new Point(47, 396);
            pgbBookDetails.Margin = new Padding(2);
            pgbBookDetails.Name = "pgbBookDetails";
            pgbBookDetails.Size = new Size(518, 29);
            pgbBookDetails.TabIndex = 3;
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 440);
            Controls.Add(pgbBookDetails);
            Controls.Add(btnRemoveFromShelf);
            Controls.Add(btnAddToShelf);
            Controls.Add(rtbBookDetails);
            Margin = new Padding(2);
            Name = "BookDetails";
            Text = "BookDetail";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbBookDetails;
        private Button btnAddToShelf;
        private Button btnRemoveFromShelf;
        private ProgressBar pgbBookDetails;
    }
}