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
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(134, 32);
            lbLogin.Margin = new Padding(2, 0, 2, 0);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(258, 37);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Enter your account";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(109, 108);
            lbUsername.Margin = new Padding(2, 0, 2, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 20);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(109, 171);
            lbPass.Margin = new Padding(2, 0, 2, 0);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(70, 20);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(241, 106);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(165, 27);
            tbUsername.TabIndex = 3;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(241, 169);
            tbPass.Margin = new Padding(2);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(165, 27);
            tbPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(215, 228);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(92, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnPasswordReset
            // 
            btnPasswordReset.Location = new Point(198, 276);
            btnPasswordReset.Margin = new Padding(2);
            btnPasswordReset.Name = "btnPasswordReset";
            btnPasswordReset.Size = new Size(124, 29);
            btnPasswordReset.TabIndex = 6;
            btnPasswordReset.Text = "Forget password";
            btnPasswordReset.UseVisualStyleBackColor = true;
            btnPasswordReset.Click += btnPasswordReset_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 330);
            Controls.Add(btnPasswordReset);
            Controls.Add(btnLogin);
            Controls.Add(tbPass);
            Controls.Add(tbUsername);
            Controls.Add(lbPass);
            Controls.Add(lbUsername);
            Controls.Add(lbLogin);
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
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
    }
}