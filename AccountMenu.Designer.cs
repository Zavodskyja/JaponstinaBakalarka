namespace Japonstina
{
    partial class AccountMenu
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
            AbecedyPanel = new System.Windows.Forms.Panel();
            progressBar1 = new TransparentProgressBar();
            label11 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            progressBar2 = new TransparentProgressBar();
            progressBar3 = new TransparentProgressBar();
            label1 = new System.Windows.Forms.Label();
            KanjiPanel = new System.Windows.Forms.Panel();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            AbecedyPanel.SuspendLayout();
            KanjiPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AbecedyPanel
            // 
            AbecedyPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            AbecedyPanel.Controls.Add(progressBar1);
            AbecedyPanel.Controls.Add(label11);
            AbecedyPanel.Controls.Add(label6);
            AbecedyPanel.Controls.Add(label5);
            AbecedyPanel.Controls.Add(label4);
            AbecedyPanel.Controls.Add(label3);
            AbecedyPanel.Controls.Add(label2);
            AbecedyPanel.Location = new System.Drawing.Point(0, 0);
            AbecedyPanel.Name = "AbecedyPanel";
            AbecedyPanel.Size = new System.Drawing.Size(1066, 250);
            AbecedyPanel.TabIndex = 4;
            AbecedyPanel.Paint += AbecedyPanel_Paint;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            progressBar1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            progressBar1.Location = new System.Drawing.Point(23, 169);
            progressBar1.Maximum = 100;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(965, 35);
            progressBar1.TabIndex = 14;
            progressBar1.Value = 0;
            progressBar1.Click += progressBar1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(329, 9);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(285, 28);
            label11.TabIndex = 13;
            label11.Text = "Pro více detailů klikněte na graf";
            label11.Click += label11_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(156, 117);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(34, 28);
            label6.TabIndex = 9;
            label6.Text = "90";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(167, 79);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(23, 28);
            label5.TabIndex = 8;
            label5.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(23, 117);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 28);
            label4.TabIndex = 7;
            label4.Text = "Nesplněno:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(23, 79);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 28);
            label3.TabIndex = 6;
            label3.Text = "Splněno:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(14, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(176, 54);
            label2.TabIndex = 6;
            label2.Text = "Abecedy";
            // 
            // progressBar2
            // 
            progressBar2.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            progressBar2.Location = new System.Drawing.Point(23, 158);
            progressBar2.Maximum = 100;
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new System.Drawing.Size(965, 35);
            progressBar2.TabIndex = 13;
            progressBar2.Value = 0;
            // 
            // progressBar3
            // 
            progressBar3.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            progressBar3.Location = new System.Drawing.Point(23, 164);
            progressBar3.Maximum = 100;
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new System.Drawing.Size(965, 35);
            progressBar3.TabIndex = 13;
            progressBar3.Value = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(14, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 54);
            label1.TabIndex = 3;
            label1.Text = "Kanji";
            // 
            // KanjiPanel
            // 
            KanjiPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            KanjiPanel.Controls.Add(progressBar2);
            KanjiPanel.Controls.Add(label10);
            KanjiPanel.Controls.Add(label9);
            KanjiPanel.Controls.Add(label8);
            KanjiPanel.Controls.Add(label7);
            KanjiPanel.Controls.Add(label1);
            KanjiPanel.Location = new System.Drawing.Point(0, 252);
            KanjiPanel.Name = "KanjiPanel";
            KanjiPanel.Size = new System.Drawing.Size(1066, 250);
            KanjiPanel.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(156, 106);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(34, 28);
            label10.TabIndex = 12;
            label10.Text = "90";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(167, 67);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(23, 28);
            label9.TabIndex = 10;
            label9.Text = "5";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(23, 106);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(109, 28);
            label8.TabIndex = 11;
            label8.Text = "Neplněno:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(23, 67);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(93, 28);
            label7.TabIndex = 10;
            label7.Text = "Splněno:";
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(progressBar3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label16);
            panel1.Location = new System.Drawing.Point(0, 508);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1066, 250);
            panel1.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(156, 106);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(34, 28);
            label12.TabIndex = 12;
            label12.Text = "90";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(167, 67);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(23, 28);
            label13.TabIndex = 10;
            label13.Text = "5";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(23, 106);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(109, 28);
            label14.TabIndex = 11;
            label14.Text = "Neplněno:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label15.Location = new System.Drawing.Point(23, 67);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(93, 28);
            label15.TabIndex = 10;
            label15.Text = "Splněno:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label16.Location = new System.Drawing.Point(14, 13);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(154, 54);
            label16.TabIndex = 3;
            label16.Text = "Slovesa";
            // 
            // AccountMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(252, 201, 185);
            ClientSize = new System.Drawing.Size(1066, 768);
            Controls.Add(panel1);
            Controls.Add(KanjiPanel);
            Controls.Add(AbecedyPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "AccountMenu";
            Text = "Form1";
            AbecedyPanel.ResumeLayout(false);
            AbecedyPanel.PerformLayout();
            KanjiPanel.ResumeLayout(false);
            KanjiPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel AbecedyPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel KanjiPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private TransparentProgressBar progressBar1;
        private TransparentProgressBar progressBar2;
        private TransparentProgressBar progressBar3;
    }
}