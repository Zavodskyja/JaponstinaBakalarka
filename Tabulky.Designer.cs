
namespace Japonstina
{
    partial class Tabulky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabulky));
            Hiragana = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            Katakana2 = new System.Windows.Forms.PictureBox();
            Hiragana2 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            Katakana = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)Hiragana).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Katakana2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Hiragana2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Katakana).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Hiragana
            // 
            Hiragana.Image = (System.Drawing.Image)resources.GetObject("Hiragana.Image");
            Hiragana.Location = new System.Drawing.Point(0, 174);
            Hiragana.Name = "Hiragana";
            Hiragana.Size = new System.Drawing.Size(139, 130);
            Hiragana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Hiragana.TabIndex = 0;
            Hiragana.TabStop = false;
            Hiragana.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(Katakana2);
            panel2.Controls.Add(Hiragana2);
            panel2.Location = new System.Drawing.Point(171, 9);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(894, 744);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(0, 307);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(894, 108);
            label3.TabIndex = 2;
            label3.Text = "Po najetí myší na náhled se zobrazí tabulka.\r\nPro stažení klikněte na náhled.";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Katakana2
            // 
            Katakana2.Dock = System.Windows.Forms.DockStyle.Fill;
            Katakana2.Image = (System.Drawing.Image)resources.GetObject("Katakana2.Image");
            Katakana2.Location = new System.Drawing.Point(0, 0);
            Katakana2.Name = "Katakana2";
            Katakana2.Size = new System.Drawing.Size(894, 744);
            Katakana2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Katakana2.TabIndex = 2;
            Katakana2.TabStop = false;
            Katakana2.Visible = false;
            Katakana2.Click += Katakana2_Click;
            // 
            // Hiragana2
            // 
            Hiragana2.Dock = System.Windows.Forms.DockStyle.Fill;
            Hiragana2.Image = (System.Drawing.Image)resources.GetObject("Hiragana2.Image");
            Hiragana2.Location = new System.Drawing.Point(0, 0);
            Hiragana2.Name = "Hiragana2";
            Hiragana2.Size = new System.Drawing.Size(894, 744);
            Hiragana2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Hiragana2.TabIndex = 2;
            Hiragana2.TabStop = false;
            Hiragana2.Visible = false;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Salmon;
            label2.Location = new System.Drawing.Point(3, 339);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(139, 54);
            label2.TabIndex = 1;
            label2.Text = "Katakana";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // Katakana
            // 
            Katakana.Image = (System.Drawing.Image)resources.GetObject("Katakana.Image");
            Katakana.Location = new System.Drawing.Point(3, 396);
            Katakana.Name = "Katakana";
            Katakana.Size = new System.Drawing.Size(139, 130);
            Katakana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Katakana.TabIndex = 0;
            Katakana.TabStop = false;
            Katakana.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Katakana);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Hiragana);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(142, 747);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Salmon;
            label1.Location = new System.Drawing.Point(0, 126);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(139, 45);
            label1.TabIndex = 1;
            label1.Text = "Hiragana";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Tabulky
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(252, 201, 185);
            ClientSize = new System.Drawing.Size(1066, 768);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Tabulky";
            Text = "Tabulky";
            ((System.ComponentModel.ISupportInitialize)Hiragana).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Katakana2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Hiragana2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Katakana).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Katakana;
        public System.Windows.Forms.PictureBox Hiragana;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Katakana2;
        public System.Windows.Forms.PictureBox Hiragana2;
        private System.Windows.Forms.Label label3;
    }
}