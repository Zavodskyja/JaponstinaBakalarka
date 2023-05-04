
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
            RegistrationLoginBox = new System.Windows.Forms.TextBox();
            RegistrationPasswordBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            RegistrationPasswordBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            RegistrationError = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // RegistrationLoginBox
            // 
            RegistrationLoginBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            RegistrationLoginBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RegistrationLoginBox.Location = new System.Drawing.Point(412, 219);
            RegistrationLoginBox.Name = "RegistrationLoginBox";
            RegistrationLoginBox.Size = new System.Drawing.Size(250, 43);
            RegistrationLoginBox.TabIndex = 0;
            RegistrationLoginBox.TextChanged += RegistrationLoginBox_TextChanged;
            // 
            // RegistrationPasswordBox1
            // 
            RegistrationPasswordBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RegistrationPasswordBox1.Location = new System.Drawing.Point(412, 331);
            RegistrationPasswordBox1.Name = "RegistrationPasswordBox1";
            RegistrationPasswordBox1.PasswordChar = '*';
            RegistrationPasswordBox1.Size = new System.Drawing.Size(250, 43);
            RegistrationPasswordBox1.TabIndex = 1;
            RegistrationPasswordBox1.TextChanged += RegistrationPasswordBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(412, 75);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(245, 65);
            label1.TabIndex = 2;
            label1.Text = "Registrace";
            label1.Click += label1_Click;
            // 
            // RegistrationPasswordBox2
            // 
            RegistrationPasswordBox2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RegistrationPasswordBox2.Location = new System.Drawing.Point(412, 391);
            RegistrationPasswordBox2.Name = "RegistrationPasswordBox2";
            RegistrationPasswordBox2.PasswordChar = '*';
            RegistrationPasswordBox2.Size = new System.Drawing.Size(250, 43);
            RegistrationPasswordBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Salmon;
            label2.Location = new System.Drawing.Point(412, 177);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 25);
            label2.TabIndex = 4;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Salmon;
            label3.Location = new System.Drawing.Point(412, 303);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 25);
            label3.TabIndex = 5;
            label3.Text = "Heslo";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Salmon;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(412, 463);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(250, 50);
            button1.TabIndex = 6;
            button1.Text = "Registrovat";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RegistrationError
            // 
            RegistrationError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RegistrationError.ForeColor = System.Drawing.Color.Red;
            RegistrationError.Location = new System.Drawing.Point(412, 265);
            RegistrationError.Name = "RegistrationError";
            RegistrationError.Size = new System.Drawing.Size(245, 38);
            RegistrationError.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(252, 201, 185);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(RegistrationError);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(RegistrationPasswordBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(RegistrationPasswordBox1);
            panel1.Controls.Add(RegistrationLoginBox);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1066, 768);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Salmon;
            label4.Location = new System.Drawing.Point(169, 547);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(507, 28);
            label4.TabIndex = 9;
            label4.Text = "Požadavky na login: Délka 4-10 znaků bez diakritiky";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Salmon;
            label6.Location = new System.Drawing.Point(169, 592);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(796, 28);
            label6.TabIndex = 8;
            label6.Text = "Požadavky na heslo: Alfanumerické znaky, délka 5-15 znaků, velké písmeno, číslice";
            // 
            // PanelRegistrace
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1401, 875);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "PanelRegistrace";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
    }
}