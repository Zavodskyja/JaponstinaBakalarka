using Japonstina.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Japonstina;

namespace Japonstina
{
    public partial class AccountDetail2 : Form
    {
        public AccountDetail2()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            AccountFormDetail accountFormDetailInstance = new AccountFormDetail();
            accountFormDetailInstance.SetAccountForm("Hiragana");

        }

        private void transparentProgressBar1_Click(object sender, EventArgs e)
        {
            AccountFormDetail accountFormDetailInstance = new AccountFormDetail();
            accountFormDetailInstance.SetAccountForm("Hiragana");
        }

        private void transparentProgressBar2_Click(object sender, EventArgs e)
        {
            AccountFormDetail accountFormDetailInstance = new AccountFormDetail();
            accountFormDetailInstance.SetAccountForm("Hiragana");
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
