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



        private void progressBar1_Click(object sender, EventArgs e)
        {
            AccountFormDetail accountFormDetailInstance = new AccountFormDetail();
            accountFormDetailInstance.SetAccountForm("DetailKatakana");
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
            AccountFormDetail accountFormDetailInstance = new AccountFormDetail();
            accountFormDetailInstance.SetAccountForm("DetailKanji");
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {
            AccountFormDetail accountFormDetailInstance = new AccountFormDetail();
            accountFormDetailInstance.SetAccountForm("DetailSlovesa");
        }
    }

}
