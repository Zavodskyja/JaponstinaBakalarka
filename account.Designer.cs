
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
            this.KatakanaList = new System.Windows.Forms.CheckedListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.HiraganaList = new System.Windows.Forms.CheckedListBox();
            this.HiraganaGraf = new CircularProgressBar.CircularProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.KatakanaGraf = new CircularProgressBar.CircularProgressBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KatakanaList
            // 
            this.KatakanaList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(119)))), ((int)(((byte)(155)))));
            this.KatakanaList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KatakanaList.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KatakanaList.ForeColor = System.Drawing.Color.White;
            this.KatakanaList.FormattingEnabled = true;
            this.KatakanaList.Location = new System.Drawing.Point(0, 334);
            this.KatakanaList.MaximumSize = new System.Drawing.Size(508, 342);
            this.KatakanaList.MultiColumn = true;
            this.KatakanaList.Name = "KatakanaList";
            this.KatakanaList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.KatakanaList.ScrollAlwaysVisible = true;
            this.KatakanaList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.KatakanaList.Size = new System.Drawing.Size(508, 342);
            this.KatakanaList.TabIndex = 0;
            this.KatakanaList.SelectedIndexChanged += new System.EventHandler(this.KatakanaList_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(186)))), ((int)(((byte)(147)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.HiraganaList);
            this.panel3.Controls.Add(this.HiraganaGraf);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 711);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 43);
            this.label4.TabIndex = 2;
            this.label4.Text = "Detailní pohled";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HiraganaList
            // 
            this.HiraganaList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(186)))), ((int)(((byte)(147)))));
            this.HiraganaList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HiraganaList.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HiraganaList.ForeColor = System.Drawing.Color.White;
            this.HiraganaList.FormattingEnabled = true;
            this.HiraganaList.Location = new System.Drawing.Point(0, 334);
            this.HiraganaList.MaximumSize = new System.Drawing.Size(508, 342);
            this.HiraganaList.MultiColumn = true;
            this.HiraganaList.Name = "HiraganaList";
            this.HiraganaList.ScrollAlwaysVisible = true;
            this.HiraganaList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.HiraganaList.Size = new System.Drawing.Size(508, 342);
            this.HiraganaList.TabIndex = 0;
            this.HiraganaList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
            // 
            // HiraganaGraf
            // 
            this.HiraganaGraf.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.HiraganaGraf.AnimationSpeed = 500;
            this.HiraganaGraf.BackColor = System.Drawing.Color.Transparent;
            this.HiraganaGraf.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HiraganaGraf.ForeColor = System.Drawing.Color.White;
            this.HiraganaGraf.InnerColor = System.Drawing.Color.Transparent;
            this.HiraganaGraf.InnerMargin = 0;
            this.HiraganaGraf.InnerWidth = -1;
            this.HiraganaGraf.Location = new System.Drawing.Point(102, 46);
            this.HiraganaGraf.MarqueeAnimationSpeed = 2000;
            this.HiraganaGraf.Name = "HiraganaGraf";
            this.HiraganaGraf.OuterColor = System.Drawing.Color.DimGray;
            this.HiraganaGraf.OuterMargin = -25;
            this.HiraganaGraf.OuterWidth = 26;
            this.HiraganaGraf.ProgressColor = System.Drawing.Color.Salmon;
            this.HiraganaGraf.ProgressWidth = 25;
            this.HiraganaGraf.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HiraganaGraf.Size = new System.Drawing.Size(200, 200);
            this.HiraganaGraf.StartAngle = 270;
            this.HiraganaGraf.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HiraganaGraf.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.HiraganaGraf.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.HiraganaGraf.SubscriptText = "";
            this.HiraganaGraf.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.HiraganaGraf.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.HiraganaGraf.SuperscriptText = "";
            this.HiraganaGraf.TabIndex = 1;
            this.HiraganaGraf.Text = "1";
            this.HiraganaGraf.TextMargin = new System.Windows.Forms.Padding(0);
            this.HiraganaGraf.Value = 1;
            this.HiraganaGraf.Click += new System.EventHandler(this.bar_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(508, 40);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiragana";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(119)))), ((int)(((byte)(155)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.KatakanaGraf);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.KatakanaList);
            this.panel4.Location = new System.Drawing.Point(558, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(508, 711);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(147, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 43);
            this.label5.TabIndex = 3;
            this.label5.Text = "Detailní pohled";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KatakanaGraf
            // 
            this.KatakanaGraf.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.KatakanaGraf.AnimationSpeed = 500;
            this.KatakanaGraf.BackColor = System.Drawing.Color.Transparent;
            this.KatakanaGraf.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KatakanaGraf.ForeColor = System.Drawing.Color.White;
            this.KatakanaGraf.InnerColor = System.Drawing.Color.Transparent;
            this.KatakanaGraf.InnerMargin = 2;
            this.KatakanaGraf.InnerWidth = -1;
            this.KatakanaGraf.Location = new System.Drawing.Point(147, 46);
            this.KatakanaGraf.MarqueeAnimationSpeed = 2000;
            this.KatakanaGraf.Name = "KatakanaGraf";
            this.KatakanaGraf.OuterColor = System.Drawing.Color.DimGray;
            this.KatakanaGraf.OuterMargin = -25;
            this.KatakanaGraf.OuterWidth = 26;
            this.KatakanaGraf.ProgressColor = System.Drawing.Color.Salmon;
            this.KatakanaGraf.ProgressWidth = 25;
            this.KatakanaGraf.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KatakanaGraf.Size = new System.Drawing.Size(200, 200);
            this.KatakanaGraf.StartAngle = 270;
            this.KatakanaGraf.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.KatakanaGraf.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.KatakanaGraf.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.KatakanaGraf.SubscriptText = "";
            this.KatakanaGraf.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.KatakanaGraf.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.KatakanaGraf.SuperscriptText = "";
            this.KatakanaGraf.TabIndex = 1;
            this.KatakanaGraf.Text = "20";
            this.KatakanaGraf.TextMargin = new System.Windows.Forms.Padding(0);
            this.KatakanaGraf.Value = 68;
            this.KatakanaGraf.Click += new System.EventHandler(this.KatakanaGraf_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(508, 40);
            this.panel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(147, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Katakana";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(201)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 730);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1066, 57);
            this.label3.TabIndex = 4;
            this.label3.Text = "Progres Hiragany a Katakany";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 991);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "account";
            this.Text = "account";
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel3;
        public CircularProgressBar.CircularProgressBar HiraganaGraf;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel4;
        public CircularProgressBar.CircularProgressBar KatakanaGraf;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.CheckedListBox KatakanaList;
        public System.Windows.Forms.CheckedListBox HiraganaList;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}