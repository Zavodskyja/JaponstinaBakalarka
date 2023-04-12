
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
            panel1 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            CheckBoxTimed = new System.Windows.Forms.CheckBox();
            CheckBoxIrregular = new System.Windows.Forms.CheckBox();
            CheckBoxGodan = new System.Windows.Forms.CheckBox();
            CheckBoxIchidan = new System.Windows.Forms.CheckBox();
            button3 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            CheckBoxN4 = new System.Windows.Forms.CheckBox();
            CheckBoxN5 = new System.Windows.Forms.CheckBox();
            CheckBoxKatakana = new System.Windows.Forms.CheckBox();
            CheckBoxHiragana = new System.Windows.Forms.CheckBox();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(252, 201, 185);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(CheckBoxTimed);
            panel1.Controls.Add(CheckBoxIrregular);
            panel1.Controls.Add(CheckBoxGodan);
            panel1.Controls.Add(CheckBoxIchidan);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CheckBoxN4);
            panel1.Controls.Add(CheckBoxN5);
            panel1.Controls.Add(CheckBoxKatakana);
            panel1.Controls.Add(CheckBoxHiragana);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1066, 768);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(435, 567);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(190, 15);
            label4.TabIndex = 14;
            label4.Text = "Je potřeba vybrat alespoň 1 cvičení";
            label4.Visible = false;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(353, 585);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(361, 36);
            button4.TabIndex = 13;
            button4.Text = "Kombinace";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(455, 709);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(170, 19);
            label3.TabIndex = 12;
            label3.Text = "Časový limit odpovědi 10s";
            // 
            // CheckBoxTimed
            // 
            CheckBoxTimed.AutoSize = true;
            CheckBoxTimed.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CheckBoxTimed.Location = new System.Drawing.Point(455, 658);
            CheckBoxTimed.Name = "CheckBoxTimed";
            CheckBoxTimed.Size = new System.Drawing.Size(172, 32);
            CheckBoxTimed.TabIndex = 11;
            CheckBoxTimed.Text = "Časové omezení";
            CheckBoxTimed.UseVisualStyleBackColor = true;
            CheckBoxTimed.CheckedChanged += checkBox8_CheckedChanged;
            // 
            // CheckBoxIrregular
            // 
            CheckBoxIrregular.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CheckBoxIrregular.Location = new System.Drawing.Point(746, 464);
            CheckBoxIrregular.Name = "CheckBoxIrregular";
            CheckBoxIrregular.Size = new System.Drawing.Size(150, 40);
            CheckBoxIrregular.TabIndex = 10;
            CheckBoxIrregular.Text = "Nepravidelná";
            CheckBoxIrregular.UseVisualStyleBackColor = true;
            CheckBoxIrregular.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // CheckBoxGodan
            // 
            CheckBoxGodan.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CheckBoxGodan.Location = new System.Drawing.Point(746, 418);
            CheckBoxGodan.Name = "CheckBoxGodan";
            CheckBoxGodan.Size = new System.Drawing.Size(150, 40);
            CheckBoxGodan.TabIndex = 9;
            CheckBoxGodan.Text = "U - Godan";
            CheckBoxGodan.UseVisualStyleBackColor = true;
            CheckBoxGodan.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // CheckBoxIchidan
            // 
            CheckBoxIchidan.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CheckBoxIchidan.Location = new System.Drawing.Point(746, 372);
            CheckBoxIchidan.Name = "CheckBoxIchidan";
            CheckBoxIchidan.Size = new System.Drawing.Size(150, 40);
            CheckBoxIchidan.TabIndex = 8;
            CheckBoxIchidan.Text = "RU - Ichidan";
            CheckBoxIchidan.UseVisualStyleBackColor = true;
            CheckBoxIchidan.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(746, 300);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(150, 40);
            button3.TabIndex = 3;
            button3.Text = "Slovesa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(217, 238);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(605, 15);
            label2.TabIndex = 7;
            label2.Text = "Kliknutím na tlačítko spustíte výuku. Pomocí checkboxů můžete specifikovat části výuky ( defaultně výběr všeho )";
            // 
            // CheckBoxN4
            // 
            CheckBoxN4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CheckBoxN4.Location = new System.Drawing.Point(455, 418);
            CheckBoxN4.Name = "CheckBoxN4";
            CheckBoxN4.Size = new System.Drawing.Size(150, 40);
            CheckBoxN4.TabIndex = 7;
            CheckBoxN4.Text = "N4";
            CheckBoxN4.UseVisualStyleBackColor = true;
            CheckBoxN4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // CheckBoxN5
            // 
            CheckBoxN5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CheckBoxN5.Location = new System.Drawing.Point(455, 372);
            CheckBoxN5.Name = "CheckBoxN5";
            CheckBoxN5.Size = new System.Drawing.Size(150, 40);
            CheckBoxN5.TabIndex = 6;
            CheckBoxN5.Text = "N5";
            CheckBoxN5.UseVisualStyleBackColor = true;
            CheckBoxN5.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // CheckBoxKatakana
            // 
            CheckBoxKatakana.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CheckBoxKatakana.Location = new System.Drawing.Point(165, 418);
            CheckBoxKatakana.Name = "CheckBoxKatakana";
            CheckBoxKatakana.Size = new System.Drawing.Size(150, 40);
            CheckBoxKatakana.TabIndex = 5;
            CheckBoxKatakana.Text = "Katakana";
            CheckBoxKatakana.UseVisualStyleBackColor = true;
            CheckBoxKatakana.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // CheckBoxHiragana
            // 
            CheckBoxHiragana.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CheckBoxHiragana.Location = new System.Drawing.Point(165, 372);
            CheckBoxHiragana.Name = "CheckBoxHiragana";
            CheckBoxHiragana.Size = new System.Drawing.Size(150, 40);
            CheckBoxHiragana.TabIndex = 4;
            CheckBoxHiragana.Text = "Hiragana";
            CheckBoxHiragana.UseVisualStyleBackColor = true;
            CheckBoxHiragana.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(455, 300);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(150, 40);
            button2.TabIndex = 2;
            button2.Text = "Kanji";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(165, 300);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(150, 40);
            button1.TabIndex = 1;
            button1.Text = "Abecedy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(353, 132);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(361, 106);
            label1.TabIndex = 0;
            label1.Text = "Výběr cvičení";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cviceni_vyber
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1500, 926);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Cviceni_vyber";
            Text = "Cviceni_vyber";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
    }
}