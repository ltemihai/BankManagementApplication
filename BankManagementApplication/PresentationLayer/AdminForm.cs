using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Model;
using BankManagementApplication.PresentationLayer.LoginAccountForm;

namespace BankManagementApplication.PresentationLayer
{
    public partial class AdminForm : Form
    {
        private LoginUser loginAccount;

        public AdminForm(LoginUser loginAccount)
        {
            LoginUser = loginAccount;
            InitializeComponent();
        }

        internal LoginUser LoginUser
        {
            get
            {
                return loginAccount;
            }

            set
            {
                loginAccount = value;
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankdbDataSet2.login_accounts' table. You can move, or remove it, as needed.
            this.login_accountsTableAdapter.Fill(this.bankdbDataSet2.login_accounts);

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            AddLoginUserForm form = new AddLoginUserForm();
            form.Show();
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            RemoveLoginUserForm form = new RemoveLoginUserForm();
            form.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm form = new LoginForm();
            form.Show();
            
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            UpdateLoginUserForm form = new UpdateLoginUserForm();
            form.Show();
        }

        private void findUserButton_Click(object sender, EventArgs e)
        {
            FindLoginuserForm form = new FindLoginuserForm();
            form.Show();
        }
    }
}
