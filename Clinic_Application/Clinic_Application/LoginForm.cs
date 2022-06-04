using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Application
{
    public partial class frmLogin : Form
    {
        SqlConnection con = new SqlConnection(Connection.ConnectionString);
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

        private void txtbxUserName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MessageBox.Show("Hello");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
