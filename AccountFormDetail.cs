using Japonstina.models;
using System;
using System.Collections.Generic;
using System.Linq;
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
                AccountDetail2 a = new AccountDetail2();
                a.TopLevel = false;
                Program.welcome.panel1.Controls.Add(a);
                a.Dock = DockStyle.Fill;
                a.Show();
            }
        }
    }
}
