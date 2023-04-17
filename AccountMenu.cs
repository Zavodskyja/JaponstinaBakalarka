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
    public partial class AccountMenu : Form
    {

        // private TransparentProgressBar blueProgressBar;
        public AccountMenu()
        {
            InitializeComponent();
            /*
            blueProgressBar = new TransparentProgressBar
            {
                Name = "blueProgressBar",
                Location = new Point(230, 169),
                Size = new Size(965, 35),
                Maximum = 100,
                Value = 100,
                ForeColor = SystemColors.Highlight,
                BackColor = Color.Blue
                
            };

            Controls.Add(blueProgressBar);
            blueProgressBar.BringToFront();
            */
            progressBarKatakana.Value = 50;
            progressBarKatakana.ForeColor = Color.FromArgb(240, 134, 144);
            progressBarKanji.Value = 20;
            progressBarKanji.ForeColor = Color.FromArgb(195, 39, 43);
            progressBarVerbs.ForeColor = Color.FromArgb(165, 186, 147);
            progressBarVerbs.Value = 90;

        }



        private void MenuHiragana_Click(object sender, EventArgs e)
        {

        }

        private void KanjiPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void KatakanaGraf_Click(object sender, EventArgs e)
        {
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (StavAplikace.ActiveForm != "DetailKatakana")
            {
                StavAplikace.ActiveForm = "DetailKatakana";
                Program.welcome.panel1.Controls.Clear();
                AccountDetail2 a = new AccountDetail2();
                a.TopLevel = false;
                Program.welcome.panel1.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.Show();
            }
        }

        private void AbecedyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccountMenu_Load(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
            if (StavAplikace.ActiveForm != "DetailKanji")
            {
                StavAplikace.ActiveForm = "DetailKanji";
                Program.welcome.panel1.Controls.Clear();
                AccountDetail2 a = new AccountDetail2();
                a.TopLevel = false;
                Program.welcome.panel1.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.Show();
            }

        }

        private void progressBar3_Click(object sender, EventArgs e)
        {
            if (StavAplikace.ActiveForm != "DetailSlovesa")
            {
                StavAplikace.ActiveForm = "DetailSlovesa";
                Program.welcome.panel1.Controls.Clear();
                AccountDetail2 a = new AccountDetail2();
                a.TopLevel = false;
                Program.welcome.panel1.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.Show();
            }
        }
    }

}
