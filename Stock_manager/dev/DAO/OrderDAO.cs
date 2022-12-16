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
            MySqlCommand command;
            string query = String.Empty;
            string orderData = String.Empty;
            int orderSize = order.Count;
            for (int i = 0; i < orderSize; i++)
            {
                query = String.Format("select id from stock where name = {0}", order[i][0]); ;
                command = new MySqlCommand(query, get_connection());
                MySqlDataReader reader = command.ExecuteReader();
                int id = int.Parse(reader.Read().ToString());
                String.Concat(orderData, String.Format("{0}:{1};", id, order[i][1]));
            }
            query = String.Format("insert into orders customer, description values({0}, {1})", customer, orderData);
            command = new MySqlCommand(query, get_connection());
            command.ExecuteNonQuery();
            close_connection();
        }
    }
}
