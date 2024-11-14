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
            textBox1 = new TextBox();
            lbName = new Label();
            lbDescription = new Label();
            btnCreate = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 58);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(278, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(436, 39);
            textBox1.TabIndex = 1;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(62, 58);
            lbName.Name = "lbName";
            lbName.Size = new Size(190, 32);
            lbName.TabIndex = 2;
            lbName.Text = "Bookshelf Name";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(62, 140);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(135, 32);
            lbDescription.TabIndex = 3;
            lbDescription.Text = "Description";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(327, 371);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 46);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(278, 140);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(436, 197);
            textBox2.TabIndex = 5;
            // 
            // CreateBookshelf
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 450);
            Controls.Add(textBox2);
            Controls.Add(btnCreate);
            Controls.Add(lbDescription);
            Controls.Add(lbName);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CreateBookshelf";
            Text = "CreateBookshelf";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label lbName;
        private Label lbDescription;
        private Button btnCreate;
        private TextBox textBox2;
    }
}