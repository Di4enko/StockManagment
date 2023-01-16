using Stock_manager.dev.DAO;
using Stock_manager.dev.Logic;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Stock_manager.Forms
{
    public partial class CustomerForm : Form
    {
        private StockDAO stockDAO = new StockDAO();
        private OrderManager orderManager = new OrderManager();
        private List<string[]> order = new List<string[]>();
        private bool errors = false;
        string id;

        public CustomerForm()
        {
            InitializeComponent();
            stockDAO.create_accountant_table(products);
            confirm_btn.Enabled = false;
            cancel_btn.Enabled = false;
            pay_btn.Enabled = false;
        }

        private void createOrder_btn_click(object sender, EventArgs e)
        {
            nameError.Visible = false;
            errors = false;
            if (accountantName.Text == String.Empty)
            {
                nameError.Text = "Name can not be empty";
                nameError.Visible = true;
                errors = true;
            }
            else if (!Regex.IsMatch(accountantName.Text, @"^[a-zA-Z]+$"))
            {
                nameError.Text = "Name can not contains numbers!";
                nameError.Visible = true;
                errors = true;
            }
            if (order.Count == 0) 
            { 
                productError.Text = "Order can not be empty!";
                productError.Visible = true;
                errors = true;
            }
            if (!errors)
            {
                orderManager.create_order(order, accountantName.Text);
                productError.Visible = false;
                nameError.Visible = false;
                placedOrder.Visible = true;
            }
        }

        private void products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            errors = false;
            productError.Visible = false;
            int row = e.RowIndex;
            if (products.Rows[row].Cells["count"].Value == null)
            {
                productError.Text = "Can not add product without count!";
                productError.Visible = true;
                errors = true;
            }
            else if (int.Parse(products.Rows[row].Cells["count"].Value.ToString()) <= 0)
            {
                productError.Text = "You can not add product with count lower or equals 0!";
                productError.Visible = true;
                errors = true;
            }
            else
            {
                string productName = products.Rows[row].Cells["product"].Value.ToString();
                string productCount = products.Rows[row].Cells["count"].Value.ToString();
                string price = (int.Parse(products.Rows[row].Cells["price"].Value.ToString()) * int.Parse(productCount)).ToString();
                order.Add(new string[] {productName, productCount});
                string newProduct = String.Format("Name:{0} Count:{1}: Price:{2}", productName, productCount, price);
                accountantOrder.Items.Add(newProduct);
            }
        }

        private void showOrders_btn_Click(object sender, EventArgs e)
        {
            myOrders.Rows.Clear();
            orderManager.getOrders(accountantName.Text.ToString(), myOrders);
        }

        private void myOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderID = int.Parse(myOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
            id = orderID.ToString();
            string order = orderManager.getOrderDescripton(orderID);
            orderDescription.Items.Clear();
            orderDescription.Items.Add(order);
            string status = myOrders.Rows[e.RowIndex].Cells[1].Value.ToString();
            switch (status)
            {
                case "new":
                    confirm_btn.Enabled = false;
                    cancel_btn.Enabled = true;
                    pay_btn.Enabled = false;
                    break;
                case "offer":
                    confirm_btn.Enabled = true;
                    cancel_btn.Enabled = true;
                    pay_btn.Enabled = false;
                    break;
                case "confirm":
                    confirm_btn.Enabled = false;
                    cancel_btn.Enabled = true;
                    pay_btn.Enabled = false;
                    break;
                case "cancel":
                    confirm_btn.Enabled = false;
                    cancel_btn.Enabled = false;
                    pay_btn.Enabled = false;
                    break;
                case "bill":
                    confirm_btn.Enabled = false;
                    cancel_btn.Enabled = true;
                    pay_btn.Enabled = true;
                    break;
                case "payed":
                    confirm_btn.Enabled = false;
                    cancel_btn.Enabled = false;
                    pay_btn.Enabled = false;
                    break;
                case "shipped":
                    confirm_btn.Enabled = false;
                    cancel_btn.Enabled = false;
                    pay_btn.Enabled = false;
                    break;
            }       
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            orderManager.updateStatus("confirm", id);
            confirmLabel.Visible = true;
            payLabel.Visible = false;
            cancelLabel.Visible = false;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            orderManager.updateStatus("cancel", id);
            cancelLabel.Visible = true;
            confirmLabel.Visible = false;
            payLabel.Visible = false;
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            orderManager.updateStatus("payed", id);
            payLabel.Visible = true;
            confirmLabel.Visible = false;
            cancelLabel.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void clearTable(DataGridView table)
        {
            int count = table.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                table.Rows.Remove(table.Rows[i]);
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
