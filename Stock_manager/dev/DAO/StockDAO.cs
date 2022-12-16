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
    }
}
