using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_manager.dev.DAO
{
    class DBConnection
    {

        private static DBConnection dbConnection;
        private const string connString = "Server=127.0.0.1;Port=3306;Username=dima;Password=D12112002r;Database=stock_maangment";
        private MySqlConnection connection = new MySqlConnection(connString);
        
        protected MySqlConnection get_connection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.OpenAsync();
            }
            return connection;
        }

        async protected void close_connection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                await connection.CloseAsync();
            }
        }
    }
}
