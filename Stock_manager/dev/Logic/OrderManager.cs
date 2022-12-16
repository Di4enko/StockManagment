using Stock_manager.dev.Objects;
using Stock_manager.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_manager.dev.Logic
{
    class OrderManager
    {
        private OrderDAO orderDAO = new OrderDAO();
        private AccountManagerForm managerForm = new AccountManagerForm();

        public void create_order(DataGridView dataGridView, string customer)
        {
            List<string[]> order = new List<string[]>();
            string[] product = new string[3];
            int size = dataGridView.Rows.Count;
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["add"].Value.ToString())) {
                    product[0] = row.Cells[0].Value.ToString();
                    product[1] = row.Cells[1].Value.ToString();
                    order.Add(product);
                }
            }
            orderDAO.add_order(customer, order);
            managerForm.addOrder(order);
        }

    }
}
