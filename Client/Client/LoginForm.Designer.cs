namespace Client
{
    partial class LoginForm
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
            lbLogin = new Label();
            lbUsername = new Label();
            lbPass = new Label();
            tbUsername = new TextBox();
            tbPass = new TextBox();
            btnLogin = new Button();
            btnPasswordReset = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.ForeColor = Color.White;
            lbLogin.Location = new Point(235, 23);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(454, 65);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Enter your account";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(177, 173);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(163, 45);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPass.Location = new Point(177, 274);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(153, 45);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(392, 170);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(266, 48);
            tbUsername.TabIndex = 3;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // tbPass
            // 
            tbPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPass.Location = new Point(392, 270);
            tbPass.Multiline = true;
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(266, 49);
            tbPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Teal;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(376, 382);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(175, 55);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnPasswordReset
            // 
            btnPasswordReset.BackColor = Color.IndianRed;
            btnPasswordReset.FlatStyle = FlatStyle.Flat;
            btnPasswordReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPasswordReset.ForeColor = Color.White;
            btnPasswordReset.Location = new Point(312, 474);
            btnPasswordReset.Name = "btnPasswordReset";
            btnPasswordReset.Size = new Size(296, 55);
            btnPasswordReset.TabIndex = 6;
            btnPasswordReset.Text = "Forget password";
            btnPasswordReset.UseVisualStyleBackColor = false;
            btnPasswordReset.Click += btnPasswordReset_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lbLogin);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 112);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(910, 561);
            Controls.Add(panel1);
            Controls.Add(btnPasswordReset);
            Controls.Add(btnLogin);
            Controls.Add(tbPass);
            Controls.Add(tbUsername);
            Controls.Add(lbPass);
            Controls.Add(lbUsername);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogin;
        private Label lbUsername;
        private Label lbPass;
        private TextBox tbUsername;
        private TextBox tbPass;
        private Button btnLogin;
        private Button btnPasswordReset;
        private Panel panel1;
    }
}