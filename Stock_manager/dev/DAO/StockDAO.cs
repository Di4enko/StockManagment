using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Stock_manager.dev.DAO
{
    class StockDAO : DBConnection
    {
        public void create_accountant_table(DataGridView dataGridView)
        {
            string query = "select product_name, price from stock";
            MySqlCommand command = new MySqlCommand(query, get_connection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                string[] row = new string[3];
                row[0] = reader.GetString(0);
                row[1] = null;
                row[2] = reader.GetString(1);
                data.Add(row);
            }
            reader.Close();
            close_connection();
            foreach(string[] d in data)
            {
                dataGridView.Rows.Add(d);
            }
        }

        public List<string[]> show_stock(string productName)
        {
            string query;
            if (productName != string.Empty)
            {
                query = String.Format("select product_name, count, reserve from stock where product_name = '{0}'", productName);
            } else
            {
                query = "select product_name, count, reserve from stock";
            }
            MySqlCommand command = new MySqlCommand(query, get_connection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                string[] row = new string[3];
                row[0] = reader.GetString(0);
                row[1] = reader.GetString(1);
                row[2] = reader.GetString(2);
                data.Add(row);
            }
            reader.Close();
            close_connection();
            return data;
        }

        public void update(string query)
        {
            MySqlCommand command = new MySqlCommand(query, get_connection());
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
