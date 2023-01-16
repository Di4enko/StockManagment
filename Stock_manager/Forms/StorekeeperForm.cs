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
    public partial class StorekeeperForm : Form
    {
        public StorekeeperForm()
        {
            InitializeComponent();
        }

        private OrderManager orderManager = new OrderManager();
        private int id = 0;

        private void reloadOrders_Click(object sender, EventArgs e)
        {
            ordersTable.Rows.Clear();
            List<string[]> ordersList = orderManager.getStorekeeperOrders();
            foreach (string[] order in ordersList)
            {
                ordersTable.Rows.Add(order);
            }
        }

        private void collect_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                error.Text = "you should choose order before deliver!";
                error.Visible = true;
            }
            else
            {
                collectLabel.Visible = true;
                error.Visible = false;
                orderManager.collectOrder(id);
            }
        }

        private void ordersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = int.Parse(e.RowIndex.ToString());
            if (e.ColumnIndex == 2) {
                //ошибка при пустой таблице
                int orderID = int.Parse(ordersTable.Rows[row].Cells[0].Value.ToString());
                string[] orders = orderManager.getOrderDescripton(orderID).Split(';');
                foreach (string order in orders)
                {
                    orderDescription.Items.Add(order);
                }
            } 
            if (e.ColumnIndex == 3)
            {
                //ошибка при пустой таблице
                id = int.Parse(ordersTable.Rows[row].Cells[0].Value.ToString());
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }
    }
}
