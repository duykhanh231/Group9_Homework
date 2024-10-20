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
            SuspendLayout();
            // 
            // lbSignup
            // 
            lbSignup.AutoSize = true;
            lbSignup.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSignup.Location = new Point(291, 44);
            lbSignup.Name = "lbSignup";
            lbSignup.Size = new Size(358, 59);
            lbSignup.TabIndex = 0;
            lbSignup.Text = "Account Sign up";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(132, 144);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(121, 32);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(132, 209);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(111, 32);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password";
            // 
            // lbCfmPass
            // 
            lbCfmPass.AutoSize = true;
            lbCfmPass.Location = new Point(132, 272);
            lbCfmPass.Name = "lbCfmPass";
            lbCfmPass.Size = new Size(204, 32);
            lbCfmPass.TabIndex = 3;
            lbCfmPass.Text = "Confirm Password";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(132, 334);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(71, 32);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "Email";
            lbEmail.Click += lbEmail_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(132, 396);
            lbName.Name = "lbName";
            lbName.Size = new Size(78, 32);
            lbName.TabIndex = 5;
            lbName.Text = "Name";
            // 
            // lbBirth
            // 
            lbBirth.AutoSize = true;
            lbBirth.Location = new Point(132, 455);
            lbBirth.Name = "lbBirth";
            lbBirth.Size = new Size(102, 32);
            lbBirth.TabIndex = 6;
            lbBirth.Text = "Birthday";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(418, 143);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(400, 39);
            tbUsername.TabIndex = 7;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(418, 206);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(400, 39);
            tbPass.TabIndex = 8;
            // 
            // tbCfmPass
            // 
            tbCfmPass.Location = new Point(418, 269);
            tbCfmPass.Name = "tbCfmPass";
            tbCfmPass.Size = new Size(400, 39);
            tbCfmPass.TabIndex = 9;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(418, 331);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(400, 39);
            tbEmail.TabIndex = 10;
            // 
            // tbName
            // 
            tbName.Location = new Point(418, 393);
            tbName.Name = "tbName";
            tbName.Size = new Size(400, 39);
            tbName.TabIndex = 11;
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(418, 450);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(400, 39);
            dtpBirth.TabIndex = 12;
            // 
            // btnReg
            // 
            btnReg.Location = new Point(402, 546);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(150, 46);
            btnReg.TabIndex = 13;
            btnReg.Text = "Register";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 658);
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
            Name = "SignupForm";
            Text = "Sign up";
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
    }
}