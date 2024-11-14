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
            rtbBookDetails.Location = new Point(77, 59);
            rtbBookDetails.Name = "rtbBookDetails";
            rtbBookDetails.Size = new Size(841, 448);
            rtbBookDetails.TabIndex = 0;
            rtbBookDetails.Text = "";
            // 
            // btnAddToShelf
            // 
            btnAddToShelf.Location = new Point(189, 536);
            btnAddToShelf.Name = "btnAddToShelf";
            btnAddToShelf.Size = new Size(221, 46);
            btnAddToShelf.TabIndex = 1;
            btnAddToShelf.Text = "Add to shelf";
            btnAddToShelf.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromShelf
            // 
            btnRemoveFromShelf.Location = new Point(565, 536);
            btnRemoveFromShelf.Name = "btnRemoveFromShelf";
            btnRemoveFromShelf.Size = new Size(246, 46);
            btnRemoveFromShelf.TabIndex = 2;
            btnRemoveFromShelf.Text = "Remove from shelf";
            btnRemoveFromShelf.UseVisualStyleBackColor = true;
            // 
            // pgbBookDetails
            // 
            pgbBookDetails.Location = new Point(77, 633);
            pgbBookDetails.Name = "pgbBookDetails";
            pgbBookDetails.Size = new Size(841, 46);
            pgbBookDetails.TabIndex = 3;
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 704);
            Controls.Add(pgbBookDetails);
            Controls.Add(btnRemoveFromShelf);
            Controls.Add(btnAddToShelf);
            Controls.Add(rtbBookDetails);
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