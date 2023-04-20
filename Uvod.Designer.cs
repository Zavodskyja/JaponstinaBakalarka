
namespace Japonstina
{
    partial class Uvod
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
            WelcomeScreen = new System.Windows.Forms.Panel();
            WelcomeText_small = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            WelcomeText = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            WelcomeScreen.SuspendLayout();
            WelcomeText_small.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            WelcomeText.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomeScreen
            // 
            WelcomeScreen.BackColor = System.Drawing.Color.Salmon;
            WelcomeScreen.Controls.Add(WelcomeText_small);
            WelcomeScreen.Controls.Add(pictureBox4);
            WelcomeScreen.Controls.Add(WelcomeText);
            WelcomeScreen.Location = new System.Drawing.Point(0, 0);
            WelcomeScreen.Name = "WelcomeScreen";
            WelcomeScreen.Size = new System.Drawing.Size(1066, 768);
            WelcomeScreen.TabIndex = 2;
            // 
            // WelcomeText_small
            // 
            WelcomeText_small.Controls.Add(label3);
            WelcomeText_small.Dock = System.Windows.Forms.DockStyle.Top;
            WelcomeText_small.Location = new System.Drawing.Point(0, 67);
            WelcomeText_small.Name = "WelcomeText_small";
            WelcomeText_small.Size = new System.Drawing.Size(1066, 61);
            WelcomeText_small.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(333, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(388, 30);
            label3.TabIndex = 0;
            label3.Text = "Pro spuštění aplikace se prosím přihlašte";
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox4.Image = Properties.Resources.pokus1;
            pictureBox4.Location = new System.Drawing.Point(0, 67);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(1066, 701);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // WelcomeText
            // 
            WelcomeText.Controls.Add(label1);
            WelcomeText.Dock = System.Windows.Forms.DockStyle.Top;
            WelcomeText.Location = new System.Drawing.Point(0, 0);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new System.Drawing.Size(1066, 67);
            WelcomeText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(223, 2);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(607, 65);
            label1.TabIndex = 0;
            label1.Text = "Vítejte v aplikaci Japonština";
            // 
            // Uvod
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1241, 824);
            Controls.Add(WelcomeScreen);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Uvod";
            Text = "Uvod";
            WelcomeScreen.ResumeLayout(false);
            WelcomeText_small.ResumeLayout(false);
            WelcomeText_small.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            WelcomeText.ResumeLayout(false);
            WelcomeText.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Panel WelcomeScreen;
        private System.Windows.Forms.Panel WelcomeText_small;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel WelcomeText;
        private System.Windows.Forms.Label label1;
    }
}