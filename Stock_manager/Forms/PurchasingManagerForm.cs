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
    public partial class PurchasingManagerForm : Form
    {
        public PurchasingManagerForm()
        {
            InitializeComponent();
            customerOrdersLabel.Visible = true;
            customerOrdersTable.Visible = true;
            reloadCounterOrders_btn.Visible = true;
            myOrdersLabel.Visible = false;
            myOrdersTable.Visible = false;
            reloadMyOrders_btn.Visible = false;
        }

        private StockManager stockManager = new StockManager();
        private OrderManager orderManager = new OrderManager();
        private CompanyOrdersManager companyOrdersManager = new CompanyOrdersManager();
        private List<string[]> order = new List<string[]>();
        private bool errors = false;

        private void stockTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            errors = false;
            if (e.ColumnIndex == 5)
            {
                stockError.Visible = false;
                int row = e.RowIndex;
                if (stockTable.Rows[row].Cells["count"].Value == null)
                {
                    stockError.Text = "Can not add product without count!";
                    stockError.Visible = true;
                    errors = true;
                }
                else if (int.Parse(stockTable.Rows[row].Cells["count"].Value.ToString()) <= 0)
                {
                    stockError.Text = "You can not add product with count lower or equals 0!";
                    stockError.Visible = true;
                    errors = true;
                }
                else
                {
                    string productName = stockTable.Rows[row].Cells["product_name"].Value.ToString();
                    string productCount = stockTable.Rows[row].Cells["count"].Value.ToString();
                    order.Add(new string[] { productName, productCount });
                    string newProduct = String.Format("Name:{0} Count:{1}", productName, productCount);
                    myOrderDescription.Items.Add(newProduct);
                }
            }
            if (e.ColumnIndex == 4)
            {
                stockError.Visible = false;
                int row = e.RowIndex;
                if (stockTable.Rows[row].Cells["count"].Value == null)
                {
                    stockError.Text = "Can not reserve product without count!";
                    stockError.Visible = true;
                    errors = true;
                }
                else if (int.Parse(stockTable.Rows[row].Cells["count"].Value.ToString()) <= 0)
                {
                    stockError.Text = "You can not reserve product with count lower or equals 0!";
                    stockError.Visible = true;
                    errors = true;
                } else if (int.Parse(stockTable.Rows[row].Cells["count"].Value.ToString()) > int.Parse(stockTable.Rows[row].Cells["free"].Value.ToString()))
                {
                    stockError.Text = "You can not reserve products more than free products!";
                    stockError.Visible = true;
                    errors = true;
                }
                if(!errors)
                {
                    string productName = stockTable.Rows[row].Cells["product_name"].Value.ToString();
                    int free = int.Parse(stockTable.Rows[row].Cells["free"].Value.ToString());
                    int reserve = int.Parse(stockTable.Rows[row].Cells["reserve"].Value.ToString());
                    int count = int.Parse(stockTable.Rows[row].Cells["count"].Value.ToString());
                    int newReserve = reserve + count;
                    int newFree = free - count;
                    stockManager.updateReserve(productName, newReserve);
                    stockTable.Rows[row].Cells["free"].Value = newFree;
                    stockTable.Rows[row].Cells["reserve"].Value = newReserve;
                }
            }
        }

        private void reloadStock_btn_Click(object sender, EventArgs e)
        {
            stockTable.Rows.Clear();
            List<string[]> ordersList = stockManager.getPurshasingStock();

            foreach (string[] order in ordersList)
            {
                stockTable.Rows.Add(order);
            }
        }

        private void reloadMyOrders_btn_Click(object sender, EventArgs e)
        {
            myOrdersTable.Rows.Clear();
            List<string[]> ordersList = companyOrdersManager.getOrders();
            foreach (string[] order in ordersList)
            {
                myOrdersTable.Rows.Add(order);
            }
        }

        private void counterOrdersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = int.Parse(e.RowIndex.ToString());
            int col = int.Parse(e.ColumnIndex.ToString());
            //ошибка при пустой таблице
            int orderID = int.Parse(customerOrdersTable.Rows[row].Cells[0].Value.ToString());
            if (customerOrdersTable.Columns[col].Name.Equals("showOrder"))
            {
                customerOrderDescription.Items.Clear();
                string[] orders = orderManager.getOrderDescripton(orderID).Split(';');
                foreach (string order in orders) {
                    customerOrderDescription.Items.Add(order);
                }
            }
            if (customerOrdersTable.Columns[col].Name.Equals("processed"))
            {
                customerOrderDescription.Items.Clear();
                orderManager.orderProcessed(orderID);
            }
        }

        private void confirmOrder_btn_Click(object sender, EventArgs e)
        {
            stockError.Visible = false;
            errors = false;
            if (order.Count == 0)
            {
                stockError.Text = "Order can not be empty!";
                stockError.Visible = true;
                errors = true;
            }
            if (!errors)
            {
                companyOrdersManager.createOrder(order);
                stockError.Visible = false;
            }
        }

        private void reloadCounterOrders_btn_Click(object sender, EventArgs e)
        {
            customerOrdersTable.Rows.Clear();
            List<string[]> ordersList = orderManager.getPurshasingOrders();
            foreach (string[] order in ordersList)
            {
                customerOrdersTable.Rows.Add(order);
            }
        }

        private void myOrdersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = int.Parse(e.RowIndex.ToString());
            int col = int.Parse(e.ColumnIndex.ToString());
            //ошибка при пустой таблице
            int orderID = int.Parse(myOrdersTable.Rows[row].Cells[0].Value.ToString());
            if (myOrdersTable.Columns[col].Name.Equals("showMyOrders"))
            {
                customerOrderDescription.Items.Clear();
                string order = companyOrdersManager.getOrdersDescription(orderID);
                customerOrderDescription.Items.Add(order);
            }
        }

        private void showCounterOrders_btn_Click(object sender, EventArgs e)
        {
            customerOrdersLabel.Visible = true;
            customerOrdersTable.Visible = true;
            reloadCounterOrders_btn.Visible = true;
            myOrdersLabel.Visible = false;
            myOrdersTable.Visible = false;
            reloadMyOrders_btn.Visible = false;
        }

        private void showMyOrders_btn_Click(object sender, EventArgs e)
        {
            customerOrdersLabel.Visible = false;
            customerOrdersTable.Visible = false;
            reloadCounterOrders_btn.Visible = false;
            myOrdersLabel.Visible = true;
            myOrdersTable.Visible = true;
            reloadMyOrders_btn.Visible = true;
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

        private void stockError_Click(object sender, EventArgs e)
        {

        }
    }
}
