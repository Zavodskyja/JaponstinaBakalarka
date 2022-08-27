
namespace Japonstina
{
    partial class Cviceni_vyber
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBoxTimed = new System.Windows.Forms.CheckBox();
            this.CheckBoxIrregular = new System.Windows.Forms.CheckBox();
            this.CheckBoxGodan = new System.Windows.Forms.CheckBox();
            this.CheckBoxIchidan = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckBoxN4 = new System.Windows.Forms.CheckBox();
            this.CheckBoxN5 = new System.Windows.Forms.CheckBox();
            this.CheckBoxKatakana = new System.Windows.Forms.CheckBox();
            this.CheckBoxHiragana = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(201)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CheckBoxTimed);
            this.panel1.Controls.Add(this.CheckBoxIrregular);
            this.panel1.Controls.Add(this.CheckBoxGodan);
            this.panel1.Controls.Add(this.CheckBoxIchidan);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CheckBoxN4);
            this.panel1.Controls.Add(this.CheckBoxN5);
            this.panel1.Controls.Add(this.CheckBoxKatakana);
            this.panel1.Controls.Add(this.CheckBoxHiragana);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 768);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(353, 585);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(361, 36);
            this.button4.TabIndex = 13;
            this.button4.Text = "Kombinace - TODO";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(455, 709);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Časový limit odpovědi 10s";
            // 
            // CheckBoxTimed
            // 
            this.CheckBoxTimed.AutoSize = true;
            this.CheckBoxTimed.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxTimed.Location = new System.Drawing.Point(455, 658);
            this.CheckBoxTimed.Name = "CheckBoxTimed";
            this.CheckBoxTimed.Size = new System.Drawing.Size(172, 32);
            this.CheckBoxTimed.TabIndex = 11;
            this.CheckBoxTimed.Text = "Časové omezení";
            this.CheckBoxTimed.UseVisualStyleBackColor = true;
            this.CheckBoxTimed.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // CheckBoxIrregular
            // 
            this.CheckBoxIrregular.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxIrregular.Location = new System.Drawing.Point(746, 464);
            this.CheckBoxIrregular.Name = "CheckBoxIrregular";
            this.CheckBoxIrregular.Size = new System.Drawing.Size(150, 40);
            this.CheckBoxIrregular.TabIndex = 10;
            this.CheckBoxIrregular.Text = "Irregular";
            this.CheckBoxIrregular.UseVisualStyleBackColor = true;
            this.CheckBoxIrregular.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // CheckBoxGodan
            // 
            this.CheckBoxGodan.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxGodan.Location = new System.Drawing.Point(746, 418);
            this.CheckBoxGodan.Name = "CheckBoxGodan";
            this.CheckBoxGodan.Size = new System.Drawing.Size(150, 40);
            this.CheckBoxGodan.TabIndex = 9;
            this.CheckBoxGodan.Text = "U - Godan";
            this.CheckBoxGodan.UseVisualStyleBackColor = true;
            this.CheckBoxGodan.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // CheckBoxIchidan
            // 
            this.CheckBoxIchidan.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxIchidan.Location = new System.Drawing.Point(746, 372);
            this.CheckBoxIchidan.Name = "CheckBoxIchidan";
            this.CheckBoxIchidan.Size = new System.Drawing.Size(150, 40);
            this.CheckBoxIchidan.TabIndex = 8;
            this.CheckBoxIchidan.Text = "RU -Ichidan";
            this.CheckBoxIchidan.UseVisualStyleBackColor = true;
            this.CheckBoxIchidan.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(746, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Slovesa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kliknutím na tlačítko spustíte výuku. Pomocí checkboxů můžete specifikovat části " +
    "výuky ( defaultně výběr všeho )";
            // 
            // CheckBoxN4
            // 
            this.CheckBoxN4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxN4.Location = new System.Drawing.Point(455, 418);
            this.CheckBoxN4.Name = "CheckBoxN4";
            this.CheckBoxN4.Size = new System.Drawing.Size(150, 40);
            this.CheckBoxN4.TabIndex = 7;
            this.CheckBoxN4.Text = "N4";
            this.CheckBoxN4.UseVisualStyleBackColor = true;
            this.CheckBoxN4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // CheckBoxN5
            // 
            this.CheckBoxN5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxN5.Location = new System.Drawing.Point(455, 372);
            this.CheckBoxN5.Name = "CheckBoxN5";
            this.CheckBoxN5.Size = new System.Drawing.Size(150, 40);
            this.CheckBoxN5.TabIndex = 6;
            this.CheckBoxN5.Text = "N5";
            this.CheckBoxN5.UseVisualStyleBackColor = true;
            this.CheckBoxN5.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // CheckBoxKatakana
            // 
            this.CheckBoxKatakana.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxKatakana.Location = new System.Drawing.Point(165, 418);
            this.CheckBoxKatakana.Name = "CheckBoxKatakana";
            this.CheckBoxKatakana.Size = new System.Drawing.Size(150, 40);
            this.CheckBoxKatakana.TabIndex = 5;
            this.CheckBoxKatakana.Text = "Katakana";
            this.CheckBoxKatakana.UseVisualStyleBackColor = true;
            this.CheckBoxKatakana.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // CheckBoxHiragana
            // 
            this.CheckBoxHiragana.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxHiragana.Location = new System.Drawing.Point(165, 372);
            this.CheckBoxHiragana.Name = "CheckBoxHiragana";
            this.CheckBoxHiragana.Size = new System.Drawing.Size(150, 40);
            this.CheckBoxHiragana.TabIndex = 4;
            this.CheckBoxHiragana.Text = "Hiragana";
            this.CheckBoxHiragana.UseVisualStyleBackColor = true;
            this.CheckBoxHiragana.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kanji";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Abecedy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(353, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Výběr cvičení";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cviceni_vyber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 926);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cviceni_vyber";
            this.Text = "Cviceni_vyber";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CheckBoxN4;
        private System.Windows.Forms.CheckBox CheckBoxN5;
        private System.Windows.Forms.CheckBox CheckBoxKatakana;
        private System.Windows.Forms.CheckBox CheckBoxHiragana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox CheckBoxIrregular;
        private System.Windows.Forms.CheckBox CheckBoxGodan;
        private System.Windows.Forms.CheckBox CheckBoxIchidan;
        private System.Windows.Forms.CheckBox CheckBoxTimed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
    }
}