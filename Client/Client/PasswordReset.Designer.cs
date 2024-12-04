namespace Client
{
    partial class PasswordReset
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
            lblEmail = new Label();
            tbEmail = new TextBox();
            btnSubmit = new Button();
            panel1 = new Panel();
            lbPasswordReset = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(110, 203);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(251, 45);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Enter your email";
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.White;
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(411, 200);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(352, 50);
            tbEmail.TabIndex = 1;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.IndianRed;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(377, 339);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(180, 58);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lbPasswordReset);
            panel1.Location = new Point(2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 112);
            panel1.TabIndex = 9;
            // 
            // lbPasswordReset
            // 
            lbPasswordReset.AutoSize = true;
            lbPasswordReset.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPasswordReset.ForeColor = Color.White;
            lbPasswordReset.Location = new Point(211, 21);
            lbPasswordReset.Name = "lbPasswordReset";
            lbPasswordReset.Size = new Size(493, 65);
            lbPasswordReset.TabIndex = 0;
            lbPasswordReset.Text = "Reset your password";
            // 
            // PasswordReset
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(915, 508);
            Controls.Add(panel1);
            Controls.Add(btnSubmit);
            Controls.Add(tbEmail);
            Controls.Add(lblEmail);
            Name = "PasswordReset";
            Text = "Password Reset";
            Load += PasswordReset_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox tbEmail;
        private Button btnSubmit;
        private Panel panel1;
        private Label lbPasswordReset;
    }
}