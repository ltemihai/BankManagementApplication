using BankManagementApplication.DataAccessLayer;
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

namespace BankManagementApplication.PresentationLayer.TransactionForms
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            Repository<TransactionGateway, Transaction> repository = new Repository<TransactionGateway, Transaction>();
            DataTable transactions = repository.Find(new Transaction(accountIdTextBox.Text));
            dataGridView1.DataSource = transactions;
        }
    }
}
