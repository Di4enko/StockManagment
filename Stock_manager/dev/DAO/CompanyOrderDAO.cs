using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_manager.dev.DAO
{
    class CompanyOrderDAO : DBConnection
    {
        public void insert(string query)
        {
            MySqlCommand command = new MySqlCommand(query, get_connection());
            command.ExecuteNonQuery();
            close_connection();
        }

        public List<string[]> get(string query, int param)
        {
            List<string[]> data = new List<string[]>();
            MySqlCommand command = new MySqlCommand(query, get_connection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string[] row = new string[param];
                for (int i = 0; i < param; i++)
                {
                    row[i] = reader.GetString(i);
                }
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
    }
}
