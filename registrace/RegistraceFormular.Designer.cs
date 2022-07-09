
namespace Japonstina
{
    partial class PanelRegistrace
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
            this.RegistrationLoginBox = new System.Windows.Forms.TextBox();
            this.RegistrationPasswordBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegistrationPasswordBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RegistrationError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistrationLoginBox
            // 
            this.RegistrationLoginBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegistrationLoginBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrationLoginBox.Location = new System.Drawing.Point(412, 219);
            this.RegistrationLoginBox.Name = "RegistrationLoginBox";
            this.RegistrationLoginBox.Size = new System.Drawing.Size(250, 43);
            this.RegistrationLoginBox.TabIndex = 0;
            this.RegistrationLoginBox.TextChanged += new System.EventHandler(this.RegistrationLoginBox_TextChanged);
            // 
            // RegistrationPasswordBox1
            // 
            this.RegistrationPasswordBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrationPasswordBox1.Location = new System.Drawing.Point(412, 331);
            this.RegistrationPasswordBox1.Name = "RegistrationPasswordBox1";
            this.RegistrationPasswordBox1.PasswordChar = '*';
            this.RegistrationPasswordBox1.Size = new System.Drawing.Size(250, 43);
            this.RegistrationPasswordBox1.TabIndex = 1;
            this.RegistrationPasswordBox1.TextChanged += new System.EventHandler(this.RegistrationPasswordBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(412, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrace";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegistrationPasswordBox2
            // 
            this.RegistrationPasswordBox2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrationPasswordBox2.Location = new System.Drawing.Point(412, 391);
            this.RegistrationPasswordBox2.Name = "RegistrationPasswordBox2";
            this.RegistrationPasswordBox2.PasswordChar = '*';
            this.RegistrationPasswordBox2.Size = new System.Drawing.Size(250, 43);
            this.RegistrationPasswordBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(412, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(412, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Heslo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(412, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrovat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrationError
            // 
            this.RegistrationError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrationError.ForeColor = System.Drawing.Color.Red;
            this.RegistrationError.Location = new System.Drawing.Point(412, 265);
            this.RegistrationError.Name = "RegistrationError";
            this.RegistrationError.Size = new System.Drawing.Size(245, 38);
            this.RegistrationError.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(201)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.RegistrationError);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RegistrationPasswordBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RegistrationPasswordBox1);
            this.panel1.Controls.Add(this.RegistrationLoginBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 768);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Salmon;
            this.label6.Location = new System.Drawing.Point(297, 571);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(517, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Požadavky na heslo: Alfanumerické znaky, délka 5-15 znaků, velké písmeno, číslice" +
    "";
            // 
            // PanelRegistrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 875);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelRegistrace";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox RegistrationLoginBox;
        private System.Windows.Forms.TextBox RegistrationPasswordBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegistrationPasswordBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label RegistrationError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}