namespace TCPSocket
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // lbSignup
            // 
            lbSignup.AutoSize = true;
            lbSignup.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSignup.Location = new Point(325, 45);
            lbSignup.Name = "lbSignup";
            lbSignup.Size = new Size(179, 59);
            lbSignup.TabIndex = 0;
            lbSignup.Text = "Sign up";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(101, 147);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(121, 32);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(101, 206);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(111, 32);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password";
            // 
            // lbCfmPass
            // 
            lbCfmPass.AutoSize = true;
            lbCfmPass.Location = new Point(101, 265);
            lbCfmPass.Name = "lbCfmPass";
            lbCfmPass.Size = new Size(204, 32);
            lbCfmPass.TabIndex = 3;
            lbCfmPass.Text = "Confirm Password";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(101, 323);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(71, 32);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "Email";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(101, 377);
            lbName.Name = "lbName";
            lbName.Size = new Size(78, 32);
            lbName.TabIndex = 5;
            lbName.Text = "Name";
            // 
            // lbBirth
            // 
            lbBirth.AutoSize = true;
            lbBirth.Location = new Point(101, 433);
            lbBirth.Name = "lbBirth";
            lbBirth.Size = new Size(102, 32);
            lbBirth.TabIndex = 6;
            lbBirth.Text = "Birthday";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(354, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(390, 39);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(354, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(390, 39);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(354, 262);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(390, 39);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(354, 320);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(390, 39);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(354, 374);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(390, 39);
            textBox5.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(354, 428);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(390, 39);
            dateTimePicker1.TabIndex = 12;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 527);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbBirth);
            Controls.Add(lbName);
            Controls.Add(lbEmail);
            Controls.Add(lbCfmPass);
            Controls.Add(lbPass);
            Controls.Add(lbUsername);
            Controls.Add(lbSignup);
            Name = "SignupForm";
            Text = "SignupForm";
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
    }
}