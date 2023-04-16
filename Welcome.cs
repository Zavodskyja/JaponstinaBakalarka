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
using Newtonsoft.Json;
using Japonstina;



namespace Japonstina
{
    public partial class Welcome : Form
    {

        public static string PrihlasenyUzivatel { get; set; }




        public Welcome()
        {
            var PrihlasenyUzivatel = "";
            InitializeComponent();
            Uvod u = new Uvod();
            u.TopLevel = false;
            panel1.Controls.Add(u);
            u.Show();




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"login";
            if (!File.Exists(path))
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                }
            }

            System.IO.FileInfo file = new System.IO.FileInfo("Data\\");
            file.Directory.Create();



            StreamReader sr = new StreamReader("login");


            string line;


            while ((line = sr.ReadLine()) != null)
            {

                string[] components = line.Split('|');

                var user = new usermodel()
                {
                    username = components[0],
                    password = components[1]

                };
                userstorage.adduser(user);
            }


            sr.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {






        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            if (StavAplikace.ActiveForm != "Registrace")
            {

                PanelRegistrace f = new PanelRegistrace();
                panel1.Controls.Clear();
                f.TopLevel = false;
                panel1.Controls.Add(f);
                f.Show();
                StavAplikace.ActiveForm = "Registrace";
            }
            else
            {

            }




        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var user = new usermodel()
            {
                username = LoginBox.Text,
                password = PasswordBox.Text

            };
            if (userstorage.login(user))
            {
                ProgressManager.LoadKanji();
                ProgressManager.FirstLoginRun(user.username);
                ProgressManager.LoadProgress(user.username);
                
                PrihlasenyUzivatel = LoginBox.Text;
                LoginPanel.Controls.Clear();
                MainMenu m = new MainMenu();
                m.TopLevel = false;
                LoginPanel.Controls.Add(m);
                m.UserLabel.Text = PrihlasenyUzivatel;
                m.Show();

                panel1.Controls.Clear();
                MainPage mp = new MainPage();
                mp.TopLevel = false;
                panel1.Controls.Add(mp);
                mp.Show();







                string acc = @"Data\\" + PrihlasenyUzivatel;
                if (!File.Exists(acc))
                {

                    using (StreamWriter swacc = File.CreateText(acc))
                    {

                    }

                    StreamReader SrAcc = new StreamReader("Data\\" + LoginBox.Text);

                    string AccLine;
                    while ((AccLine = SrAcc.ReadLine()) != null)
                    {

                        string[] components = AccLine.Split('|');


                    }


                    SrAcc.Close();
                }




            }
            else if (!userstorage.exist(user.username))
            {
                LoginError.Text = "Zadaný účet neexistuje";
            }
            else
            {

                LoginError.Text = "Neplatné jméno a heslo";
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

