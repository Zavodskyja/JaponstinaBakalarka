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

    public partial class MainMenu : Form
    {

        public MainMenu()
        {

            InitializeComponent();

        }

        public static string ActiveForma;


        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProgressManager.SaveProgress();
            Application.Restart();



        }

        private void UserLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (StavAplikace.ActiveForm != "CviceniVyber")
            {
                Program.welcome.panel1.Controls.Clear();
                Cviceni_vyber cv = new Cviceni_vyber();
                cv.TopLevel = false;
                Program.welcome.panel1.Controls.Add(cv);
                cv.Dock = DockStyle.Fill;
                cv.Show();
                StavAplikace.ActiveForm = "CviceniVyber";
            }

            else
            {

            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StavAplikace.ActiveForm != "Tabulky")
            {
                Program.welcome.panel1.Controls.Clear();
                Tabulky t = new Tabulky();
                t.TopLevel = false;
                Program.welcome.panel1.Controls.Add(t);
                t.Dock = DockStyle.Fill;
                t.Show();
                StavAplikace.ActiveForm = "Tabulky";

            }
            else
            {

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {


            AccountFormDetail accountFormDetailInstance = new AccountFormDetail();
            accountFormDetailInstance.SetAccountForm("AccountDetail");




        }


    }
}
