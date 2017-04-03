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

namespace BankManagementApplication.PresentationLayer
{
    public partial class DeleteClientForm : Form
    {
        public DeleteClientForm()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Repository<LoginGateway, LoginUser> repository = new Repository<LoginGateway, LoginUser>();
            LoginUser loginUser = repository.Delete(new LoginUser(idClientTextBox.Text));

            if (loginUser.Equals(null))
            {
                MessageBox.Show("Error!");
            }
            else
            {
                MessageBox.Show("Userul cu numele " + loginUser.User + " a fost sters");
                this.Close();
            }
        }
    }
}
