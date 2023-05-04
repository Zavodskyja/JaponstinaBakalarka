
namespace Japonstina
{
    partial class Welcome
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
            panel1 = new System.Windows.Forms.Panel();
            PanelLogin = new System.Windows.Forms.Panel();
            panel6 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            Register_button = new System.Windows.Forms.Button();
            panel5 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            panel4 = new System.Windows.Forms.Panel();
            LoginError = new System.Windows.Forms.Label();
            PasswordBox = new System.Windows.Forms.TextBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            panel3 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            LoginBox = new System.Windows.Forms.TextBox();
            LoginPanel = new System.Windows.Forms.Panel();
            PanelLogin.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(252, 201, 185);
            panel1.Location = new System.Drawing.Point(306, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1050, 730);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            // 
            // PanelLogin
            // 
            PanelLogin.Controls.Add(panel6);
            PanelLogin.Controls.Add(panel5);
            PanelLogin.Controls.Add(panel4);
            PanelLogin.Controls.Add(panel3);
            PanelLogin.Location = new System.Drawing.Point(0, 150);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.Size = new System.Drawing.Size(300, 411);
            PanelLogin.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.Controls.Add(label2);
            panel6.Controls.Add(Register_button);
            panel6.Dock = System.Windows.Forms.DockStyle.Top;
            panel6.Location = new System.Drawing.Point(0, 295);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(300, 100);
            panel6.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(188, 0, 45);
            label2.Location = new System.Drawing.Point(12, 34);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 25);
            label2.TabIndex = 2;
            label2.Text = "Nemáš účet?";
            // 
            // Register_button
            // 
            Register_button.BackColor = System.Drawing.Color.FromArgb(188, 0, 45);
            Register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Register_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Register_button.Location = new System.Drawing.Point(177, 31);
            Register_button.Name = "Register_button";
            Register_button.Size = new System.Drawing.Size(110, 35);
            Register_button.TabIndex = 3;
            Register_button.Text = "Registrovat";
            Register_button.UseVisualStyleBackColor = false;
            Register_button.Click += Register_button_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Dock = System.Windows.Forms.DockStyle.Top;
            panel5.Location = new System.Drawing.Point(0, 215);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(300, 80);
            panel5.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(165, 186, 147);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(12, 24);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(275, 50);
            button1.TabIndex = 1;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // panel4
            // 
            panel4.Controls.Add(LoginError);
            panel4.Controls.Add(PasswordBox);
            panel4.Controls.Add(pictureBox2);
            panel4.Dock = System.Windows.Forms.DockStyle.Top;
            panel4.Location = new System.Drawing.Point(0, 115);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(300, 100);
            panel4.TabIndex = 3;
            // 
            // LoginError
            // 
            LoginError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LoginError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LoginError.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            LoginError.Location = new System.Drawing.Point(57, 9);
            LoginError.Name = "LoginError";
            LoginError.Size = new System.Drawing.Size(230, 23);
            LoginError.TabIndex = 8;
            LoginError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordBox
            // 
            PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PasswordBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PasswordBox.Location = new System.Drawing.Point(57, 35);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new System.Drawing.Size(230, 36);
            PasswordBox.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.key_solid;
            pictureBox2.Location = new System.Drawing.Point(12, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(39, 34);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(LoginBox);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(300, 115);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_regular;
            pictureBox1.Location = new System.Drawing.Point(12, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(39, 35);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LoginBox
            // 
            LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            LoginBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LoginBox.Location = new System.Drawing.Point(57, 40);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new System.Drawing.Size(230, 36);
            LoginBox.TabIndex = 4;
            LoginBox.TextChanged += LoginBox_TextChanged;
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = System.Drawing.Color.FromArgb(252, 201, 185);
            LoginPanel.Controls.Add(PanelLogin);
            LoginPanel.Dock = System.Windows.Forms.DockStyle.Left;
            LoginPanel.Location = new System.Drawing.Point(0, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new System.Drawing.Size(300, 729);
            LoginPanel.TabIndex = 0;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(252, 201, 185);
            ClientSize = new System.Drawing.Size(1350, 729);
            Controls.Add(panel1);
            Controls.Add(LoginPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "Welcome";
            Text = "Japonstina";
            Load += Form1_Load;
            PanelLogin.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            LoginPanel.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LoginError;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel LoginPanel;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox LoginBox;
    }
}

