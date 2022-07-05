
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
            this.WelcomeScreen = new System.Windows.Forms.Panel();
            this.WelcomeText_small = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.WelcomeText = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.WelcomeScreen.SuspendLayout();
            this.WelcomeText_small.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.WelcomeText.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeScreen
            // 
            this.WelcomeScreen.BackColor = System.Drawing.Color.Salmon;
            this.WelcomeScreen.Controls.Add(this.WelcomeText_small);
            this.WelcomeScreen.Controls.Add(this.pictureBox4);
            this.WelcomeScreen.Controls.Add(this.WelcomeText);
            this.WelcomeScreen.Location = new System.Drawing.Point(0, 0);
            this.WelcomeScreen.Name = "WelcomeScreen";
            this.WelcomeScreen.Size = new System.Drawing.Size(1066, 768);
            this.WelcomeScreen.TabIndex = 2;
            // 
            // WelcomeText_small
            // 
            this.WelcomeText_small.Controls.Add(this.label3);
            this.WelcomeText_small.Dock = System.Windows.Forms.DockStyle.Top;
            this.WelcomeText_small.Location = new System.Drawing.Point(0, 67);
            this.WelcomeText_small.Name = "WelcomeText_small";
            this.WelcomeText_small.Size = new System.Drawing.Size(1066, 61);
            this.WelcomeText_small.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(333, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pro spuštění aplikace se prosím přihlašte";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::Japonstina.Properties.Resources.JP_Logo;
            this.pictureBox4.Location = new System.Drawing.Point(0, 67);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1066, 701);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // WelcomeText
            // 
            this.WelcomeText.Controls.Add(this.label1);
            this.WelcomeText.Dock = System.Windows.Forms.DockStyle.Top;
            this.WelcomeText.Location = new System.Drawing.Point(0, 0);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(1066, 67);
            this.WelcomeText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(223, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vítejte v aplikaci Japonština";
            // 
            // Uvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 824);
            this.Controls.Add(this.WelcomeScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Uvod";
            this.Text = "Uvod";
            this.WelcomeScreen.ResumeLayout(false);
            this.WelcomeText_small.ResumeLayout(false);
            this.WelcomeText_small.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.WelcomeText.ResumeLayout(false);
            this.WelcomeText.PerformLayout();
            this.ResumeLayout(false);

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