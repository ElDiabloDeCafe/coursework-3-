namespace CourseWorkWithDB
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.registerLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(195)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 496);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.registerLabel);
            this.panel5.Controls.Add(this.loginButton);
            this.panel5.Location = new System.Drawing.Point(12, 291);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 193);
            this.panel5.TabIndex = 6;
            // 
            // registerLabel
            // 
            this.registerLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.Location = new System.Drawing.Point(88, 138);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(117, 23);
            this.registerLabel.TabIndex = 6;
            this.registerLabel.Text = "Нет аккаунта?";
            this.registerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(88, 71);
            this.loginButton.Margin = new System.Windows.Forms.Padding(100);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(117, 58);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.passwordField);
            this.panel4.Location = new System.Drawing.Point(12, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 61);
            this.panel4.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.SystemColors.Window;
            this.passwordField.Dock = System.Windows.Forms.DockStyle.Right;
            this.passwordField.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(68, 0);
            this.passwordField.Multiline = true;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(225, 61);
            this.passwordField.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.loginField);
            this.panel3.Location = new System.Drawing.Point(12, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 61);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.SystemColors.Window;
            this.loginField.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(68, 0);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(225, 61);
            this.loginField.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.closeLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 157);
            this.panel2.TabIndex = 0;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.ForeColor = System.Drawing.Color.White;
            this.closeLabel.Location = new System.Drawing.Point(285, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(32, 33);
            this.closeLabel.TabIndex = 1;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(239)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 157);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 496);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label closeLabel;
    }
}