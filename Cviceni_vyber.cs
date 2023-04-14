using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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



        //TODO - promazat nepoužívané funkce z designeru
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void button4_Click(object sender, EventArgs e)
        {
            HandleButtonClick("Kombinace", sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleButtonClick("HiraganaKatakana", sender, "Hiragana", "Katakana");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleButtonClick("Kanji", sender, "N5", "N4");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            HandleButtonClick("Slovesa", sender, "RU - Ichidan", "U - Godan", "Nepravidelné");

        }

        private void Exercise(string activeForm)
        {
            Program.welcome.panel1.Controls.Clear();
            VyukaKanji k = new VyukaKanji();
            k.TopLevel = false;
            Program.welcome.panel1.Controls.Add(k);
            k.Dock = DockStyle.Fill;
            k.Show();
            StavAplikace.ActiveForm = activeForm;
        }


        public List<String> SelectedCheckBoxes()
        {
            List<string> selected = panel1.Controls.OfType<CheckBox>().Where(x => x.Checked && x.Name != "CheckBoxTimed").ToList().Select(i => i.Text).ToList();
            return selected;
        }

        public bool TimeLimit()
        {
            return CheckBoxTimed.Checked;
        }

        private void HandleButtonClick(string activeForm, object sender, params string[] exercises)
        {
            try
            {
                CheckBoxTimeLimit = TimeLimit();

                if (activeForm == "Kombinace")
                {
                    CheckBoxSelected = SelectedCheckBoxes();

                    if (!CheckBoxSelected.Any())
                    {
                        label4.Visible = true;
                        return;
                    }
                }
                else
                {
                    CheckBoxSelected = new List<string>(exercises);
                }

                Vyber = new VyberCviceni();
                var clickedButton = (Button)sender;

                if (string.Equals(clickedButton.Text, activeForm))
                {
                    VyberCviceni.btn = activeForm;
                }

                if (!string.Equals(StavAplikace.ActiveForm, activeForm))
                {
                    Exercise(activeForm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Naskytla se Chyba. Zkuste akci opakovat.", "Chyba aplikace", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StavAplikace.ActiveForm = "";
            }
        }









    }

}
