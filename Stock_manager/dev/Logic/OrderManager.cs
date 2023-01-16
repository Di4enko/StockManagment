using Stock_manager.dev.DAO;
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
        private StockDAO stockDAO = new StockDAO();

        public void create_order(List<string[]> products, string customer)
        {
            List<string[]> order = new List<string[]>();
            foreach(string[] product in products)
            {
                    order.Add(product);
            }
            orderDAO.add_order(customer, order);
        }

        public string getOrderDescripton(int orderID)
        {
            return orderDAO.getOrder(orderID);
        }

        public void getOrders(string customer, DataGridView orders)
        {
            string query = String.Format("select id, status from orders where customer='{0}'", customer);
            List<string[]> data = orderDAO.getOrders(query, 2);
            foreach (string[] d in data)
            {
                orders.Rows.Add(d);
            }
        }

        public List<string[]> getOrders()
        {
            return orderDAO.getAllOrders();
        }

        public void managerGetOrder(int orderID, string manager)
        {
            orderDAO.managerGetOrder(orderID, manager);
        }

        public void confirmOrder(bool stockStatus, string orderID)
        {
            string query;
            if (stockStatus)
            {
                query = String.Format("update orders set status='offer', stock='yes' where id={0}", orderID);
            }
            else
            {
                query = String.Format("update orders set status='offer', stock='no' where id={0}", orderID);
            }
            orderDAO.confirmOrder(query);
        } 

        public void updateStatus(string status, string orderID)
        {
            string query = String.Format("update orders set status='{0}' where id={1}", status, orderID);
            orderDAO.update(query);
        }

        public List<string[]> getPurshasingOrders()
        {
            List<string[]> orders = new List<string[]>();
            string query = "Select id, stock from orders where status='payed'";
            orders = orderDAO.get(query, 2);
            return orders;
        }

        public List<string[]> getCourierOrders()
        {
            List<string[]> orders = new List<string[]>();
            string[] resOrder = new string[4];
            string query = "select id, customer, description from orders where status='assembled'";
            orders = orderDAO.get(query, 3);
            foreach (string[] order in orders)
            {
                List<string[]> resOrders = new List<string[]>();
                resOrder[0] = order[0];
                resOrder[1] = order[1];
                int count = 0;
                double weight = 0.0;
                string[] productsCodes = order[2].Split(';');
                for (int i = 0; i < productsCodes.Length - 1; i++)
                {
                    string[] productCpC = productsCodes[i].Split(':');
                    int productID = int.Parse(productCpC[0]);
                    count += int.Parse(productCpC[1]);
                    query = String.Format("select weight from stock where id = {0}", productID);
                    double orderWeight = double.Parse(stockDAO.get(query, 1).ToArray()[0][0]);
                    weight += orderWeight;
                }
                resOrder[2] = weight.ToString();
                resOrder[3] = count.ToString();
                resOrders.Add(resOrder);
            }
                return resOrders;
        }

        public void deliverOrder(int id)
        {
            string query = String.Format("update orders set status='delivered' where id={0}", id);
            orderDAO.update(query);
        }

        public List<string[]> getStorekeeperOrders()
        {
            string query = "select id, customer from orders where status='stock'";
            List<string[]> orders = orderDAO.get(query, 2);
            return orders;
        }

        public void collectOrder(int id)
        {
            string query = String.Format("update orders set status='assembled' where id={0}", id);
            orderDAO.update(query);
        }

        public List<string[]> getCustomerOrders()
        {
            string query = "select id, customer from orders where status='confirm'";
            List<string[]> orders = orderDAO.get(query, 2);
            return orders;
        }

        public void bill(int id)
        {
            string query = String.Format("update orders set status='bill' where id = {0}", id);
            orderDAO.update(query);
        }

        public void orderProcessed(int id)
        {
            string query = String.Format("update orders set status='stock' where id={0}", id);
            orderDAO.update(query);
        }
    }
}
