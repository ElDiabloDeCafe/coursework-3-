namespace CourseWorkWithDB
{
    partial class Eratosthenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eratosthenes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nField = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(195)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.outputBox);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.Menu;
            this.outputBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputBox.Location = new System.Drawing.Point(0, 188);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(800, 262);
            this.outputBox.TabIndex = 6;
            this.outputBox.Text = "";
            // 
            // registerButton
            // 
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.Location = new System.Drawing.Point(508, 88);
            this.registerButton.Margin = new System.Windows.Forms.Padding(100);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(283, 58);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Найти простые числа";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.nField);
            this.panel3.Location = new System.Drawing.Point(10, 88);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.closeLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 82);
            this.panel2.TabIndex = 0;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLabel.ForeColor = System.Drawing.Color.White;
            this.closeLabel.Location = new System.Drawing.Point(756, 9);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(32, 33);
            this.closeLabel.TabIndex = 9;
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
            this.label1.Size = new System.Drawing.Size(800, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск простых чисел";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nField
            // 
            this.nField.BackColor = System.Drawing.SystemColors.Window;
            this.nField.Dock = System.Windows.Forms.DockStyle.Right;
            this.nField.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nField.Location = new System.Drawing.Point(68, 0);
            this.nField.Multiline = true;
            this.nField.Name = "nField";
            this.nField.Size = new System.Drawing.Size(225, 61);
            this.nField.TabIndex = 2;
            this.nField.Enter += new System.EventHandler(this.nField_Enter);
            this.nField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginField_KeyPress);
            this.nField.Leave += new System.EventHandler(this.nField_Leave);
            // 
            // Eratosthenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eratosthenes";
            this.Text = "Eratosthenes";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.TextBox nField;
    }
}