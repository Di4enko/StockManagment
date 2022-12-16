using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_manager.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private Point position = new Point();

        private void StartForm_Load(object sender, EventArgs e)
        {
            users.Items.Add(Post.Accountant);
            users.Items.Add(Post.Account_manager);
            users.Items.Add(Post.Admin);
            users.Items.Add(Post.Courier);
            users.Items.Add(Post.Purchasing_manager);
            users.Items.Add(Post.Storekeeper);
        }

        private void enter_btn_click(object sender, EventArgs e) 
        {
            switch (users.SelectedItem)
            {
                case Post.Admin:
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    break;
                case Post.Purchasing_manager:
                    this.Hide();
                    PurchasingManagerForm purchasingManagerForm = new PurchasingManagerForm();
                    purchasingManagerForm.Show();
                    break;
                case Post.Account_manager:
                    this.Hide();
                    AccountManagerForm accountManagerForm = new AccountManagerForm();
                    accountManagerForm.Show();
                    break;
                case Post.Storekeeper:
                    this.Hide();
                    StorekeeperForm storekeeperForm = new StorekeeperForm();
                    storekeeperForm.Show();
                    break;
                case Post.Accountant:
                    this.Hide();
                    AccountantForm accountantForm = new AccountantForm();
                    accountantForm.Show();
                    break;
                case Post.Courier:
                    this.Hide();
                    CourierForm courierForm = new CourierForm();
                    courierForm.Show();
                    break;
            }
        }

        private void exit_btn_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartForm_MouseDown(object Sender, MouseEventArgs e)
        {
            position.X = e.X;
            position.Y = e.Y;
        }

        private void StartForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - position.X;
                this.Top += e.Y - position.Y;
            }
        }
    }
}
