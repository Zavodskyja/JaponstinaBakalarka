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
            progressBarKatakana = new TransparentProgressBar();
            label11 = new System.Windows.Forms.Label();
            labelMissingKatakanaValue = new System.Windows.Forms.Label();
            labelCompletedKatakanaValue = new System.Windows.Forms.Label();
            labelMissingKatakana = new System.Windows.Forms.Label();
            labelCompletedKatakana = new System.Windows.Forms.Label();
            labelKatakana = new System.Windows.Forms.Label();
            progressBarKanji = new TransparentProgressBar();
            progressBarVerbs = new TransparentProgressBar();
            labelKanji = new System.Windows.Forms.Label();
            KanjiPanel = new System.Windows.Forms.Panel();
            labelMissingKanjiValue = new System.Windows.Forms.Label();
            labelCompletedKanjiValue = new System.Windows.Forms.Label();
            labelMissingKanji = new System.Windows.Forms.Label();
            labelCompletedKanji = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            labelMissingVerbsValue = new System.Windows.Forms.Label();
            labelCompletedVerbsValue = new System.Windows.Forms.Label();
            labelMissingVerbs = new System.Windows.Forms.Label();
            labelCompletedVerbs = new System.Windows.Forms.Label();
            labelVerbs = new System.Windows.Forms.Label();
            AbecedyPanel.SuspendLayout();
            KanjiPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AbecedyPanel
            // 
            AbecedyPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            AbecedyPanel.Controls.Add(progressBarKatakana);
            AbecedyPanel.Controls.Add(label11);
            AbecedyPanel.Controls.Add(labelMissingKatakanaValue);
            AbecedyPanel.Controls.Add(labelCompletedKatakanaValue);
            AbecedyPanel.Controls.Add(labelMissingKatakana);
            AbecedyPanel.Controls.Add(labelCompletedKatakana);
            AbecedyPanel.Controls.Add(labelKatakana);
            AbecedyPanel.Location = new System.Drawing.Point(0, 0);
            AbecedyPanel.Name = "AbecedyPanel";
            AbecedyPanel.Size = new System.Drawing.Size(1066, 250);
            AbecedyPanel.TabIndex = 4;
            AbecedyPanel.Paint += AbecedyPanel_Paint;
            // 
            // progressBarKatakana
            // 
            progressBarKatakana.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            progressBarKatakana.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            progressBarKatakana.Location = new System.Drawing.Point(23, 169);
            progressBarKatakana.Maximum = 100;
            progressBarKatakana.Name = "progressBarKatakana";
            progressBarKatakana.Size = new System.Drawing.Size(965, 35);
            progressBarKatakana.TabIndex = 14;
            progressBarKatakana.Value = 0;
            progressBarKatakana.Click += progressBar1_Click;
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
            // labelMissingKatakanaValue
            // 
            labelMissingKatakanaValue.AutoSize = true;
            labelMissingKatakanaValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelMissingKatakanaValue.Location = new System.Drawing.Point(156, 117);
            labelMissingKatakanaValue.Name = "labelMissingKatakanaValue";
            labelMissingKatakanaValue.Size = new System.Drawing.Size(45, 28);
            labelMissingKatakanaValue.TabIndex = 9;
            labelMissingKatakanaValue.Text = "100";
            labelMissingKatakanaValue.Click += label6_Click;
            // 
            // labelCompletedKatakanaValue
            // 
            labelCompletedKatakanaValue.AutoSize = true;
            labelCompletedKatakanaValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCompletedKatakanaValue.Location = new System.Drawing.Point(167, 79);
            labelCompletedKatakanaValue.Name = "labelCompletedKatakanaValue";
            labelCompletedKatakanaValue.Size = new System.Drawing.Size(34, 28);
            labelCompletedKatakanaValue.TabIndex = 8;
            labelCompletedKatakanaValue.Text = "50";
            // 
            // labelMissingKatakana
            // 
            labelMissingKatakana.AutoSize = true;
            labelMissingKatakana.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelMissingKatakana.Location = new System.Drawing.Point(23, 117);
            labelMissingKatakana.Name = "labelMissingKatakana";
            labelMissingKatakana.Size = new System.Drawing.Size(118, 28);
            labelMissingKatakana.TabIndex = 7;
            labelMissingKatakana.Text = "Nesplněno:";
            labelMissingKatakana.Click += label4_Click;
            // 
            // labelCompletedKatakana
            // 
            labelCompletedKatakana.AutoSize = true;
            labelCompletedKatakana.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelCompletedKatakana.Location = new System.Drawing.Point(23, 79);
            labelCompletedKatakana.Name = "labelCompletedKatakana";
            labelCompletedKatakana.Size = new System.Drawing.Size(93, 28);
            labelCompletedKatakana.TabIndex = 6;
            labelCompletedKatakana.Text = "Splněno:";
            labelCompletedKatakana.Click += label3_Click;
            // 
            // labelKatakana
            // 
            labelKatakana.AutoSize = true;
            labelKatakana.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelKatakana.Location = new System.Drawing.Point(14, 25);
            labelKatakana.Name = "labelKatakana";
            labelKatakana.Size = new System.Drawing.Size(176, 54);
            labelKatakana.TabIndex = 6;
            labelKatakana.Text = "Abecedy";
            // 
            // progressBarKanji
            // 
            progressBarKanji.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            progressBarKanji.Location = new System.Drawing.Point(23, 158);
            progressBarKanji.Maximum = 100;
            progressBarKanji.Name = "progressBarKanji";
            progressBarKanji.Size = new System.Drawing.Size(965, 35);
            progressBarKanji.TabIndex = 13;
            progressBarKanji.Value = 0;
            progressBarKanji.Click += progressBar2_Click;
            // 
            // progressBarVerbs
            // 
            progressBarVerbs.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            progressBarVerbs.Location = new System.Drawing.Point(23, 164);
            progressBarVerbs.Maximum = 100;
            progressBarVerbs.Name = "progressBarVerbs";
            progressBarVerbs.Size = new System.Drawing.Size(965, 35);
            progressBarVerbs.TabIndex = 13;
            progressBarVerbs.Value = 0;
            progressBarVerbs.Click += progressBar3_Click;
            // 
            // labelKanji
            // 
            labelKanji.AutoSize = true;
            labelKanji.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelKanji.Location = new System.Drawing.Point(14, 13);
            labelKanji.Name = "labelKanji";
            labelKanji.Size = new System.Drawing.Size(109, 54);
            labelKanji.TabIndex = 3;
            labelKanji.Text = "Kanji";
            // 
            // KanjiPanel
            // 
            KanjiPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            KanjiPanel.Controls.Add(progressBarKanji);
            KanjiPanel.Controls.Add(labelMissingKanjiValue);
            KanjiPanel.Controls.Add(labelCompletedKanjiValue);
            KanjiPanel.Controls.Add(labelMissingKanji);
            KanjiPanel.Controls.Add(labelCompletedKanji);
            KanjiPanel.Controls.Add(labelKanji);
            KanjiPanel.Location = new System.Drawing.Point(0, 252);
            KanjiPanel.Name = "KanjiPanel";
            KanjiPanel.Size = new System.Drawing.Size(1066, 250);
            KanjiPanel.TabIndex = 5;
            // 
            // labelMissingKanjiValue
            // 
            labelMissingKanjiValue.AutoSize = true;
            labelMissingKanjiValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelMissingKanjiValue.Location = new System.Drawing.Point(156, 106);
            labelMissingKanjiValue.Name = "labelMissingKanjiValue";
            labelMissingKanjiValue.Size = new System.Drawing.Size(45, 28);
            labelMissingKanjiValue.TabIndex = 12;
            labelMissingKanjiValue.Text = "100";
            // 
            // labelCompletedKanjiValue
            // 
            labelCompletedKanjiValue.AutoSize = true;
            labelCompletedKanjiValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCompletedKanjiValue.Location = new System.Drawing.Point(167, 67);
            labelCompletedKanjiValue.Name = "labelCompletedKanjiValue";
            labelCompletedKanjiValue.Size = new System.Drawing.Size(34, 28);
            labelCompletedKanjiValue.TabIndex = 10;
            labelCompletedKanjiValue.Text = "20";
            // 
            // labelMissingKanji
            // 
            labelMissingKanji.AutoSize = true;
            labelMissingKanji.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelMissingKanji.Location = new System.Drawing.Point(23, 106);
            labelMissingKanji.Name = "labelMissingKanji";
            labelMissingKanji.Size = new System.Drawing.Size(109, 28);
            labelMissingKanji.TabIndex = 11;
            labelMissingKanji.Text = "Neplněno:";
            // 
            // labelCompletedKanji
            // 
            labelCompletedKanji.AutoSize = true;
            labelCompletedKanji.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelCompletedKanji.Location = new System.Drawing.Point(23, 67);
            labelCompletedKanji.Name = "labelCompletedKanji";
            labelCompletedKanji.Size = new System.Drawing.Size(93, 28);
            labelCompletedKanji.TabIndex = 10;
            labelCompletedKanji.Text = "Splněno:";
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(progressBarVerbs);
            panel1.Controls.Add(labelMissingVerbsValue);
            panel1.Controls.Add(labelCompletedVerbsValue);
            panel1.Controls.Add(labelMissingVerbs);
            panel1.Controls.Add(labelCompletedVerbs);
            panel1.Controls.Add(labelVerbs);
            panel1.Location = new System.Drawing.Point(0, 508);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1066, 250);
            panel1.TabIndex = 15;
            // 
            // labelMissingVerbsValue
            // 
            labelMissingVerbsValue.AutoSize = true;
            labelMissingVerbsValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelMissingVerbsValue.Location = new System.Drawing.Point(156, 106);
            labelMissingVerbsValue.Name = "labelMissingVerbsValue";
            labelMissingVerbsValue.Size = new System.Drawing.Size(45, 28);
            labelMissingVerbsValue.TabIndex = 12;
            labelMissingVerbsValue.Text = "100";
            // 
            // labelCompletedVerbsValue
            // 
            labelCompletedVerbsValue.AutoSize = true;
            labelCompletedVerbsValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCompletedVerbsValue.Location = new System.Drawing.Point(167, 67);
            labelCompletedVerbsValue.Name = "labelCompletedVerbsValue";
            labelCompletedVerbsValue.Size = new System.Drawing.Size(34, 28);
            labelCompletedVerbsValue.TabIndex = 10;
            labelCompletedVerbsValue.Text = "90";
            // 
            // labelMissingVerbs
            // 
            labelMissingVerbs.AutoSize = true;
            labelMissingVerbs.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelMissingVerbs.Location = new System.Drawing.Point(23, 106);
            labelMissingVerbs.Name = "labelMissingVerbs";
            labelMissingVerbs.Size = new System.Drawing.Size(109, 28);
            labelMissingVerbs.TabIndex = 11;
            labelMissingVerbs.Text = "Neplněno:";
            // 
            // labelCompletedVerbs
            // 
            labelCompletedVerbs.AutoSize = true;
            labelCompletedVerbs.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelCompletedVerbs.Location = new System.Drawing.Point(23, 67);
            labelCompletedVerbs.Name = "labelCompletedVerbs";
            labelCompletedVerbs.Size = new System.Drawing.Size(93, 28);
            labelCompletedVerbs.TabIndex = 10;
            labelCompletedVerbs.Text = "Splněno:";
            // 
            // labelVerbs
            // 
            labelVerbs.AutoSize = true;
            labelVerbs.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelVerbs.Location = new System.Drawing.Point(14, 13);
            labelVerbs.Name = "labelVerbs";
            labelVerbs.Size = new System.Drawing.Size(154, 54);
            labelVerbs.TabIndex = 3;
            labelVerbs.Text = "Slovesa";
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
            Load += AccountMenu_Load;
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
        private System.Windows.Forms.Label labelKanji;
        private System.Windows.Forms.Panel KanjiPanel;
        private System.Windows.Forms.Label labelKatakana;
        private System.Windows.Forms.Label labelMissingKatakana;
        private System.Windows.Forms.Label labelCompletedKatakana;
        private System.Windows.Forms.Label labelMissingKatakanaValue;
        private System.Windows.Forms.Label labelCompletedKatakanaValue;
        private System.Windows.Forms.Label labelMissingKanji;
        private System.Windows.Forms.Label labelCompletedKanji;
        private System.Windows.Forms.Label labelMissingKanjiValue;
        private System.Windows.Forms.Label labelCompletedKanjiValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMissingVerbsValue;
        private System.Windows.Forms.Label labelCompletedVerbsValue;
        private System.Windows.Forms.Label labelMissingVerbs;
        private System.Windows.Forms.Label labelCompletedVerbs;
        private System.Windows.Forms.Label labelVerbs;
        private TransparentProgressBar progressBarKatakana;
        private TransparentProgressBar progressBarKanji;
        private TransparentProgressBar progressBarVerbs;
    }
}