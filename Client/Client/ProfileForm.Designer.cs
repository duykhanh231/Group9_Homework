namespace Client
{
    partial class ProfileForm
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
            linkLabel1 = new LinkLabel();
            lbUsername = new Label();
            lbEmail = new Label();
            lbName = new Label();
            lbBirth = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbUsername = new TextBox();
            tbEmail = new TextBox();
            tbName = new TextBox();
            tbBirth = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 44);
            label1.Name = "label1";
            label1.Size = new Size(260, 59);
            label1.TabIndex = 0;
            label1.Text = "Your profile";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(410, 203);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 32);
            linkLabel1.TabIndex = 1;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(133, 144);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(121, 32);
            lbUsername.TabIndex = 2;
            lbUsername.Text = "Username";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(133, 214);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(71, 32);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(133, 282);
            lbName.Name = "lbName";
            lbName.Size = new Size(78, 32);
            lbName.TabIndex = 4;
            lbName.Text = "Name";
            // 
            // lbBirth
            // 
            lbBirth.AutoSize = true;
            lbBirth.Location = new Point(133, 353);
            lbBirth.Name = "lbBirth";
            lbBirth.Size = new Size(102, 32);
            lbBirth.TabIndex = 5;
            lbBirth.Text = "Birthday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(436, 144);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(436, 214);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 282);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 353);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 9;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(360, 141);
            tbUsername.Name = "tbUsername";
            tbUsername.ReadOnly = true;
            tbUsername.Size = new Size(276, 39);
            tbUsername.TabIndex = 10;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(360, 211);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(276, 39);
            tbEmail.TabIndex = 11;
            // 
            // tbName
            // 
            tbName.Location = new Point(360, 279);
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(276, 39);
            tbName.TabIndex = 12;
            // 
            // tbBirth
            // 
            tbBirth.Location = new Point(360, 350);
            tbBirth.Name = "tbBirth";
            tbBirth.ReadOnly = true;
            tbBirth.Size = new Size(276, 39);
            tbBirth.TabIndex = 13;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbBirth);
            Controls.Add(tbName);
            Controls.Add(tbEmail);
            Controls.Add(tbUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbBirth);
            Controls.Add(lbName);
            Controls.Add(lbEmail);
            Controls.Add(lbUsername);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Name = "ProfileForm";
            Text = "ProfileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private Label lbUsername;
        private Label lbEmail;
        private Label lbName;
        private Label lbBirth;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbUsername;
        private TextBox tbEmail;
        private TextBox tbName;
        private TextBox tbBirth;
    }
}