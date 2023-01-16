using Stock_manager.dev.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_manager.dev.Logic
{
    class CompanyOrdersManager
    {
        private CompanyOrderDAO orderDAO = new CompanyOrderDAO();
        private StockDAO stockDAO = new StockDAO();

        public void createOrder(List<string[]> products)
        {
            string status = "new";
            string description = String.Empty;
            foreach (string[] product in products)
            {
                string queryStock = String.Format("select id from stock where product_name = '{0}'", product[0]);
                string[] id = stockDAO.get(queryStock, 1).First();
                string productData = String.Format("{0}:{1};", id[0], product[1]);
                description = String.Concat(description, productData);
            }
            string query = String.Format("insert into companyorders (description, status) values('{0}', '{1}')", description, status);
            orderDAO.insert(query);
        }

        public List<string[]> getOrders()
        {
            string query = "select id, status from companyorders";
            List<string[]> data = orderDAO.get(query, 2);
            List<string[]> orders = new List<string[]>();
            foreach (string[] row in data)
            {
                string[] order = new string[3];
                order[0] = row[0];
                switch (row[1])
                {
                    case "new":
                        order[1] = "no";
                        order[2] = "no";
                        break;
                    case "payed":
                        order[1] = "yes";
                        order[2] = "no";
                        break;
                    case "arrived":
                        order[1] = "yes";
                        order[2] = "yes";
                        break;
                }
                orders.Add(order);
            }
            return orders;
        }

        public string getOrdersDescription(int id)
        {
            string order = String.Empty;
            string query = String.Format("select description from companyorders where id={0}", id);
            string description = orderDAO.get(query, 1).ToArray()[0][0];
            string[] productsCodes = description.Split(';');
            for (int i = 0; i < productsCodes.Length - 1; i++)
            {
                order = String.Concat(order, "Name: ");
                string[] productCpC = productsCodes[i].Split(':');
                int productID = int.Parse(productCpC[0]);
                string productCount = String.Format("   Count:{0}\n", (productCpC[1]));
                query = String.Format("select product_name from stock where id = {0}", productID);
                string product = stockDAO.get(query, 1).ToArray()[0][0];
                order = String.Concat(order, product);
                order = String.Concat(order, productCount);
            }
            return order;
        }

        public List<string[]> getStorekeeperOrders()
        {
            string query = "select id from companyorders where status='confirm'";
            List<string[]> orders = orderDAO.get(query, 1);
            return orders;
        }

        public List<string[]> getCapitalizeOrders()
        {
            string query = "select id from companyorders where status='payed'";
            List<string[]> orders = orderDAO.get(query, 1);
            return orders;
        }

        public void pay(int id)
        {
            string query = String.Format("update companyorders set status='payed' where id = {0}", id);
            orderDAO.update(query);
        }

        public void capitalize(int id)
        {
            string query = String.Format("update companyorders set status='capitzlize' where id = {0}", id);
            orderDAO.update(query);
            query = String.Format("select description from companyorders where id = {0}", id);
            List<string[]> products = orderDAO.get(query, 1);
            string[] productsCodes = products[0][0].Split(';');
            for (int i = 0; i < productsCodes.Length - 1; i++)
            {
                string[] productCpC = productsCodes[i].Split(':');
                int productID = int.Parse(productCpC[0]);
                int capitalizeCount = int.Parse(productCpC[1]);
                query = String.Format("select count from stock where id = {0}", productID);
                int count = int.Parse(stockDAO.get(query, 1)[0][0]);
                count += capitalizeCount;
                query = String.Format("update stock set count={0} where id ={1}", count, productID);
            }
        }
    }
}
