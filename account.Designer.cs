
namespace Japonstina
{
    partial class account
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
        public void InitializeComponent()
        {
            KatakanaList = new System.Windows.Forms.CheckedListBox();
            panel3 = new System.Windows.Forms.Panel();
            HiraganaProgressBar = new CircularProgressBar2();
            label4 = new System.Windows.Forms.Label();
            HiraganaList = new System.Windows.Forms.CheckedListBox();
            panel5 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel7 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            KatakanaProgressBar = new CircularProgressBar2();
            label5 = new System.Windows.Forms.Label();
            panel6 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // KatakanaList
            // 
            KatakanaList.BackColor = System.Drawing.Color.FromArgb(165, 186, 147);
            KatakanaList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            KatakanaList.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            KatakanaList.ForeColor = System.Drawing.Color.White;
            KatakanaList.FormattingEnabled = true;
            KatakanaList.Location = new System.Drawing.Point(0, 334);
            KatakanaList.MaximumSize = new System.Drawing.Size(508, 342);
            KatakanaList.MultiColumn = true;
            KatakanaList.Name = "KatakanaList";
            KatakanaList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            KatakanaList.ScrollAlwaysVisible = true;
            KatakanaList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            KatakanaList.Size = new System.Drawing.Size(508, 342);
            KatakanaList.TabIndex = 0;
            KatakanaList.SelectedIndexChanged += KatakanaList_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(165, 186, 147);
            panel3.Controls.Add(HiraganaProgressBar);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(HiraganaList);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel7);
            panel3.Location = new System.Drawing.Point(0, 54);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(508, 711);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // HiraganaProgressBar
            // 
            HiraganaProgressBar.BackColor = System.Drawing.Color.Transparent;
            HiraganaProgressBar.ForeColor = System.Drawing.Color.FromArgb(120, 119, 155);
            HiraganaProgressBar.Location = new System.Drawing.Point(132, 46);
            HiraganaProgressBar.Maximum = 100;
            HiraganaProgressBar.Name = "HiraganaProgressBar";
            HiraganaProgressBar.Size = new System.Drawing.Size(200, 200);
            HiraganaProgressBar.TabIndex = 3;
            HiraganaProgressBar.Value = 100;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(102, 288);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(200, 43);
            label4.TabIndex = 2;
            label4.Text = "Detailní pohled";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HiraganaList
            // 
            HiraganaList.BackColor = System.Drawing.Color.FromArgb(165, 186, 147);
            HiraganaList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            HiraganaList.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            HiraganaList.ForeColor = System.Drawing.Color.White;
            HiraganaList.FormattingEnabled = true;
            HiraganaList.Location = new System.Drawing.Point(0, 334);
            HiraganaList.MaximumSize = new System.Drawing.Size(508, 342);
            HiraganaList.MultiColumn = true;
            HiraganaList.Name = "HiraganaList";
            HiraganaList.ScrollAlwaysVisible = true;
            HiraganaList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            HiraganaList.Size = new System.Drawing.Size(508, 342);
            HiraganaList.TabIndex = 0;
            HiraganaList.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Dock = System.Windows.Forms.DockStyle.Top;
            panel5.Location = new System.Drawing.Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(508, 40);
            panel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(132, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(200, 37);
            label1.TabIndex = 0;
            label1.Text = "Hiragana";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.Location = new System.Drawing.Point(132, 46);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(200, 200);
            panel7.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(165, 186, 147);
            panel4.Controls.Add(KatakanaProgressBar);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(KatakanaList);
            panel4.Controls.Add(panel2);
            panel4.Location = new System.Drawing.Point(558, 54);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(508, 711);
            panel4.TabIndex = 3;
            // 
            // KatakanaProgressBar
            // 
            KatakanaProgressBar.BackColor = System.Drawing.Color.Transparent;
            KatakanaProgressBar.ForeColor = System.Drawing.Color.FromArgb(120, 119, 155);
            KatakanaProgressBar.Location = new System.Drawing.Point(147, 46);
            KatakanaProgressBar.Maximum = 100;
            KatakanaProgressBar.Name = "KatakanaProgressBar";
            KatakanaProgressBar.Size = new System.Drawing.Size(200, 200);
            KatakanaProgressBar.TabIndex = 4;
            KatakanaProgressBar.Value = 40;
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(147, 288);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(200, 43);
            label5.TabIndex = 3;
            label5.Text = "Detailní pohled";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.Controls.Add(label2);
            panel6.Dock = System.Windows.Forms.DockStyle.Top;
            panel6.Location = new System.Drawing.Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(508, 40);
            panel6.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(147, 3);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(200, 37);
            label2.TabIndex = 1;
            label2.Text = "Katakana";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Location = new System.Drawing.Point(147, 43);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(200, 203);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(252, 201, 185);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1066, 730);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(1066, 57);
            label3.TabIndex = 4;
            label3.Text = "Progres Hiragany a Katakany";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // account
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1536, 991);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "account";
            Text = "account";
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.CheckedListBox KatakanaList;
        public System.Windows.Forms.CheckedListBox HiraganaList;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CircularProgressBar2 HiraganaProgressBar;
        private CircularProgressBar2 KatakanaProgressBar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
    }
}