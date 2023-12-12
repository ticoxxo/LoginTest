using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginTest
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e) {}

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Selection selForm = new Selection();
            usersTableAdapter.ClearBeforeFill = true;
            usersTableAdapter.FillByUserNamePassword(test_jazzclubDataSetV2.users, txtUserName.Text, txtPassWord.Text);
            if(test_jazzclubDataSetV2.users.Count == 0)
            {
                MessageBox.Show("No matches password");
                txtUserName.Clear();
                txtUserName.Focus();
                txtPassWord.Clear();
            } else
            {
                this.Hide();
                selForm.ShowDialog();
                this.Close();
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
