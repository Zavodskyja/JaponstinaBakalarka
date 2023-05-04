
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
            panel3 = new System.Windows.Forms.Panel();
            labelNesplnenoValue = new System.Windows.Forms.Label();
            labelSplnenoValue = new System.Windows.Forms.Label();
            labelNesplneno = new System.Windows.Forms.Label();
            labelSplneno = new System.Windows.Forms.Label();
            progressBarCircle = new CircularProgressBar2();
            ItemList = new System.Windows.Forms.CheckedListBox();
            panel7 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            labelDetail = new System.Windows.Forms.Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(252, 201, 185);
            panel3.Controls.Add(labelNesplnenoValue);
            panel3.Controls.Add(labelSplnenoValue);
            panel3.Controls.Add(labelNesplneno);
            panel3.Controls.Add(labelSplneno);
            panel3.Controls.Add(progressBarCircle);
            panel3.Controls.Add(ItemList);
            panel3.Controls.Add(panel7);
            panel3.Location = new System.Drawing.Point(0, 54);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1066, 676);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // labelNesplnenoValue
            // 
            labelNesplnenoValue.AutoSize = true;
            labelNesplnenoValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelNesplnenoValue.Location = new System.Drawing.Point(404, 119);
            labelNesplnenoValue.Name = "labelNesplnenoValue";
            labelNesplnenoValue.Size = new System.Drawing.Size(32, 37);
            labelNesplnenoValue.TabIndex = 8;
            labelNesplnenoValue.Text = "5";
            // 
            // labelSplnenoValue
            // 
            labelSplnenoValue.AutoSize = true;
            labelSplnenoValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSplnenoValue.Location = new System.Drawing.Point(404, 46);
            labelSplnenoValue.Name = "labelSplnenoValue";
            labelSplnenoValue.Size = new System.Drawing.Size(32, 37);
            labelSplnenoValue.TabIndex = 7;
            labelSplnenoValue.Text = "1";
            // 
            // labelNesplneno
            // 
            labelNesplneno.AutoSize = true;
            labelNesplneno.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelNesplneno.Location = new System.Drawing.Point(218, 119);
            labelNesplneno.Name = "labelNesplneno";
            labelNesplneno.Size = new System.Drawing.Size(151, 37);
            labelNesplneno.TabIndex = 6;
            labelNesplneno.Text = "Nesplněno:";
            // 
            // labelSplneno
            // 
            labelSplneno.AutoSize = true;
            labelSplneno.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSplneno.Location = new System.Drawing.Point(218, 46);
            labelSplneno.Name = "labelSplneno";
            labelSplneno.Size = new System.Drawing.Size(120, 37);
            labelSplneno.TabIndex = 5;
            labelSplneno.Text = "Splněno:";
            // 
            // progressBarCircle
            // 
            progressBarCircle.BackColor = System.Drawing.Color.FromArgb(195, 39, 43);
            progressBarCircle.ForeColor = System.Drawing.Color.FromArgb(165, 186, 147);
            progressBarCircle.Location = new System.Drawing.Point(12, 46);
            progressBarCircle.Maximum = 100;
            progressBarCircle.Name = "progressBarCircle";
            progressBarCircle.Size = new System.Drawing.Size(200, 200);
            progressBarCircle.TabIndex = 3;
            progressBarCircle.Value = 40;
            // 
            // ItemList
            // 
            ItemList.BackColor = System.Drawing.Color.FromArgb(252, 201, 185);
            ItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            ItemList.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ItemList.ForeColor = System.Drawing.Color.Black;
            ItemList.FormattingEnabled = true;
            ItemList.HorizontalScrollbar = true;
            ItemList.Location = new System.Drawing.Point(0, 293);
            ItemList.MultiColumn = true;
            ItemList.Name = "ItemList";
            ItemList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            ItemList.Size = new System.Drawing.Size(1040, 380);
            ItemList.TabIndex = 0;
            ItemList.TabStop = false;
            ItemList.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged_1;
            //ItemList.ColumnWidth = 150;
            // 
            // panel7
            // 
            panel7.Location = new System.Drawing.Point(12, 46);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(200, 200);
            panel7.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(252, 201, 185);
            panel1.Controls.Add(labelDetail);
            panel1.Controls.Add(panel3);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1066, 730);
            panel1.TabIndex = 0;
            // 
            // labelDetail
            // 
            labelDetail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelDetail.ForeColor = System.Drawing.Color.FromArgb(120, 119, 155);
            labelDetail.Location = new System.Drawing.Point(0, 0);
            labelDetail.Name = "labelDetail";
            labelDetail.Size = new System.Drawing.Size(1066, 57);
            labelDetail.TabIndex = 4;
            labelDetail.Text = "Hiragana";
            labelDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.CheckedListBox ItemList;
        private System.Windows.Forms.Label labelDetail;
        private CircularProgressBar2 progressBarCircle;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelNesplnenoValue;
        private System.Windows.Forms.Label labelSplnenoValue;
        private System.Windows.Forms.Label labelNesplneno;
        private System.Windows.Forms.Label labelSplneno;
    }
}