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
            pnlProfile = new Panel();
            btnChangePassword = new Button();
            pnlProfile.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(336, 27);
            label1.Name = "label1";
            label1.Size = new Size(292, 65);
            label1.TabIndex = 0;
            label1.Text = "Your profile";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(503, 250);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 32);
            linkLabel1.TabIndex = 1;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(226, 182);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(163, 45);
            lbUsername.TabIndex = 2;
            lbUsername.Text = "Username";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(226, 261);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(96, 45);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.Location = new Point(226, 339);
            lbName.Name = "lbName";
            lbName.Size = new Size(105, 45);
            lbName.TabIndex = 4;
            lbName.Text = "Name";
            // 
            // lbBirth
            // 
            lbBirth.AutoSize = true;
            lbBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbBirth.Location = new Point(226, 414);
            lbBirth.Name = "lbBirth";
            lbBirth.Size = new Size(136, 45);
            lbBirth.TabIndex = 5;
            lbBirth.Text = "Birthday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(529, 191);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(529, 261);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(529, 329);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(529, 400);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 9;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.White;
            tbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(453, 179);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.ReadOnly = true;
            tbUsername.Size = new Size(276, 48);
            tbUsername.TabIndex = 10;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.White;
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(453, 258);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(276, 48);
            tbEmail.TabIndex = 11;
            // 
            // tbName
            // 
            tbName.BackColor = Color.White;
            tbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.Location = new Point(453, 336);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(276, 48);
            tbName.TabIndex = 12;
            // 
            // tbBirth
            // 
            tbBirth.BackColor = Color.White;
            tbBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbBirth.Location = new Point(453, 411);
            tbBirth.Multiline = true;
            tbBirth.Name = "tbBirth";
            tbBirth.ReadOnly = true;
            tbBirth.Size = new Size(276, 48);
            tbBirth.TabIndex = 13;
            tbBirth.TextChanged += tbBirth_TextChanged;
            // 
            // pnlProfile
            // 
            pnlProfile.BackColor = Color.Black;
            pnlProfile.Controls.Add(label1);
            pnlProfile.Location = new Point(2, 1);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(965, 116);
            pnlProfile.TabIndex = 14;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.IndianRed;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(327, 528);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(319, 60);
            btnChangePassword.TabIndex = 15;
            btnChangePassword.Text = "Change password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(968, 635);
            Controls.Add(btnChangePassword);
            Controls.Add(pnlProfile);
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
            Name = "ProfileForm";
            Text = "ProfileForm";
            pnlProfile.ResumeLayout(false);
            pnlProfile.PerformLayout();
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
        private Panel pnlProfile;
        private Button btnChangePassword;
    }
}