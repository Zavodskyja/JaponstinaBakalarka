using Japonstina.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japonstina
{
    public class AccountFormDetail
    {

        public void SetAccountForm(string form)
        {
            if (StavAplikace.ActiveForm != form)
            {
                StavAplikace.ActiveForm = form;
                Program.welcome.panel1.Controls.Clear();

                if (form == "DetailKatakana" || form == "DetailKanji" || form == "DetailSlovesa")
                {
                    AccountDetail2 a = new AccountDetail2();
                    a.TopLevel = false;
                    Program.welcome.panel1.Controls.Add(a);
                    a.Dock = DockStyle.Fill;
                    a.Show();
                    UpdateLabels(a, form);
                }
                else
                {
                    account a = new account();
                    a.TopLevel = false;
                    Program.welcome.panel1.Controls.Add(a);
                    a.Dock = DockStyle.Fill;
                    a.Show();
                    //UpdateLabels(a, form);
                }
            }
        }

        public void UpdateLabels(AccountDetail2 accountDetailInstance, string form)
        {
            if (form == "DetailKatakana")
            {
                accountDetailInstance.labelTop.Text = "Hiragana";
                accountDetailInstance.labelMid.Text = "Katakana";
                accountDetailInstance.panel3.Visible = false;
                accountDetailInstance.progressBar1.Name = "Hiragana";
                accountDetailInstance.progressBar2.Name = "Katakana";

            }

            if (form == "DetailKanji")
            {
                accountDetailInstance.labelTop.Text = "N5";
                accountDetailInstance.labelMid.Text = "N4";
                accountDetailInstance.panel3.Visible = false;
                accountDetailInstance.progressBar1.Name = "N5";
                accountDetailInstance.progressBar2.Name = "N4";
            }
            if (form == "DetailSlovesa")
            {
                accountDetailInstance.labelTop.Text = "RU - Ichidan";
                accountDetailInstance.labelMid.Text = "U - Godan";
                accountDetailInstance.labelBot.Text = "Nepravidelná";
                accountDetailInstance.progressBar1.Name = "Hiragana";
                accountDetailInstance.progressBar2.Name = "Katakana";
                accountDetailInstance.progressBar3.Name = "Hiragana";
            }
        }


    }
}
