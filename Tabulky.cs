using Japonstina.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
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
            DownloadImage("Hiragana");
        }
        private void Hiragana_MouseHover(object sender, EventArgs e)
        {
            Hiragana2.Visible = true;
            label3.Visible = false;
        }
        private void Hiragana_MouseLeave(object sender, EventArgs e)
        {

            Hiragana2.Visible = false;
            label3.Visible = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DownloadImage("Katakana");
        }

        private void Katakana_MouseHover(object sender, EventArgs e)
        {
            Katakana2.Visible = true;
            label3.Visible = false;
        }
        private void Katakana_MouseLeave(object sender, EventArgs e)
        {
            Katakana2.Visible = false;
            label3.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Katakana2_Click(object sender, EventArgs e)
        {

        }

        public void DownloadImage(string file)
        {
            string filename = file;
            Bitmap imageResource = Resources.ResourceManager.GetObject(filename) as Bitmap;

            string tempFilePath = Path.GetTempFileName();
            imageResource.Save(tempFilePath, ImageFormat.Jpeg);

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = $"{file}.jpg",
                Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.Copy(tempFilePath, saveFileDialog.FileName, true);
                MessageBox.Show($"Tabulka {file} stažena", "Stažení kompletní", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            File.Delete(tempFilePath);
        }
    }
}
