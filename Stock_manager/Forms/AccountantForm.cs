using Stock_manager.dev.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_manager.Forms
{
    public partial class AccountantForm : Form
    {
        public AccountantForm(string name)
        {
            InitializeComponent();
            label1.Text = name;
            customerOrdersTable.Visible = true;
            customerOrderID.Visible = true;
            bill.Visible = true;
            reloadCustomerOrders.Visible = true;
            customerOrdersLabel.Visible = true;
            storekeeperOrdersTable.Visible = false;
            reloadStorekeeperOrders.Visible = false;
            pay.Visible = false;
            storekeeperOrderID.Visible = false;
            storekeeperOrdersLabel.Visible = false;
            ordersTable.Visible = false;
            orderID.Visible = false;
            reloadOrders.Visible = false;
            capitalize.Visible = false;
            capitzlizeOrdersLabel.Visible = false;
        }

        private OrderManager orderManager = new OrderManager();
        private CompanyOrdersManager companyOrdersManager = new CompanyOrdersManager();
        private int customerID = 0;
        private int storekeeperID = 0;
        private int ID = 0;

        private void customerOrdersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = int.Parse(e.RowIndex.ToString());
            //ошибка при пустой таблице
            customerID = int.Parse(customerOrdersTable.Rows[row].Cells[0].Value.ToString());
            customerOrderID.Text = customerOrdersTable.Rows[row].Cells[0].Value.ToString();
        }

        private void reloadCustomerOrders_Click(object sender, EventArgs e)
        {
            customerOrdersTable.Rows.Clear();
            List<string[]> ordersList = orderManager.getCustomerOrders();

            foreach (string[] order in ordersList)
            {
                customerOrdersTable.Rows.Add(order);
            }
        }

        private void storekeeperOrdersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = int.Parse(e.RowIndex.ToString());
            //ошибка при пустой таблице
            storekeeperID = int.Parse(storekeeperOrdersTable.Rows[row].Cells[0].Value.ToString());
            storekeeperOrderID.Text = storekeeperOrdersTable.Rows[row].Cells[0].Value.ToString();

        }

        private void reloadStorekeeperOrders_Click(object sender, EventArgs e)
        {
            ordersTable.Rows.Clear();
            List<string[]> ordersList = companyOrdersManager.getStorekeeperOrders();

            foreach (string[] order in ordersList)
            {
                customerOrdersTable.Rows.Add(order);
            }

        }

        private void ordersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = int.Parse(e.RowIndex.ToString());
            //ошибка при пустой таблице
            ID = int.Parse(ordersTable.Rows[row].Cells[0].Value.ToString());
            orderID.Text = ordersTable.Rows[row].Cells[0].Value.ToString();
        }

        private void reloadOrders_Click(object sender, EventArgs e)
        {
            customerOrdersTable.Rows.Clear();
            List<string[]> ordersList = companyOrdersManager.getCapitalizeOrders();

            foreach (string[] order in ordersList)
            {
                customerOrdersTable.Rows.Add(order);
            }
        }

        private void bill_Click(object sender, EventArgs e)
        {
            if (customerID != 0)
            {
                orderManager.bill(customerID);
                billLabel.Visible = true;
                payLabel.Visible = false;
                capitalizeLabel.Visible = false;
                error.Visible = false;
            } else
            {
                billLabel.Visible = false;
                payLabel.Visible = false;
                capitalizeLabel.Visible = false;
                error.Visible = true;
            }
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (storekeeperID != 0)
            {
                companyOrdersManager.pay(storekeeperID);
                payLabel.Visible = true;
                billLabel.Visible = false;
                capitalizeLabel.Visible = false;
                error.Visible = false;
            }
            else
            {
                billLabel.Visible = false;
                payLabel.Visible = false;
                capitalizeLabel.Visible = false;
                error.Visible = true;
            }
        }

        private void capitalize_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                companyOrdersManager.capitalize(ID);
                capitalizeLabel.Visible = true;
                payLabel.Visible = false;
                billLabel.Visible = false;
                error.Visible = false;
            }
            else
            {
                billLabel.Visible = false;
                payLabel.Visible = false;
                capitalizeLabel.Visible = false;
                error.Visible = true;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void customerOrders_Click(object sender, EventArgs e)
        {
            customerOrdersTable.Visible = true;
            customerOrderID.Visible = true;
            bill.Visible = true;
            reloadCustomerOrders.Visible = true;
            customerOrdersLabel.Visible = true;
            storekeeperOrdersTable.Visible = false;
            reloadStorekeeperOrders.Visible = false;
            pay.Visible = false;
            storekeeperOrderID.Visible = false;
            storekeeperOrdersLabel.Visible = false;
            ordersTable.Visible = false;
            orderID.Visible = false;
            reloadOrders.Visible = false;
            capitalize.Visible = false;
            capitzlizeOrdersLabel.Visible = false;
        }

        private void storekeeperOrders_Click(object sender, EventArgs e)
        {
            customerOrdersTable.Visible = false;
            customerOrderID.Visible = false;
            bill.Visible = false;
            reloadCustomerOrders.Visible = false;
            customerOrdersLabel.Visible = false;
            storekeeperOrdersTable.Visible = true;
            reloadStorekeeperOrders.Visible = true;
            pay.Visible = true;
            storekeeperOrderID.Visible = true;
            storekeeperOrdersLabel.Visible = true;
            ordersTable.Visible = false;
            orderID.Visible = false;
            reloadOrders.Visible = false;
            capitalize.Visible = false;
            capitzlizeOrdersLabel.Visible = false;
        }

        private void receipt_Click(object sender, EventArgs e)
        {
            customerOrdersTable.Visible = false;
            customerOrderID.Visible = false;
            bill.Visible = false;
            reloadCustomerOrders.Visible = false;
            customerOrdersLabel.Visible = false;
            storekeeperOrdersTable.Visible = false;
            reloadStorekeeperOrders.Visible = false;
            pay.Visible = false;
            storekeeperOrderID.Visible = false;
            storekeeperOrdersLabel.Visible = false;
            ordersTable.Visible = true;
            orderID.Visible = true;
            reloadOrders.Visible = true;
            capitalize.Visible = true;
            capitzlizeOrdersLabel.Visible = true;
        }
    }
}
