namespace Client
{
    partial class Change_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Password));
            pictureBox1 = new PictureBox();
            lb_oldpassword = new Label();
            lb_newpassword = new Label();
            lb_confirmpassword = new Label();
            tb_oldpassword = new TextBox();
            tb_newpassword = new TextBox();
            tb_confirmpassword = new TextBox();
            btn_changepassword = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(327, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lb_oldpassword
            // 
            lb_oldpassword.AutoSize = true;
            lb_oldpassword.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_oldpassword.Location = new Point(53, 218);
            lb_oldpassword.Name = "lb_oldpassword";
            lb_oldpassword.Size = new Size(160, 28);
            lb_oldpassword.TabIndex = 1;
            lb_oldpassword.Text = "Old Password";
            // 
            // lb_newpassword
            // 
            lb_newpassword.AutoSize = true;
            lb_newpassword.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_newpassword.Location = new Point(53, 286);
            lb_newpassword.Name = "lb_newpassword";
            lb_newpassword.Size = new Size(172, 28);
            lb_newpassword.TabIndex = 2;
            lb_newpassword.Text = "New Password";
            // 
            // lb_confirmpassword
            // 
            lb_confirmpassword.AutoSize = true;
            lb_confirmpassword.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_confirmpassword.Location = new Point(53, 354);
            lb_confirmpassword.Name = "lb_confirmpassword";
            lb_confirmpassword.Size = new Size(210, 28);
            lb_confirmpassword.TabIndex = 3;
            lb_confirmpassword.Text = "Confirm Password";
            // 
            // tb_oldpassword
            // 
            tb_oldpassword.Location = new Point(287, 219);
            tb_oldpassword.Multiline = true;
            tb_oldpassword.Name = "tb_oldpassword";
            tb_oldpassword.Size = new Size(278, 34);
            tb_oldpassword.TabIndex = 4;
            // 
            // tb_newpassword
            // 
            tb_newpassword.Location = new Point(287, 286);
            tb_newpassword.Multiline = true;
            tb_newpassword.Name = "tb_newpassword";
            tb_newpassword.Size = new Size(278, 34);
            tb_newpassword.TabIndex = 5;
            // 
            // tb_confirmpassword
            // 
            tb_confirmpassword.Location = new Point(287, 354);
            tb_confirmpassword.Multiline = true;
            tb_confirmpassword.Name = "tb_confirmpassword";
            tb_confirmpassword.Size = new Size(278, 34);
            tb_confirmpassword.TabIndex = 6;
            // 
            // btn_changepassword
            // 
            btn_changepassword.BackColor = Color.Blue;
            btn_changepassword.Font = new Font("Baskerville Old Face", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_changepassword.ForeColor = SystemColors.ButtonHighlight;
            btn_changepassword.Location = new Point(629, 388);
            btn_changepassword.Name = "btn_changepassword";
            btn_changepassword.Size = new Size(217, 50);
            btn_changepassword.TabIndex = 7;
            btn_changepassword.Text = "Change Password";
            btn_changepassword.UseVisualStyleBackColor = false;
            btn_changepassword.Click += btn_changepassword_Click;
            // 
            // Change_Password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 450);
            Controls.Add(btn_changepassword);
            Controls.Add(tb_confirmpassword);
            Controls.Add(tb_newpassword);
            Controls.Add(tb_oldpassword);
            Controls.Add(lb_confirmpassword);
            Controls.Add(lb_newpassword);
            Controls.Add(lb_oldpassword);
            Controls.Add(pictureBox1);
            Name = "Change_Password";
            Text = "Change_Password";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lb_oldpassword;
        private Label lb_newpassword;
        private Label lb_confirmpassword;
        private TextBox tb_oldpassword;
        private TextBox tb_newpassword;
        private TextBox tb_confirmpassword;
        private Button btn_changepassword;
    }
}