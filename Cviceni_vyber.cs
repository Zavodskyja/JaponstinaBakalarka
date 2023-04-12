using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Japonstina.models;



namespace Japonstina
{
    public partial class Cviceni_vyber : Form
    {
        public Cviceni_vyber()
        {
            InitializeComponent();

        }


        public static VyberCviceni Vyber { get; set; }

        public static List<String> CheckBoxSelected { get; set; }

        public static bool CheckBoxTimeLimit { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            CheckBoxSelected = CheckBoxSelected = new List<string> { "Hiragana", "Katakana" };
            CheckBoxTimeLimit = TimeLimit();
            Vyber = new VyberCviceni();
            Button clickedButton = (Button)sender;
            if (clickedButton.Text == "Abecedy")
            {
                VyberCviceni.btn = "Abecedy";
            }

            if (StavAplikace.ActiveForm != "HiraganaKatakana")
            {
                Program.welcome.panel1.Controls.Clear();
                Vyuka v = new Vyuka();
                v.TopLevel = false;
                Program.welcome.panel1.Controls.Add(v);
                v.Dock = DockStyle.Fill;
                v.Show();
                StavAplikace.ActiveForm = "HiraganaKatakana";
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckBoxSelected = new List<string> { "N5", "N4" };
            CheckBoxTimeLimit = TimeLimit();
            Vyber = new VyberCviceni();
            Button clickedButton = (Button)sender;
            if (clickedButton.Text == "Kanji")
            {
                VyberCviceni.btn = "Kanji";
            }
            if (StavAplikace.ActiveForm != "Kanji")  /*account.HiraganaProgress == 100 && account.KatakanaProgress == 100  doplnit podminky na splneni H+K pred vyukou kanji */
            {
                Program.welcome.panel1.Controls.Clear();
                VyukaKanji k = new VyukaKanji();
                k.TopLevel = false;
                Program.welcome.panel1.Controls.Add(k);
                k.Dock = DockStyle.Fill;
                k.Show();
                StavAplikace.ActiveForm = "Kanji";
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckBoxSelected = new List<string> { "RU - Ichidan", "U - Godan", "Nepravidelná" };
            CheckBoxTimeLimit = TimeLimit();
            Vyber = new VyberCviceni();
            Button clickedButton = (Button)sender;
            if (clickedButton.Text == "Slovesa")
            {
                VyberCviceni.btn = "Slovesa";
            }
            if (StavAplikace.ActiveForm != "Slovesa")  /*account.HiraganaProgress == 100 && account.KatakanaProgress == 100  doplnit podminky na splneni H+K pred vyukou kanji */
            {
                Program.welcome.panel1.Controls.Clear();
                VyukaKanji k = new VyukaKanji();
                k.TopLevel = false;
                Program.welcome.panel1.Controls.Add(k);
                k.Dock = DockStyle.Fill;
                k.Show();
                StavAplikace.ActiveForm = "Slovesa";
            }
            else
            {

            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxHiragana.Checked == true)
            {
                VyberCviceni.Hiragana = true;

            }
            else
            {
                VyberCviceni.Hiragana = false;

            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxKatakana.Checked == true)
            {
                VyberCviceni.Katakana = true;

            }
            else
            {
                VyberCviceni.Katakana = false;

            }

        }



        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxN5.Checked == true)
            {
                VyberCviceni.N5 = true;
            }
            else
            {
                VyberCviceni.N5 = false;
            }

        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxN4.Checked == true)
            {
                VyberCviceni.N4 = true;
            }
            else
            {
                VyberCviceni.N4 = false;
            }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxIchidan.Checked == true)
            {
                VyberCviceni.Ichidan = true;
            }
            else
            {
                VyberCviceni.Ichidan = false;
            }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxGodan.Checked == true)
            {
                VyberCviceni.Godan = true;
            }
            else
            {
                VyberCviceni.Godan = false;
            }

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxN4.Checked == true)
            {
                VyberCviceni.Irregular = true;
            }
            else
            {
                VyberCviceni.Irregular = false;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public List<String> Selected()
        {
            List<string> selected = panel1.Controls.OfType<CheckBox>().Where(x => x.Checked && x.Name != "CheckBoxTimed").ToList().Select(i => i.Text).ToList();
            return selected;

        }

        public bool TimeLimit()
        {
            return CheckBoxTimed.Checked;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckBoxSelected = Selected();
            CheckBoxTimeLimit = TimeLimit();


            if (CheckBoxSelected.Any() != true)
            {
                label4.Visible = true;
            }
            else
            {
                Vyber = new VyberCviceni();
                Button clickedButton = (Button)sender;
                if (clickedButton.Text == "Kombinace")
                {
                    VyberCviceni.btn = "Kombinace";
                }
                if (StavAplikace.ActiveForm != "Kombinace")
                {
                    Program.welcome.panel1.Controls.Clear();
                    VyukaKanji k = new VyukaKanji();
                    k.TopLevel = false;
                    Program.welcome.panel1.Controls.Add(k);
                    k.Dock = DockStyle.Fill;
                    k.Show();
                    StavAplikace.ActiveForm = "Kombinace";
                }
            }
            


        }



    }

}
