using BusinessLayer.DataAccesLayer;
using BusinessLayer.Model;
using BusinessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementApplication.PresentationLayer.LoginAccountForm
{
    public partial class FindLoginuserForm : Form
    {
        public FindLoginuserForm()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Repository<LoginGateway, LoginUser> repository = new Repository<LoginGateway, LoginUser>();
            DataTable loginUser = repository.Find(new LoginUser(userTextBox.Text));
            dataGridView1.DataSource = loginUser;
        }
    }
}
