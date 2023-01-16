using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private bool errors = false;

        private void StartForm_Load(object sender, EventArgs e)
        {
            users.Items.Add(Post.Customer);
            users.Items.Add(Post.Customer_manager);
            users.Items.Add(Post.Accountant);
            users.Items.Add(Post.Courier);
            users.Items.Add(Post.Purchasing_manager);
            users.Items.Add(Post.Storekeeper);
        }

        private void enter_btn_click(object sender, EventArgs e) 
        {
            errors = false;
            if (name.Text == String.Empty)
            {
                error.Text = "Name can not be empty";
                error.Visible = true;
                errors = true;
            }
            else if (!Regex.IsMatch(name.Text, @"^[a-zA-Z]+$"))
            {
                error.Text = "Name can not contains numbers!";
                error.Visible = true;
                errors = true;
            }
            if (!errors)
            {
                switch (users.SelectedItem)
                {
                    case Post.Customer:
                        this.Hide();
                        CustomerForm adminForm = new CustomerForm();
                        adminForm.Show();
                        break;
                    case Post.Purchasing_manager:
                        this.Hide();
                        PurchasingManagerForm purchasingManagerForm = new PurchasingManagerForm();
                        purchasingManagerForm.Show();
                        break;
                    case Post.Customer_manager:
                        this.Hide();
                        CustomerManagerForm accountManagerForm = new CustomerManagerForm(name.Text.ToString());
                        accountManagerForm.Show();
                        break;
                    case Post.Storekeeper:
                        this.Hide();
                        StorekeeperForm storekeeperForm = new StorekeeperForm();
                        storekeeperForm.Show();
                        break;
                    case Post.Accountant:
                        this.Hide();
                        AccountantForm accountantForm = new AccountantForm(name.Text.ToString());
                        accountantForm.Show();
                        break;
                    case Post.Courier:
                        this.Hide();
                        CourierForm courierForm = new CourierForm();
                        courierForm.Show();
                        break;
                }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
