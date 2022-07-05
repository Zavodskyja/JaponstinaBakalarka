
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
            this.Hiragana = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Katakana2 = new System.Windows.Forms.PictureBox();
            this.Hiragana2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Katakana = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Hiragana)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Katakana2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hiragana2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Katakana)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hiragana
            // 
            this.Hiragana.Image = global::Japonstina.Properties.Resources.HiraganaChartPinkAPIECEOFSUSHI_COM_;
            this.Hiragana.Location = new System.Drawing.Point(0, 174);
            this.Hiragana.Name = "Hiragana";
            this.Hiragana.Size = new System.Drawing.Size(139, 130);
            this.Hiragana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hiragana.TabIndex = 0;
            this.Hiragana.TabStop = false;
            this.Hiragana.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Katakana2);
            this.panel2.Controls.Add(this.Hiragana2);
            this.panel2.Location = new System.Drawing.Point(171, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 744);
            this.panel2.TabIndex = 1;
            // 
            // Katakana2
            // 
            this.Katakana2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Katakana2.Image = global::Japonstina.Properties.Resources.KatakanaChartPinkAPIECEOFSUSHI_COM_;
            this.Katakana2.Location = new System.Drawing.Point(0, 0);
            this.Katakana2.Name = "Katakana2";
            this.Katakana2.Size = new System.Drawing.Size(894, 744);
            this.Katakana2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Katakana2.TabIndex = 2;
            this.Katakana2.TabStop = false;
            this.Katakana2.Visible = false;
            // 
            // Hiragana2
            // 
            this.Hiragana2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hiragana2.Image = global::Japonstina.Properties.Resources.HiraganaChartPinkAPIECEOFSUSHI_COM_;
            this.Hiragana2.Location = new System.Drawing.Point(0, 0);
            this.Hiragana2.Name = "Hiragana2";
            this.Hiragana2.Size = new System.Drawing.Size(894, 744);
            this.Hiragana2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hiragana2.TabIndex = 2;
            this.Hiragana2.TabStop = false;
            this.Hiragana2.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(3, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Katakana";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Katakana
            // 
            this.Katakana.Image = global::Japonstina.Properties.Resources.KatakanaChartPinkAPIECEOFSUSHI_COM_;
            this.Katakana.Location = new System.Drawing.Point(3, 396);
            this.Katakana.Name = "Katakana";
            this.Katakana.Size = new System.Drawing.Size(139, 130);
            this.Katakana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Katakana.TabIndex = 0;
            this.Katakana.TabStop = false;
            this.Katakana.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Katakana);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Hiragana);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 747);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(0, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hiragana";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tabulky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(201)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(1066, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tabulky";
            this.Text = "Tabulky";
            ((System.ComponentModel.ISupportInitialize)(this.Hiragana)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Katakana2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hiragana2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Katakana)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Katakana;
        public System.Windows.Forms.PictureBox Hiragana;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Katakana2;
        public System.Windows.Forms.PictureBox Hiragana2;
    }
}