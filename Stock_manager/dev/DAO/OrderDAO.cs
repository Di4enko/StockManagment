using Stock_manager.dev.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Stock_manager.dev.Objects
{
    class OrderDAO : DBConnection
    {
        public void add_order(string customer, List<string[]> order)
        {
            string query = String.Empty;
            string orderData = String.Empty;
            int orderSize = order.Count;
            MySqlCommand command;
            MySqlDataReader reader;
            MySqlConnection connection = get_connection();
            for (int i = 0; i < orderSize; i++)
            {
                query = String.Format("select id from stock where product_name = '{0}'", order[i][0]); ;
                command = new MySqlCommand(query, connection);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int id = int.Parse(reader.GetString(0));
                    string productData = String.Format("{0}:{1};", id, order[i][1]);
                    orderData = String.Concat(orderData, productData);
                }
                reader.Close();
            }
            query = String.Format("insert into orders (customer, description) values('{0}', '{1}')", customer, orderData);
            command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            close_connection();
        }

        public List<string[]> getOrders(string query, int param)
        {
            List<string[]> orders = new List<string[]>();
            MySqlConnection connection = get_connection();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string[] order = new string[param];
                for (int i = 0; i < param; i++)
                {
                    order[i] = reader.GetString(i);
                }
                orders.Add(order);
            }
            reader.Close();
            close_connection();
            return orders;
        }

        public List<string[]> getAllOrders()
        {
            List<string[]> orders = new List<string[]>(); 
            string query = "Select id, customer from orders";
            MySqlCommand commmnd = new MySqlCommand(query, get_connection());
            MySqlDataReader reader = commmnd.ExecuteReader();
            while (reader.Read())
            {
                string[] order = new string[3];
                order[0] = reader.GetString(0);
                order[1] = reader.GetString(1);
                //Add date information
                order[2] = String.Empty;
                orders.Add(order);
            }
            reader.Close();
            close_connection();
            return orders;
        }

        public string getOrder(int orderID) 
        {
            string query = String.Format("select description from orders where id = {0}", orderID);
            MySqlCommand command = new MySqlCommand(query, get_connection());
            MySqlDataReader reader = command.ExecuteReader();
            return parseOrder(reader);
        }

        private string parseOrder(MySqlDataReader reader)
        {
            MySqlConnection connection = get_connection();
            string order = String.Empty;
            if (reader.Read()) 
            {
            string orderInf = reader.GetString(0);
            string[] productsCodes = orderInf.Split(';');
            for (int i = 0; i < productsCodes.Length - 1; i++)
            {
                order = String.Concat(order, "Name: ");
                string[] productCpC = productsCodes[i].Split(':');
                int productID = int.Parse(productCpC[0]);
                string productCount = String.Format("   Count:{0};", (productCpC[1]));
                string query = String.Format("select product_name from stock where id = {0}", productID);
                MySqlCommand command = new MySqlCommand(query, connection);
                reader.Close();
                reader = command.ExecuteReader();
                reader.Read();
                order = String.Concat(order, reader.GetString(0));
                order = String.Concat(order, productCount);
            }
                reader.Close();
                close_connection();
            }
            return order;
        }

        public void managerGetOrder(int orderID, string manager)
        {
            string query = String.Format("update orders set manager = '{0}' where id = {1}", manager, orderID);
            MySqlCommand command = new MySqlCommand(query, get_connection());
            command.ExecuteNonQuery();
        }

        public void confirmOrder(string query)
        {
            MySqlConnection connection = get_connection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            close_connection();
        }

        public void update(string query)
        {
            MySqlConnection connection = get_connection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            close_connection();
        }

        public List<string[]> get(string query, int param)
        {
            List<string[]> rows = new List<string[]>();
            MySqlCommand commmnd = new MySqlCommand(query, get_connection());
            MySqlDataReader reader = commmnd.ExecuteReader();
            while (reader.Read())
            {
                string[] row = new string[param];
                for (int i = 0; i < param; i++)
                {
                    row[i] = reader.GetString(i);
                }
                rows.Add(row);
            }
            reader.Close();
            close_connection();
            return rows;
        }
    }
}
