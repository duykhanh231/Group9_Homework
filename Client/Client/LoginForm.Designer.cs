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
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(333, 49);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(138, 59);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Login";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(177, 173);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(121, 32);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(177, 274);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(111, 32);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(392, 170);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(265, 39);
            tbUsername.TabIndex = 3;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(392, 271);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(265, 39);
            tbPass.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbPass);
            Controls.Add(tbUsername);
            Controls.Add(lbPass);
            Controls.Add(lbUsername);
            Controls.Add(lbLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogin;
        private Label lbUsername;
        private Label lbPass;
        private TextBox tbUsername;
        private TextBox tbPass;
    }
}