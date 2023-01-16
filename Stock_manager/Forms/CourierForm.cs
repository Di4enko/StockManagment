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
    public partial class CourierForm : Form
    {
        public CourierForm()
        {
            InitializeComponent();
        }

        private OrderManager orderManager = new OrderManager();
        private int id = 0;

        private void reloadOrders_btn_Click(object sender, EventArgs e)
        {
            ordersTable.Rows.Clear();
            List<string[]> ordersList = orderManager.getCourierOrders();
            foreach (string[] order in ordersList)
            {
                ordersTable.Rows.Add(order);
            }
        }

        private void ordersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = int.Parse(e.RowIndex.ToString());
            //ошибка при пустой таблице
            id = int.Parse(ordersTable.Rows[row].Cells[0].Value.ToString());
            orderID.Text = String.Format("order:{0}", id);
        }

        private void deliver_btn_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                error.Text = "you should choose order before deliver!";
                error.Visible = true;
                orderDelivered.Visible = false;
            } else
            {
                orderDelivered.Visible = true;
                error.Visible = false;
                orderManager.deliverOrder(id);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void CourierForm_Load(object sender, EventArgs e)
        {

        }
    }
}
