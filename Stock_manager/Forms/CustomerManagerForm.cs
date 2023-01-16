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
    public partial class CustomerManagerForm : Form
    {
        private OrderManager orderManager = new OrderManager();
        private StockManager stockManager = new StockManager();

        string id;

        public CustomerManagerForm(string name)
        {
            InitializeComponent();
            inStock_btn.Enabled = false;
            notInStock_btn.Enabled = false;
            managerName.Text = name;
        }

        private void showOrder_btn_Click(object sender, EventArgs e)
        {
            int orderID = int.Parse(orders.Rows[int.Parse(e.ToString())].Cells[0].Value.ToString());
            string order = orderManager.getOrderDescripton(orderID);
            orderDescription.Text = order;
        }

        private void reloadOrders_btn_Click(object sender, EventArgs e)
        {
            orders.Rows.Clear();
            List<string[]> ordersList = orderManager.getOrders();
            foreach (string[] order in ordersList)
            {
                orders.Rows.Add(order);
            }
        }

        private void showStock_btn_Click(object sender, EventArgs e)
        {
            stockTable.Rows.Clear();
            String productName = productNameFind.Text.ToString();
            stockManager.showStock(productName, stockTable);
        }

        private void orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            inStock_btn.Enabled = true;
            notInStock_btn.Enabled = true;
            int row = int.Parse(e.RowIndex.ToString());
            int col = int.Parse(e.ColumnIndex.ToString());
            //ошибка при пустой таблице
            id = orders.Rows[row].Cells[0].Value.ToString();
            int orderID = int.Parse(id);
            if (orders.Columns[col].Name.Equals("showOrder_btn"))
            {
                string[] orders = orderManager.getOrderDescripton(orderID).Split(';');
                foreach (string order in orders)
                {
                    orderDescription.Items.Add(order);
                }
            } else
            if (orders.Columns[col].Name.Equals("get_order"))
            {
                orderManager.managerGetOrder(orderID, managerName.Text);
            }
        }

        private void inStock_btn_Click(object sender, EventArgs e)
        {
            orderManager.confirmOrder(true, id);
        }

        private void notInStock_btn_Click(object sender, EventArgs e)
        {
            orderManager.confirmOrder(false, id);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void managerName_Click(object sender, EventArgs e)
        {

        }

        private void clearTable(DataGridView table)
        {
            int count = table.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                table.Rows.Remove(table.Rows[i]);
            }
        }

        private void orderDescription_Click(object sender, EventArgs e)
        {

        }

        private void productNameFind_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
