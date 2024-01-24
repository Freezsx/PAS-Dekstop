namespace PAS
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            txtConfirmPassword = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnClose = new Button();
            btnMasuk = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Kriug;
            pictureBox1.Location = new Point(23, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnMasuk);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(327, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 396);
            panel1.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(254, 255);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(185, 27);
            txtConfirmPassword.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(223, 254);
            label6.Name = "label6";
            label6.Size = new Size(17, 28);
            label6.TabIndex = 12;
            label6.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(24, 258);
            label7.Name = "label7";
            label7.Size = new Size(193, 24);
            label7.TabIndex = 11;
            label7.Text = "Confirm Password";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(245, 324);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 47);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMasuk
            // 
            btnMasuk.Location = new Point(116, 324);
            btnMasuk.Name = "btnMasuk";
            btnMasuk.Size = new Size(94, 47);
            btnMasuk.TabIndex = 9;
            btnMasuk.Text = "Masuk";
            btnMasuk.UseVisualStyleBackColor = true;
            btnMasuk.Click += btnMasuk_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(254, 188);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(185, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(254, 120);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(185, 27);
            txtUsername.TabIndex = 7;
            txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(223, 187);
            label5.Name = "label5";
            label5.Size = new Size(17, 28);
            label5.TabIndex = 6;
            label5.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(223, 119);
            label4.Name = "label4";
            label4.Size = new Size(17, 28);
            label4.TabIndex = 5;
            label4.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 191);
            label3.Name = "label3";
            label3.Size = new Size(107, 24);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 123);
            label2.Name = "label2";
            label2.Size = new Size(112, 24);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(193, 36);
            label1.Name = "label1";
            label1.Size = new Size(85, 42);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 396);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnMasuk;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label5;
        private Button btnClose;
        private TextBox txtConfirmPassword;
        private Label label6;
        private Label label7;
    }
}