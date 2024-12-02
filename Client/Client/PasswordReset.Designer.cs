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
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(28, 71);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(189, 32);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Enter your email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(226, 71);
            tbEmail.Margin = new Padding(2);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(218, 33);
            tbEmail.TabIndex = 1;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(190, 169);
            btnSubmit.Margin = new Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(111, 36);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // PasswordReset
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 281);
            Controls.Add(btnSubmit);
            Controls.Add(tbEmail);
            Controls.Add(lblEmail);
            Margin = new Padding(2);
            Name = "PasswordReset";
            Text = "Password Reset";
            Load += PasswordReset_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox tbEmail;
        private Button btnSubmit;
    }
}