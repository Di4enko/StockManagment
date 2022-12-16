using Stock_manager.dev.DAO;
using Stock_manager.dev.Logic;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Stock_manager.Forms
{
    public partial class AccountantForm : Form
    {
        private StockDAO stockDAO = new StockDAO();
        private OrderManager orderManager = new OrderManager();
        private List<string[]> order = new List<string[]>();
        private bool errors = false;

        public AccountantForm()
        {
            InitializeComponent();
            stockDAO.create_accountant_table(products);
        }

        private void createOrder_btn_click(object sender, EventArgs e)
        {
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
                orderManager.create_order(products, accountantName.Text);
                productError.Visible = false;
                nameError.Visible = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void accountantName_TextChanged(object sender, EventArgs e)
        {

        }

        private void products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
