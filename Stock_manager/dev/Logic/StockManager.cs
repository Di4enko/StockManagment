using MySql.Data.MySqlClient;
using Stock_manager.dev.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_manager.dev.Logic
{
    class StockManager
    {
        private StockDAO stockDAO = new StockDAO();

        public void showStock(string productName, DataGridView stockTable)
        {
            List<string[]> data = stockDAO.show_stock(productName);
            foreach (string[] d in data)
            {
                stockTable.Rows.Add(d);
            }
        }

        public void updateReserve(string product, int reserve)
        {
            string query = String.Format("update stock set reserve={0} where product_name='{1}'", reserve, product);
            stockDAO.update(query);
        }

        public List<string[]> getPurshasingStock()
        {
            List<string[]> products = new List<string[]>();
            string query = "Select product_name, count, reserve from stock";
            products = stockDAO.get(query, 3);
            foreach (string[] product in products)
            {
                string free = (int.Parse(product[1]) - int.Parse(product[2])).ToString();
                product[1] = free;
            }
            return products;
        }
    }
}
