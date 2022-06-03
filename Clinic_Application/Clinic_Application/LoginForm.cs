using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Application
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lnklblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetPssword fgp = new frmForgetPssword();
            this.Hide();
            fgp.Show();
        }

        private void lnklblNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNewUser neu = new frmNewUser();
            this.Hide();
            neu.Show();
        }
    }
}
