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
using Japonstina.Registrace;
using System.Text.RegularExpressions;
using System.Security.Cryptography;


namespace Japonstina
{
    public partial class PanelRegistrace : Form
    {
        private static readonly Regex validatePassword = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{5,15}$");
        private static readonly Regex ValidateLogin = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z]).{4,10}$");

        public PanelRegistrace()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (userstorage.exist(RegistrationLoginBox.Text))
            {
                RegistrationError.Text = "Login již existuje";
            }

            else if
                (String.IsNullOrWhiteSpace(RegistrationLoginBox.Text))
            {
                RegistrationError.Text = "Nevyplněn login";
            }

            else if
                 (!ValidateLogin.IsMatch(RegistrationLoginBox.Text))
            {
                RegistrationError.Text = "Login neodpovídá požadavkům";
            }

            else if
                 (RegistrationPasswordBox1.Text != RegistrationPasswordBox2.Text)
            {
                RegistrationError.Text = "Hesla se neshodují";
            }

            else if
                 (!validatePassword.IsMatch(RegistrationPasswordBox1.Text))
            {
                RegistrationError.Text = "Heslo neodpovídá požadavkům";
            }

            else
            {
                RegisterUser();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void RegisterUser()
        {
            using (StreamWriter writetext = new StreamWriter("login", append: true))
            {
                string hashedPassword = ComputeSha256Hash(RegistrationPasswordBox1.Text);
                string username = RegistrationLoginBox.Text;

                writetext.WriteLine(username + '|' + hashedPassword);
                RegistrationError.Text = "";
                var user = new usermodel();
                user.username = RegistrationLoginBox.Text;
                user.password = hashedPassword;
                userstorage.adduser(user);
                Program.welcome.panel1.Controls.Clear();
                RegistraceOk ROk = new RegistraceOk();
                Program.welcome.panel1.Controls.Add(ROk);
                ROk.Dock = DockStyle.Fill;
                ROk.Show();
                StavAplikace.ActiveForm = "RegistraceOk";
                ProgressManager.FirstLoginRun(username);
            }
        }

        private static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
