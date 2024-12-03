namespace Client
{
    partial class NavForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbUserMgmt = new Label();
            btnLogin = new Button();
            btnSignup = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbUserMgmt
            // 
            lbUserMgmt.AutoSize = true;
            lbUserMgmt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserMgmt.ForeColor = Color.White;
            lbUserMgmt.Location = new Point(242, 20);
            lbUserMgmt.Name = "lbUserMgmt";
            lbUserMgmt.Size = new Size(443, 65);
            lbUserMgmt.TabIndex = 0;
            lbUserMgmt.Text = "User Management";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Teal;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(382, 223);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 61);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.RoyalBlue;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(382, 318);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(163, 61);
            btnSignup.TabIndex = 2;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lbUserMgmt);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 112);
            panel1.TabIndex = 8;
            // 
            // NavForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(913, 544);
            Controls.Add(panel1);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Name = "NavForm";
            Text = "Account";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbUserMgmt;
        private Button btnLogin;
        private Button btnSignup;
        private Panel panel1;
    }
}
