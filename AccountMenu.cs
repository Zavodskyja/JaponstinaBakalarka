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
        public AccountMenu()
        {
            InitializeComponent();
        }

        public static string ActiveForma;

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

        private void circularProgressBar1_Click(object sender, EventArgs e )
        {
            /*Doplnit globalni activeformu*/

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
    }
}
