namespace Client
{
    partial class SignupForm
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
            lbSignup = new Label();
            lbUsername = new Label();
            lbPass = new Label();
            lbCfmPass = new Label();
            lbEmail = new Label();
            lbName = new Label();
            lbBirth = new Label();
            tbUsername = new TextBox();
            tbPass = new TextBox();
            tbCfmPass = new TextBox();
            tbEmail = new TextBox();
            tbName = new TextBox();
            dtpBirth = new DateTimePicker();
            btnReg = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lbSignup
            // 
            lbSignup.AutoSize = true;
            lbSignup.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSignup.Location = new Point(147, 29);
            lbSignup.Margin = new Padding(2, 0, 2, 0);
            lbSignup.Name = "lbSignup";
            lbSignup.Size = new Size(291, 37);
            lbSignup.TabIndex = 0;
            lbSignup.Text = "Create a new account";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(81, 90);
            lbUsername.Margin = new Padding(2, 0, 2, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 20);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(81, 131);
            lbPass.Margin = new Padding(2, 0, 2, 0);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(70, 20);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password";
            // 
            // lbCfmPass
            // 
            lbCfmPass.AutoSize = true;
            lbCfmPass.Location = new Point(81, 170);
            lbCfmPass.Margin = new Padding(2, 0, 2, 0);
            lbCfmPass.Name = "lbCfmPass";
            lbCfmPass.Size = new Size(127, 20);
            lbCfmPass.TabIndex = 3;
            lbCfmPass.Text = "Confirm Password";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(81, 209);
            lbEmail.Margin = new Padding(2, 0, 2, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "Email";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(81, 248);
            lbName.Margin = new Padding(2, 0, 2, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 5;
            lbName.Text = "Name";
            // 
            // lbBirth
            // 
            lbBirth.AutoSize = true;
            lbBirth.Location = new Point(81, 284);
            lbBirth.Margin = new Padding(2, 0, 2, 0);
            lbBirth.Name = "lbBirth";
            lbBirth.Size = new Size(64, 20);
            lbBirth.TabIndex = 6;
            lbBirth.Text = "Birthday";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(257, 89);
            tbUsername.Margin = new Padding(2, 2, 2, 2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(248, 27);
            tbUsername.TabIndex = 7;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(257, 129);
            tbPass.Margin = new Padding(2, 2, 2, 2);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(248, 27);
            tbPass.TabIndex = 8;
            // 
            // tbCfmPass
            // 
            tbCfmPass.Location = new Point(257, 168);
            tbCfmPass.Margin = new Padding(2, 2, 2, 2);
            tbCfmPass.Name = "tbCfmPass";
            tbCfmPass.PasswordChar = '*';
            tbCfmPass.Size = new Size(248, 27);
            tbCfmPass.TabIndex = 9;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(257, 207);
            tbEmail.Margin = new Padding(2, 2, 2, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(248, 27);
            tbEmail.TabIndex = 10;
            // 
            // tbName
            // 
            tbName.Location = new Point(257, 246);
            tbName.Margin = new Padding(2, 2, 2, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(248, 27);
            tbName.TabIndex = 11;
            // 
            // dtpBirth
            // 
            dtpBirth.CustomFormat = "dd/MM/yyyy";
            dtpBirth.Format = DateTimePickerFormat.Custom;
            dtpBirth.Location = new Point(257, 281);
            dtpBirth.Margin = new Padding(2, 2, 2, 2);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(248, 27);
            dtpBirth.TabIndex = 12;
            // 
            // btnReg
            // 
            btnReg.Location = new Point(192, 340);
            btnReg.Margin = new Padding(2, 2, 2, 2);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(92, 29);
            btnReg.TabIndex = 13;
            btnReg.Text = "Register";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(317, 340);
            btnLogin.Margin = new Padding(2, 2, 2, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.RightToLeft = RightToLeft.No;
            btnLogin.Size = new Size(92, 29);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 411);
            Controls.Add(btnLogin);
            Controls.Add(btnReg);
            Controls.Add(dtpBirth);
            Controls.Add(tbName);
            Controls.Add(tbEmail);
            Controls.Add(tbCfmPass);
            Controls.Add(tbPass);
            Controls.Add(tbUsername);
            Controls.Add(lbBirth);
            Controls.Add(lbName);
            Controls.Add(lbEmail);
            Controls.Add(lbCfmPass);
            Controls.Add(lbPass);
            Controls.Add(lbUsername);
            Controls.Add(lbSignup);
            Margin = new Padding(2, 2, 2, 2);
            Name = "SignupForm";
            Text = "Sign up";
            Load += SignupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSignup;
        private Label lbUsername;
        private Label lbPass;
        private Label lbCfmPass;
        private Label lbEmail;
        private Label lbName;
        private Label lbBirth;
        private TextBox tbUsername;
        private TextBox tbPass;
        private TextBox tbCfmPass;
        private TextBox tbEmail;
        private TextBox tbName;
        private DateTimePicker dtpBirth;
        private Button btnReg;
        private Button btnLogin;
    }
}