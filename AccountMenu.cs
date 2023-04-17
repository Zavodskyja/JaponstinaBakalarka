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
            progressBar1.Value = 50;
            progressBar1.ForeColor = Color.FromArgb(240, 134, 144);
            progressBar2.Value = 20;
            progressBar2.ForeColor = Color.FromArgb(195, 39, 43);
            progressBar3.ForeColor = Color.FromArgb(165, 186, 147);
            progressBar3.Value = 90;

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
            if (StavAplikace.ActiveForm != "Abecedy")
            {
                StavAplikace.ActiveForm = "Abecedy";
                Program.welcome.panel1.Controls.Clear();
                account a = new account();
                a.TopLevel = false;
                Program.welcome.panel1.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.Show();
            }
        }

        private void AbecedyPanel_Paint(object sender, PaintEventArgs e)
        {

        }



    }

}
