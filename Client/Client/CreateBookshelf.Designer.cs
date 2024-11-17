namespace Client
{
    partial class CreateBookshelf
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
            label1 = new Label();
            lbName = new Label();
            lbDescription = new Label();
            btnCreate = new Button();
            tb_BookShelfName = new TextBox();
            tb_Description = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(38, 36);
            lbName.Margin = new Padding(2, 0, 2, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(118, 20);
            lbName.TabIndex = 2;
            lbName.Text = "Bookshelf Name";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(38, 88);
            lbDescription.Margin = new Padding(2, 0, 2, 0);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(85, 20);
            lbDescription.TabIndex = 3;
            lbDescription.Text = "Description";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(296, 241);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(92, 29);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click_1;
            // 
            // tb_BookShelfName
            // 
            tb_BookShelfName.Location = new Point(201, 33);
            tb_BookShelfName.Name = "tb_BookShelfName";
            tb_BookShelfName.Size = new Size(285, 27);
            tb_BookShelfName.TabIndex = 5;
            tb_BookShelfName.TextChanged += tb_BookShelfName_TextChanged;
            // 
            // tb_Description
            // 
            tb_Description.Location = new Point(201, 97);
            tb_Description.Multiline = true;
            tb_Description.Name = "tb_Description";
            tb_Description.Size = new Size(285, 139);
            tb_Description.TabIndex = 6;
            tb_Description.TextChanged += tb_Description_TextChanged;
            // 
            // CreateBookshelf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 281);
            Controls.Add(tb_Description);
            Controls.Add(tb_BookShelfName);
            Controls.Add(btnCreate);
            Controls.Add(lbDescription);
            Controls.Add(lbName);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "CreateBookshelf";
            Text = "CreateBookshelf";
            Load += CreateBookshelf_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbName;
        private Label lbDescription;
        private Button btnCreate;
        private TextBox tb_BookShelfName;
        private TextBox tb_Description;
    }
}