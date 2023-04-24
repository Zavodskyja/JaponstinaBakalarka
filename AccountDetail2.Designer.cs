namespace Japonstina
{
    partial class AccountDetail2
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
            panel3 = new System.Windows.Forms.Panel();
            progressBar3 = new TransparentProgressBar();
            labelBotMissingNumber = new System.Windows.Forms.Label();
            labelBotCompleteNumber = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            labelBot = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            progressBar2 = new TransparentProgressBar();
            labelMidMissingNumber = new System.Windows.Forms.Label();
            labelMidCompleteNumber = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            labelMid = new System.Windows.Forms.Label();
            AbecedyPanel = new System.Windows.Forms.Panel();
            progressBar1 = new TransparentProgressBar();
            label11 = new System.Windows.Forms.Label();
            labelTopMissingNumber = new System.Windows.Forms.Label();
            labelTopCompleteNumber = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            labelTop = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            AbecedyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(252, 201, 185);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(AbecedyPanel);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1066, 768);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel3.Controls.Add(progressBar3);
            panel3.Controls.Add(labelBotMissingNumber);
            panel3.Controls.Add(labelBotCompleteNumber);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(labelBot);
            panel3.Location = new System.Drawing.Point(0, 508);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1066, 250);
            panel3.TabIndex = 16;
            // 
            // progressBar3
            // 
            progressBar3.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            progressBar3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            progressBar3.Location = new System.Drawing.Point(23, 169);
            progressBar3.Maximum = 100;
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new System.Drawing.Size(965, 35);
            progressBar3.TabIndex = 14;
            progressBar3.Value = 100;
            progressBar3.Click += transparentProgressBar2_Click;
            // 
            // labelBotMissingNumber
            // 
            labelBotMissingNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelBotMissingNumber.Location = new System.Drawing.Point(156, 117);
            labelBotMissingNumber.Name = "labelBotMissingNumber";
            labelBotMissingNumber.Size = new System.Drawing.Size(50, 30);
            labelBotMissingNumber.TabIndex = 9;
            labelBotMissingNumber.Text = "100";
            labelBotMissingNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBotCompleteNumber
            // 
            labelBotCompleteNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelBotCompleteNumber.Location = new System.Drawing.Point(156, 79);
            labelBotCompleteNumber.Name = "labelBotCompleteNumber";
            labelBotCompleteNumber.Size = new System.Drawing.Size(50, 30);
            labelBotCompleteNumber.TabIndex = 8;
            labelBotCompleteNumber.Text = "50";
            labelBotCompleteNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label16.Location = new System.Drawing.Point(23, 117);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(118, 28);
            label16.TabIndex = 7;
            label16.Text = "Nesplněno:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label17.Location = new System.Drawing.Point(23, 79);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(93, 28);
            label17.TabIndex = 6;
            label17.Text = "Splněno:";
            // 
            // labelBot
            // 
            labelBot.AutoSize = true;
            labelBot.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelBot.Location = new System.Drawing.Point(14, 25);
            labelBot.Name = "labelBot";
            labelBot.Size = new System.Drawing.Size(259, 54);
            labelBot.TabIndex = 6;
            labelBot.Text = "Nepravidelná";
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel2.Controls.Add(progressBar2);
            panel2.Controls.Add(labelMidMissingNumber);
            panel2.Controls.Add(labelMidCompleteNumber);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(labelMid);
            panel2.Location = new System.Drawing.Point(0, 252);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1066, 250);
            panel2.TabIndex = 15;
            // 
            // progressBar2
            // 
            progressBar2.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            progressBar2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            progressBar2.Location = new System.Drawing.Point(23, 169);
            progressBar2.Maximum = 100;
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new System.Drawing.Size(965, 35);
            progressBar2.TabIndex = 14;
            progressBar2.Value = 100;
            progressBar2.Click += transparentProgressBar1_Click;
            // 
            // labelMidMissingNumber
            // 
            labelMidMissingNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelMidMissingNumber.Location = new System.Drawing.Point(156, 117);
            labelMidMissingNumber.Name = "labelMidMissingNumber";
            labelMidMissingNumber.Size = new System.Drawing.Size(50, 30);
            labelMidMissingNumber.TabIndex = 9;
            labelMidMissingNumber.Text = "100";
            labelMidMissingNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMidCompleteNumber
            // 
            labelMidCompleteNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelMidCompleteNumber.Location = new System.Drawing.Point(156, 77);
            labelMidCompleteNumber.Name = "labelMidCompleteNumber";
            labelMidCompleteNumber.Size = new System.Drawing.Size(50, 30);
            labelMidCompleteNumber.TabIndex = 8;
            labelMidCompleteNumber.Text = "50";
            labelMidCompleteNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(23, 117);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(118, 28);
            label10.TabIndex = 7;
            label10.Text = "Nesplněno:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(23, 79);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(93, 28);
            label12.TabIndex = 6;
            label12.Text = "Splněno:";
            // 
            // labelMid
            // 
            labelMid.AutoSize = true;
            labelMid.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelMid.Location = new System.Drawing.Point(14, 25);
            labelMid.Name = "labelMid";
            labelMid.Size = new System.Drawing.Size(215, 54);
            labelMid.TabIndex = 6;
            labelMid.Text = "U - slovesa";
            // 
            // AbecedyPanel
            // 
            AbecedyPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            AbecedyPanel.Controls.Add(progressBar1);
            AbecedyPanel.Controls.Add(label11);
            AbecedyPanel.Controls.Add(labelTopMissingNumber);
            AbecedyPanel.Controls.Add(labelTopCompleteNumber);
            AbecedyPanel.Controls.Add(label4);
            AbecedyPanel.Controls.Add(label1);
            AbecedyPanel.Controls.Add(labelTop);
            AbecedyPanel.Location = new System.Drawing.Point(0, 0);
            AbecedyPanel.Name = "AbecedyPanel";
            AbecedyPanel.Size = new System.Drawing.Size(1066, 250);
            AbecedyPanel.TabIndex = 5;
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
            progressBar1.Value = 100;
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
            // 
            // labelTopMissingNumber
            // 
            labelTopMissingNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTopMissingNumber.Location = new System.Drawing.Point(156, 117);
            labelTopMissingNumber.Name = "labelTopMissingNumber";
            labelTopMissingNumber.Size = new System.Drawing.Size(50, 30);
            labelTopMissingNumber.TabIndex = 9;
            labelTopMissingNumber.Text = "100";
            labelTopMissingNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTopCompleteNumber
            // 
            labelTopCompleteNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTopCompleteNumber.Location = new System.Drawing.Point(156, 78);
            labelTopCompleteNumber.Name = "labelTopCompleteNumber";
            labelTopCompleteNumber.Size = new System.Drawing.Size(50, 30);
            labelTopCompleteNumber.TabIndex = 8;
            labelTopCompleteNumber.Text = "50";
            labelTopCompleteNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(23, 79);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 28);
            label1.TabIndex = 6;
            label1.Text = "Splněno:";
            // 
            // labelTop
            // 
            labelTop.AutoSize = true;
            labelTop.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTop.Location = new System.Drawing.Point(14, 25);
            labelTop.Name = "labelTop";
            labelTop.Size = new System.Drawing.Size(239, 54);
            labelTop.TabIndex = 6;
            labelTop.Text = "RU - slovesa";
            labelTop.Click += label2_Click;
            // 
            // AccountDetail2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1333, 855);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "AccountDetail2";
            Text = "AccountDetail2";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            AbecedyPanel.ResumeLayout(false);
            AbecedyPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel AbecedyPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        public TransparentProgressBar progressBar2;
        public TransparentProgressBar progressBar1;
        public TransparentProgressBar progressBar3;
        public System.Windows.Forms.Label labelMidMissingNumber;
        public System.Windows.Forms.Label labelMidCompleteNumber;
        public System.Windows.Forms.Label labelMid;
        public System.Windows.Forms.Label labelTopMissingNumber;
        public System.Windows.Forms.Label labelTopCompleteNumber;
        public System.Windows.Forms.Label labelTop;
        public System.Windows.Forms.Label labelBot;
        public System.Windows.Forms.Label labelBotMissingNumber;
        public System.Windows.Forms.Label labelBotCompleteNumber;
        public System.Windows.Forms.Panel panel3;
    }
}