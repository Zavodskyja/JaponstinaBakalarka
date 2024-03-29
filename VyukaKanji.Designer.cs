﻿
using System.Drawing;

namespace Japonstina
{
    partial class VyukaKanji
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
            panel1 = new System.Windows.Forms.Panel();
            progressBar = new TransparentProgressBar();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            Vyuka_button4 = new System.Windows.Forms.Button();
            Vyuka_button3 = new System.Windows.Forms.Button();
            Vyuka_button2 = new System.Windows.Forms.Button();
            Vyuka_button1 = new System.Windows.Forms.Button();
            kanji_hiragana = new System.Windows.Forms.Label();
            kanji_char = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 201, 185);
            panel1.Controls.Add(progressBar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Vyuka_button4);
            panel1.Controls.Add(Vyuka_button3);
            panel1.Controls.Add(Vyuka_button2);
            panel1.Controls.Add(Vyuka_button1);
            panel1.Controls.Add(kanji_hiragana);
            panel1.Controls.Add(kanji_char);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1066, 768);
            panel1.TabIndex = 0;
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.Transparent;
            progressBar.ForeColor = Color.Black;
            progressBar.Location = new Point(263, 582);
            progressBar.Maximum = 90;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(550, 26);
            progressBar.TabIndex = 8;
            progressBar.Value = 0;
            progressBar.Click += progressBar_Click;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(263, 276);
            label2.Name = "label2";
            label2.Size = new Size(550, 55);
            label2.TabIndex = 7;
            label2.Text = "Tvar slovesa";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(263, 331);
            label1.Name = "label1";
            label1.Size = new Size(550, 41);
            label1.TabIndex = 6;
            label1.Text = "Spravna odpoved";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Vyuka_button4
            // 
            Vyuka_button4.BackColor = Color.FromArgb(240, 143, 144);
            Vyuka_button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Vyuka_button4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Vyuka_button4.Location = new Point(563, 473);
            Vyuka_button4.Name = "Vyuka_button4";
            Vyuka_button4.Size = new Size(250, 40);
            Vyuka_button4.TabIndex = 5;
            Vyuka_button4.Text = "Tlacitko";
            Vyuka_button4.UseVisualStyleBackColor = false;
            Vyuka_button4.Click += kanji_button4_Click;
            // 
            // Vyuka_button3
            // 
            Vyuka_button3.BackColor = Color.FromArgb(120, 119, 155);
            Vyuka_button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Vyuka_button3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Vyuka_button3.Location = new Point(263, 473);
            Vyuka_button3.Name = "Vyuka_button3";
            Vyuka_button3.Size = new Size(250, 40);
            Vyuka_button3.TabIndex = 4;
            Vyuka_button3.Text = "mouseover? / vybrana";
            Vyuka_button3.UseVisualStyleBackColor = false;
            Vyuka_button3.Click += kanji_button3_Click;
            // 
            // Vyuka_button2
            // 
            Vyuka_button2.BackColor = Color.FromArgb(188, 0, 45);
            Vyuka_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Vyuka_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Vyuka_button2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Vyuka_button2.Location = new Point(563, 401);
            Vyuka_button2.Name = "Vyuka_button2";
            Vyuka_button2.Size = new Size(250, 40);
            Vyuka_button2.TabIndex = 3;
            Vyuka_button2.Text = "Zla odpoved";
            Vyuka_button2.UseVisualStyleBackColor = false;
            Vyuka_button2.Click += kanji_button2_Click;
            // 
            // Vyuka_button1
            // 
            Vyuka_button1.BackColor = Color.FromArgb(165, 186, 147);
            Vyuka_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Vyuka_button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Vyuka_button1.Location = new Point(263, 401);
            Vyuka_button1.Name = "Vyuka_button1";
            Vyuka_button1.Size = new Size(250, 40);
            Vyuka_button1.TabIndex = 2;
            Vyuka_button1.Text = "Spravne";
            Vyuka_button1.UseVisualStyleBackColor = false;
            Vyuka_button1.Click += kanji_button1_Click;
            // 
            // kanji_hiragana
            // 
            kanji_hiragana.Anchor = System.Windows.Forms.AnchorStyles.None;
            kanji_hiragana.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            kanji_hiragana.Location = new Point(263, 221);
            kanji_hiragana.Name = "kanji_hiragana";
            kanji_hiragana.Size = new Size(550, 55);
            kanji_hiragana.TabIndex = 1;
            kanji_hiragana.Text = "Furigana";
            kanji_hiragana.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kanji_char
            // 
            kanji_char.Anchor = System.Windows.Forms.AnchorStyles.None;
            kanji_char.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            kanji_char.Location = new Point(263, 76);
            kanji_char.Name = "kanji_char";
            kanji_char.Size = new Size(550, 200);
            kanji_char.TabIndex = 0;
            kanji_char.Text = "Kanji";
            kanji_char.TextAlign = ContentAlignment.MiddleCenter;
            kanji_char.Click += kanji_char_Click;
            // 
            // VyukaKanji
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(1252, 846);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "VyukaKanji";
            Text = "Kanji";
            Load += Kanji_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label kanji_char;
        private System.Windows.Forms.Label kanji_hiragana;
        private System.Windows.Forms.Button Vyuka_button4;
        private System.Windows.Forms.Button Vyuka_button3;
        private System.Windows.Forms.Button Vyuka_button2;
        private System.Windows.Forms.Button Vyuka_button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TransparentProgressBar progressBar;
    }
}