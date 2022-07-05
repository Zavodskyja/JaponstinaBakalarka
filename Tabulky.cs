using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japonstina
{
    public partial class Tabulky : Form
    {
        public Tabulky()
        {
            InitializeComponent();
            this.Hiragana.MouseHover += new System.EventHandler(this.Hiragana_MouseHover);
            this.Hiragana.MouseLeave += new System.EventHandler(this.Hiragana_MouseLeave);
            this.Katakana.MouseHover += new System.EventHandler(this.Katakana_MouseHover);
            this.Katakana.MouseLeave += new System.EventHandler(this.Katakana_MouseLeave);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Hiragana_MouseHover(object sender, EventArgs e)
        {
            Hiragana2.Visible=true;
          
            
        }
        private void Hiragana_MouseLeave(object sender, EventArgs e)
        {
            
            Hiragana2.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Katakana_MouseHover(object sender, EventArgs e)
        {
            Katakana2.Visible = true;
        }
        private void Katakana_MouseLeave(object sender, EventArgs e)
        {
            Katakana2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
