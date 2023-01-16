
namespace Stock_manager.Forms
{
    partial class AccountantForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerOrdersTable = new System.Windows.Forms.DataGridView();
            this.orderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseCustomerOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.reloadOrders = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.receipt = new System.Windows.Forms.Button();
            this.storekeeperOrdersTable = new System.Windows.Forms.DataGridView();
            this.stockOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseStorekeeperOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerOrdersLabel = new System.Windows.Forms.Label();
            this.capitzlizeOrdersLabel = new System.Windows.Forms.Label();
            this.customerOrders = new System.Windows.Forms.Button();
            this.storekeeperOrders = new System.Windows.Forms.Button();
            this.ordersTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.capitalize = new System.Windows.Forms.Button();
            this.reloadCustomerOrders = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.Button();
            this.reloadStorekeeperOrders = new System.Windows.Forms.Button();
            this.storekeeperOrdersLabel = new System.Windows.Forms.Label();
            this.customerOrderID = new System.Windows.Forms.Label();
            this.storekeeperOrderID = new System.Windows.Forms.Label();
            this.orderID = new System.Windows.Forms.Label();
            this.billLabel = new System.Windows.Forms.Label();
            this.capitalizeLabel = new System.Windows.Forms.Label();
            this.payLabel = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storekeeperOrdersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // customerOrdersTable
            // 
            this.customerOrdersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerOrdersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumber,
            this.customer,
            this.chooseCustomerOrder});
            this.customerOrdersTable.Location = new System.Drawing.Point(289, 53);
            this.customerOrdersTable.Name = "customerOrdersTable";
            this.customerOrdersTable.RowHeadersWidth = 51;
            this.customerOrdersTable.RowTemplate.Height = 24;
            this.customerOrdersTable.Size = new System.Drawing.Size(428, 150);
            this.customerOrdersTable.TabIndex = 0;
            this.customerOrdersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerOrdersTable_CellContentClick);
            // 
            // orderNumber
            // 
            this.orderNumber.HeaderText = "number";
            this.orderNumber.MinimumWidth = 6;
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Width = 125;
            // 
            // customer
            // 
            this.customer.HeaderText = "customer";
            this.customer.MinimumWidth = 6;
            this.customer.Name = "customer";
            this.customer.Width = 125;
            // 
            // chooseCustomerOrder
            // 
            this.chooseCustomerOrder.HeaderText = "choose";
            this.chooseCustomerOrder.MinimumWidth = 6;
            this.chooseCustomerOrder.Name = "chooseCustomerOrder";
            this.chooseCustomerOrder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chooseCustomerOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chooseCustomerOrder.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // reloadOrders
            // 
            this.reloadOrders.Location = new System.Drawing.Point(289, 217);
            this.reloadOrders.Name = "reloadOrders";
            this.reloadOrders.Size = new System.Drawing.Size(75, 23);
            this.reloadOrders.TabIndex = 2;
            this.reloadOrders.Text = "reload";
            this.reloadOrders.UseVisualStyleBackColor = true;
            this.reloadOrders.Click += new System.EventHandler(this.reloadOrders_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(68, 335);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 3;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // receipt
            // 
            this.receipt.Location = new System.Drawing.Point(37, 197);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(140, 23);
            this.receipt.TabIndex = 4;
            this.receipt.Text = "receipt";
            this.receipt.UseVisualStyleBackColor = true;
            this.receipt.Click += new System.EventHandler(this.receipt_Click);
            // 
            // storekeeperOrdersTable
            // 
            this.storekeeperOrdersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storekeeperOrdersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockOrderNumber,
            this.chooseStorekeeperOrder});
            this.storekeeperOrdersTable.Location = new System.Drawing.Point(289, 53);
            this.storekeeperOrdersTable.Name = "storekeeperOrdersTable";
            this.storekeeperOrdersTable.RowHeadersWidth = 51;
            this.storekeeperOrdersTable.RowTemplate.Height = 24;
            this.storekeeperOrdersTable.Size = new System.Drawing.Size(300, 150);
            this.storekeeperOrdersTable.TabIndex = 5;
            this.storekeeperOrdersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.storekeeperOrdersTable_CellContentClick);
            // 
            // stockOrderNumber
            // 
            this.stockOrderNumber.HeaderText = "number";
            this.stockOrderNumber.MinimumWidth = 6;
            this.stockOrderNumber.Name = "stockOrderNumber";
            this.stockOrderNumber.Width = 125;
            // 
            // chooseStorekeeperOrder
            // 
            this.chooseStorekeeperOrder.HeaderText = "choose";
            this.chooseStorekeeperOrder.MinimumWidth = 6;
            this.chooseStorekeeperOrder.Name = "chooseStorekeeperOrder";
            this.chooseStorekeeperOrder.Width = 125;
            // 
            // customerOrdersLabel
            // 
            this.customerOrdersLabel.AutoSize = true;
            this.customerOrdersLabel.Location = new System.Drawing.Point(407, 18);
            this.customerOrdersLabel.Name = "customerOrdersLabel";
            this.customerOrdersLabel.Size = new System.Drawing.Size(111, 17);
            this.customerOrdersLabel.TabIndex = 11;
            this.customerOrdersLabel.Text = "customer orders";
            // 
            // capitzlizeOrdersLabel
            // 
            this.capitzlizeOrdersLabel.AutoSize = true;
            this.capitzlizeOrdersLabel.Location = new System.Drawing.Point(407, 18);
            this.capitzlizeOrdersLabel.Name = "capitzlizeOrdersLabel";
            this.capitzlizeOrdersLabel.Size = new System.Drawing.Size(112, 17);
            this.capitzlizeOrdersLabel.TabIndex = 12;
            this.capitzlizeOrdersLabel.Text = "capitalize orders";
            // 
            // customerOrders
            // 
            this.customerOrders.Location = new System.Drawing.Point(37, 89);
            this.customerOrders.Name = "customerOrders";
            this.customerOrders.Size = new System.Drawing.Size(140, 23);
            this.customerOrders.TabIndex = 13;
            this.customerOrders.Text = "customer orders";
            this.customerOrders.UseVisualStyleBackColor = true;
            this.customerOrders.Click += new System.EventHandler(this.customerOrders_Click);
            // 
            // storekeeperOrders
            // 
            this.storekeeperOrders.Location = new System.Drawing.Point(37, 141);
            this.storekeeperOrders.Name = "storekeeperOrders";
            this.storekeeperOrders.Size = new System.Drawing.Size(140, 23);
            this.storekeeperOrders.TabIndex = 14;
            this.storekeeperOrders.Text = "storekeeper orders";
            this.storekeeperOrders.UseVisualStyleBackColor = true;
            this.storekeeperOrders.Click += new System.EventHandler(this.storekeeperOrders_Click);
            // 
            // ordersTable
            // 
            this.ordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.chooseOrder});
            this.ordersTable.Location = new System.Drawing.Point(289, 53);
            this.ordersTable.Name = "ordersTable";
            this.ordersTable.RowHeadersWidth = 51;
            this.ordersTable.RowTemplate.Height = 24;
            this.ordersTable.Size = new System.Drawing.Size(305, 150);
            this.ordersTable.TabIndex = 15;
            this.ordersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersTable_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "number";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // chooseOrder
            // 
            this.chooseOrder.HeaderText = "choose";
            this.chooseOrder.MinimumWidth = 6;
            this.chooseOrder.Name = "chooseOrder";
            this.chooseOrder.Width = 125;
            // 
            // capitalize
            // 
            this.capitalize.Location = new System.Drawing.Point(289, 259);
            this.capitalize.Name = "capitalize";
            this.capitalize.Size = new System.Drawing.Size(75, 23);
            this.capitalize.TabIndex = 16;
            this.capitalize.Text = "capitalize";
            this.capitalize.UseVisualStyleBackColor = true;
            this.capitalize.Click += new System.EventHandler(this.capitalize_Click);
            // 
            // reloadCustomerOrders
            // 
            this.reloadCustomerOrders.Location = new System.Drawing.Point(289, 217);
            this.reloadCustomerOrders.Name = "reloadCustomerOrders";
            this.reloadCustomerOrders.Size = new System.Drawing.Size(75, 23);
            this.reloadCustomerOrders.TabIndex = 17;
            this.reloadCustomerOrders.Text = "reload orders";
            this.reloadCustomerOrders.UseVisualStyleBackColor = true;
            this.reloadCustomerOrders.Click += new System.EventHandler(this.reloadCustomerOrders_Click);
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(289, 262);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(75, 23);
            this.pay.TabIndex = 18;
            this.pay.Text = "pay";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // bill
            // 
            this.bill.Location = new System.Drawing.Point(289, 262);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(75, 23);
            this.bill.TabIndex = 19;
            this.bill.Text = "bill";
            this.bill.UseVisualStyleBackColor = true;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // reloadStorekeeperOrders
            // 
            this.reloadStorekeeperOrders.Location = new System.Drawing.Point(289, 217);
            this.reloadStorekeeperOrders.Name = "reloadStorekeeperOrders";
            this.reloadStorekeeperOrders.Size = new System.Drawing.Size(75, 23);
            this.reloadStorekeeperOrders.TabIndex = 20;
            this.reloadStorekeeperOrders.Text = "reload";
            this.reloadStorekeeperOrders.UseVisualStyleBackColor = true;
            this.reloadStorekeeperOrders.Click += new System.EventHandler(this.reloadStorekeeperOrders_Click);
            // 
            // storekeeperOrdersLabel
            // 
            this.storekeeperOrdersLabel.AutoSize = true;
            this.storekeeperOrdersLabel.Location = new System.Drawing.Point(407, 18);
            this.storekeeperOrdersLabel.Name = "storekeeperOrdersLabel";
            this.storekeeperOrdersLabel.Size = new System.Drawing.Size(129, 17);
            this.storekeeperOrdersLabel.TabIndex = 21;
            this.storekeeperOrdersLabel.Text = "storekeeper orders";
            // 
            // customerOrderID
            // 
            this.customerOrderID.AutoSize = true;
            this.customerOrderID.Location = new System.Drawing.Point(388, 262);
            this.customerOrderID.Name = "customerOrderID";
            this.customerOrderID.Size = new System.Drawing.Size(19, 17);
            this.customerOrderID.TabIndex = 22;
            this.customerOrderID.Text = "id";
            // 
            // storekeeperOrderID
            // 
            this.storekeeperOrderID.AutoSize = true;
            this.storekeeperOrderID.Location = new System.Drawing.Point(388, 265);
            this.storekeeperOrderID.Name = "storekeeperOrderID";
            this.storekeeperOrderID.Size = new System.Drawing.Size(19, 17);
            this.storekeeperOrderID.TabIndex = 23;
            this.storekeeperOrderID.Text = "id";
            // 
            // orderID
            // 
            this.orderID.AutoSize = true;
            this.orderID.Location = new System.Drawing.Point(388, 265);
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(19, 17);
            this.orderID.TabIndex = 24;
            this.orderID.Text = "id";
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.ForeColor = System.Drawing.Color.Green;
            this.billLabel.Location = new System.Drawing.Point(286, 304);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(25, 17);
            this.billLabel.TabIndex = 25;
            this.billLabel.Text = "bill";
            this.billLabel.Visible = false;
            // 
            // capitalizeLabel
            // 
            this.capitalizeLabel.AutoSize = true;
            this.capitalizeLabel.ForeColor = System.Drawing.Color.Green;
            this.capitalizeLabel.Location = new System.Drawing.Point(286, 304);
            this.capitalizeLabel.Name = "capitalizeLabel";
            this.capitalizeLabel.Size = new System.Drawing.Size(67, 17);
            this.capitalizeLabel.TabIndex = 26;
            this.capitalizeLabel.Text = "capitalize";
            this.capitalizeLabel.Visible = false;
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.ForeColor = System.Drawing.Color.Green;
            this.payLabel.Location = new System.Drawing.Point(286, 304);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(31, 17);
            this.payLabel.TabIndex = 27;
            this.payLabel.Text = "pay";
            this.payLabel.Visible = false;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(289, 335);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(39, 17);
            this.error.TabIndex = 28;
            this.error.Text = "error";
            this.error.Visible = false;
            // 
            // AccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 450);
            this.Controls.Add(this.error);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.capitalizeLabel);
            this.Controls.Add(this.billLabel);
            this.Controls.Add(this.orderID);
            this.Controls.Add(this.storekeeperOrderID);
            this.Controls.Add(this.customerOrderID);
            this.Controls.Add(this.storekeeperOrdersLabel);
            this.Controls.Add(this.reloadStorekeeperOrders);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.reloadCustomerOrders);
            this.Controls.Add(this.capitalize);
            this.Controls.Add(this.ordersTable);
            this.Controls.Add(this.storekeeperOrders);
            this.Controls.Add(this.customerOrders);
            this.Controls.Add(this.capitzlizeOrdersLabel);
            this.Controls.Add(this.customerOrdersLabel);
            this.Controls.Add(this.storekeeperOrdersTable);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reloadOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerOrdersTable);
            this.Name = "AccountantForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storekeeperOrdersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerOrdersTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reloadOrders;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button receipt;
        private System.Windows.Forms.DataGridView storekeeperOrdersTable;
        private System.Windows.Forms.Label customerOrdersLabel;
        private System.Windows.Forms.Label capitzlizeOrdersLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewButtonColumn chooseCustomerOrder;
        private System.Windows.Forms.Button customerOrders;
        private System.Windows.Forms.Button storekeeperOrders;
        private System.Windows.Forms.DataGridView ordersTable;
        private System.Windows.Forms.Button capitalize;
        private System.Windows.Forms.Button reloadCustomerOrders;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Button bill;
        private System.Windows.Forms.Button reloadStorekeeperOrders;
        private System.Windows.Forms.Label storekeeperOrdersLabel;
        private System.Windows.Forms.Label customerOrderID;
        private System.Windows.Forms.Label storekeeperOrderID;
        private System.Windows.Forms.Label orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOrderNumber;
        private System.Windows.Forms.DataGridViewButtonColumn chooseStorekeeperOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn chooseOrder;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.Label capitalizeLabel;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.Label error;
    }
}