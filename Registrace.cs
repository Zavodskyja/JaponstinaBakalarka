using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Japonstina.models;
using System.Text.RegularExpressions;


namespace Japonstina
{
    public partial class PanelRegistrace : Form
    {

        public PanelRegistrace()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var validace = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{5,15}$");

            if (userstorage.exist(RegistrationLoginBox.Text))
            {

                RegistrationError.Text = "Login již existuje";
            }

            else if
                 (RegistrationPasswordBox1.Text != RegistrationPasswordBox2.Text)
            {
                RegistrationError.Text = "Hesla se neshodují";
            }

            else if
                (!validace.IsMatch(RegistrationPasswordBox1.Text))
            {
                RegistrationError.Text = "Heslo neodpovídá požadavkům";
            }
            //else if (RegistrationPasswordBox1.Text.Length < 5)
            //{
            //    RegistrationError.Text = "Heslo musí být delší nez 5 znaků";
            //}
            //else if (RegistrationPasswordBox1.Text.Length >= 15)
            //{
            //    RegistrationError.Text = "Heslo musí být kratší než 15 znaků";
            //}
            else
                using (StreamWriter writetext = new StreamWriter("login", append: true))
                {

                    writetext.WriteLine(RegistrationLoginBox.Text + '|' + RegistrationPasswordBox1.Text);
                    RegistrationError.Text = "";
                    var user = new usermodel();
                    user.username = RegistrationLoginBox.Text;
                    user.password = RegistrationPasswordBox1.Text;
                    userstorage.adduser(user);
                    panel2.Visible = true;
                    ProgressManager.FirstLoginRun(user.username);



                }

        }

        private void RegistrationLoginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationPasswordBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
