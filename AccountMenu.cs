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
            this.circularProgressBar1.MouseHover += new System.EventHandler(this.circularProgressBar1_MouseHover);
            this.circularProgressBar1.MouseLeave += new System.EventHandler(this.circularProgressBar1_MouseLeave);
            this.circularProgressBar2.MouseHover += new System.EventHandler(this.circularProgressBar2_MouseHover);
            this.circularProgressBar2.MouseLeave += new System.EventHandler(this.circularProgressBar2_MouseLeave);
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

        private void circularProgressBar1_MouseHover(object sender, EventArgs e)
        {
            circularProgressBar1.Size = new Size(250, 250);
            

        }

        private void circularProgressBar1_MouseLeave(object sender, EventArgs e)
        {
            circularProgressBar1.Size = new Size(200, 200);

        }

        private void circularProgressBar2_MouseHover(object sender, EventArgs e)
        {
            circularProgressBar2.Size = new Size(250, 250);
            

        }

        private void circularProgressBar2_MouseLeave(object sender, EventArgs e)
        {
            circularProgressBar2.Size = new Size(200, 200);

        }

        private void circularProgressBar2_Click(object sender, EventArgs e)
        {

        }

  

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void KatakanaGraf_Click(object sender, EventArgs e)
        {
                    }
    }
}
