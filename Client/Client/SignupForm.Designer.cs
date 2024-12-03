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
            panel1 = new Panel();
            lbSignup = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(130, 156);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(163, 45);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPass.Location = new Point(130, 243);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(153, 45);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password";
            // 
            // lbCfmPass
            // 
            lbCfmPass.AutoSize = true;
            lbCfmPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCfmPass.Location = new Point(130, 324);
            lbCfmPass.Name = "lbCfmPass";
            lbCfmPass.Size = new Size(276, 45);
            lbCfmPass.TabIndex = 3;
            lbCfmPass.Text = "Confirm Password";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(130, 406);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(96, 45);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "Email";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.Location = new Point(130, 485);
            lbName.Name = "lbName";
            lbName.Size = new Size(105, 45);
            lbName.TabIndex = 5;
            lbName.Text = "Name";
            // 
            // lbBirth
            // 
            lbBirth.AutoSize = true;
            lbBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbBirth.Location = new Point(130, 568);
            lbBirth.Name = "lbBirth";
            lbBirth.Size = new Size(136, 45);
            lbBirth.TabIndex = 6;
            lbBirth.Text = "Birthday";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(455, 156);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(400, 47);
            tbUsername.TabIndex = 7;
            // 
            // tbPass
            // 
            tbPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPass.Location = new Point(455, 241);
            tbPass.Multiline = true;
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(400, 49);
            tbPass.TabIndex = 8;
            // 
            // tbCfmPass
            // 
            tbCfmPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCfmPass.Location = new Point(455, 326);
            tbCfmPass.Multiline = true;
            tbCfmPass.Name = "tbCfmPass";
            tbCfmPass.PasswordChar = '*';
            tbCfmPass.Size = new Size(400, 48);
            tbCfmPass.TabIndex = 9;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(455, 405);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(400, 48);
            tbEmail.TabIndex = 10;
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.Location = new Point(455, 484);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(400, 48);
            tbName.TabIndex = 11;
            // 
            // dtpBirth
            // 
            dtpBirth.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirth.CustomFormat = "dd/MM/yyyy";
            dtpBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirth.Format = DateTimePickerFormat.Custom;
            dtpBirth.Location = new Point(455, 565);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(400, 50);
            dtpBirth.TabIndex = 12;
            dtpBirth.Value = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // btnReg
            // 
            btnReg.BackColor = Color.RoyalBlue;
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReg.ForeColor = Color.White;
            btnReg.Location = new Point(301, 664);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(171, 60);
            btnReg.TabIndex = 13;
            btnReg.Text = "Register";
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += btnReg_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Teal;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(544, 664);
            btnLogin.Name = "btnLogin";
            btnLogin.RightToLeft = RightToLeft.No;
            btnLogin.Size = new Size(171, 60);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lbSignup);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 112);
            panel1.TabIndex = 15;
            // 
            // lbSignup
            // 
            lbSignup.AutoSize = true;
            lbSignup.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSignup.ForeColor = Color.White;
            lbSignup.Location = new Point(249, 21);
            lbSignup.Name = "lbSignup";
            lbSignup.Size = new Size(510, 65);
            lbSignup.TabIndex = 0;
            lbSignup.Text = "Create a new account";
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(988, 765);
            Controls.Add(panel1);
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
            Name = "SignupForm";
            Text = "Sign up";
            Load += SignupForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Panel panel1;
        private Label lbSignup;
    }
}