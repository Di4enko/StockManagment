
namespace Stock_manager.Forms
{
    partial class PurchasingManagerForm
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
            this.myOrdersTable = new System.Windows.Forms.DataGridView();
            this.orderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showMyOrders = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerOrdersTable = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processed = new System.Windows.Forms.DataGridViewButtonColumn();
            this.showOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.stockTable = new System.Windows.Forms.DataGridView();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.free = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToReserve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addToOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerOrdersLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myOrdersLabel = new System.Windows.Forms.Label();
            this.customerOrderDescription = new System.Windows.Forms.ListBox();
            this.myOrderDescription = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmOrder_btn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.showCustomerOrders_btn = new System.Windows.Forms.Button();
            this.showMyOrders_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.reloadCounterOrders_btn = new System.Windows.Forms.Button();
            this.reloadMyOrders_btn = new System.Windows.Forms.Button();
            this.reloadStock_btn = new System.Windows.Forms.Button();
            this.stockError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myOrdersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTable)).BeginInit();
            this.SuspendLayout();
            // 
            // myOrdersTable
            // 
            this.myOrdersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myOrdersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumber,
            this.payed,
            this.arrived,
            this.showMyOrders});
            this.myOrdersTable.Location = new System.Drawing.Point(185, 74);
            this.myOrdersTable.Name = "myOrdersTable";
            this.myOrdersTable.RowHeadersWidth = 51;
            this.myOrdersTable.RowTemplate.Height = 24;
            this.myOrdersTable.Size = new System.Drawing.Size(527, 220);
            this.myOrdersTable.TabIndex = 0;
            this.myOrdersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myOrdersTable_CellContentClick);
            // 
            // orderNumber
            // 
            this.orderNumber.HeaderText = "number";
            this.orderNumber.MinimumWidth = 6;
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Width = 125;
            // 
            // payed
            // 
            this.payed.HeaderText = "payed";
            this.payed.MinimumWidth = 6;
            this.payed.Name = "payed";
            this.payed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.payed.Width = 125;
            // 
            // arrived
            // 
            this.arrived.HeaderText = "arrived";
            this.arrived.MinimumWidth = 6;
            this.arrived.Name = "arrived";
            this.arrived.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.arrived.Width = 125;
            // 
            // showMyOrders
            // 
            this.showMyOrders.HeaderText = "show orders";
            this.showMyOrders.MinimumWidth = 6;
            this.showMyOrders.Name = "showMyOrders";
            this.showMyOrders.Width = 125;
            // 
            // customerOrdersTable
            // 
            this.customerOrdersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerOrdersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.stock,
            this.processed,
            this.showOrder});
            this.customerOrdersTable.Location = new System.Drawing.Point(185, 74);
            this.customerOrdersTable.Name = "customerOrdersTable";
            this.customerOrdersTable.RowHeadersWidth = 51;
            this.customerOrdersTable.Size = new System.Drawing.Size(473, 220);
            this.customerOrdersTable.TabIndex = 1;
            this.customerOrdersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.counterOrdersTable_CellContentClick);
            // 
            // number
            // 
            this.number.HeaderText = "number";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 125;
            // 
            // stock
            // 
            this.stock.HeaderText = "stock";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stock.Width = 60;
            // 
            // processed
            // 
            this.processed.HeaderText = "processed";
            this.processed.MinimumWidth = 6;
            this.processed.Name = "processed";
            this.processed.Width = 125;
            // 
            // showOrder
            // 
            this.showOrder.HeaderText = "show order";
            this.showOrder.MinimumWidth = 6;
            this.showOrder.Name = "showOrder";
            this.showOrder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.showOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.showOrder.Width = 110;
            // 
            // stockTable
            // 
            this.stockTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_name,
            this.free,
            this.reserve,
            this.count,
            this.addToReserve,
            this.addToOrder});
            this.stockTable.Location = new System.Drawing.Point(731, 74);
            this.stockTable.Name = "stockTable";
            this.stockTable.RowHeadersWidth = 51;
            this.stockTable.Size = new System.Drawing.Size(795, 220);
            this.stockTable.TabIndex = 2;
            this.stockTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockTable_CellContentClick);
            // 
            // product_name
            // 
            this.product_name.HeaderText = "product";
            this.product_name.MinimumWidth = 6;
            this.product_name.Name = "product_name";
            this.product_name.Width = 125;
            // 
            // free
            // 
            this.free.HeaderText = "free";
            this.free.MinimumWidth = 6;
            this.free.Name = "free";
            this.free.Width = 125;
            // 
            // reserve
            // 
            this.reserve.HeaderText = "reserve";
            this.reserve.MinimumWidth = 6;
            this.reserve.Name = "reserve";
            this.reserve.Width = 125;
            // 
            // count
            // 
            this.count.HeaderText = "count";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.Width = 125;
            // 
            // addToReserve
            // 
            this.addToReserve.HeaderText = "add to reserve";
            this.addToReserve.MinimumWidth = 6;
            this.addToReserve.Name = "addToReserve";
            this.addToReserve.Width = 125;
            // 
            // addToOrder
            // 
            this.addToOrder.HeaderText = "add to order";
            this.addToOrder.MinimumWidth = 6;
            this.addToOrder.Name = "addToOrder";
            this.addToOrder.Width = 125;
            // 
            // customerOrdersLabel
            // 
            this.customerOrdersLabel.AutoSize = true;
            this.customerOrdersLabel.Location = new System.Drawing.Point(397, 25);
            this.customerOrdersLabel.Name = "customerOrdersLabel";
            this.customerOrdersLabel.Size = new System.Drawing.Size(111, 17);
            this.customerOrdersLabel.TabIndex = 3;
            this.customerOrdersLabel.Text = "customer orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1111, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "stock";
            // 
            // myOrdersLabel
            // 
            this.myOrdersLabel.AutoSize = true;
            this.myOrdersLabel.Location = new System.Drawing.Point(418, 25);
            this.myOrdersLabel.Name = "myOrdersLabel";
            this.myOrdersLabel.Size = new System.Drawing.Size(71, 17);
            this.myOrdersLabel.TabIndex = 5;
            this.myOrdersLabel.Text = "my orders";
            // 
            // customerOrderDescription
            // 
            this.customerOrderDescription.FormattingEnabled = true;
            this.customerOrderDescription.ItemHeight = 16;
            this.customerOrderDescription.Location = new System.Drawing.Point(255, 412);
            this.customerOrderDescription.Name = "customerOrderDescription";
            this.customerOrderDescription.Size = new System.Drawing.Size(375, 180);
            this.customerOrderDescription.TabIndex = 6;
            // 
            // myOrderDescription
            // 
            this.myOrderDescription.FormattingEnabled = true;
            this.myOrderDescription.ItemHeight = 16;
            this.myOrderDescription.Location = new System.Drawing.Point(731, 412);
            this.myOrderDescription.Name = "myOrderDescription";
            this.myOrderDescription.Size = new System.Drawing.Size(506, 180);
            this.myOrderDescription.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(956, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "new order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "order description";
            // 
            // confirmOrder_btn
            // 
            this.confirmOrder_btn.Location = new System.Drawing.Point(1278, 412);
            this.confirmOrder_btn.Name = "confirmOrder_btn";
            this.confirmOrder_btn.Size = new System.Drawing.Size(75, 23);
            this.confirmOrder_btn.TabIndex = 10;
            this.confirmOrder_btn.Text = "confirm order";
            this.confirmOrder_btn.UseVisualStyleBackColor = true;
            this.confirmOrder_btn.Click += new System.EventHandler(this.confirmOrder_btn_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(56, 506);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 11;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // showCustomerOrders_btn
            // 
            this.showCustomerOrders_btn.Location = new System.Drawing.Point(34, 210);
            this.showCustomerOrders_btn.Name = "showCustomerOrders_btn";
            this.showCustomerOrders_btn.Size = new System.Drawing.Size(121, 23);
            this.showCustomerOrders_btn.TabIndex = 12;
            this.showCustomerOrders_btn.Text = "show orders";
            this.showCustomerOrders_btn.UseVisualStyleBackColor = true;
            this.showCustomerOrders_btn.Click += new System.EventHandler(this.showCounterOrders_btn_Click);
            // 
            // showMyOrders_btn
            // 
            this.showMyOrders_btn.Location = new System.Drawing.Point(34, 277);
            this.showMyOrders_btn.Name = "showMyOrders_btn";
            this.showMyOrders_btn.Size = new System.Drawing.Size(121, 23);
            this.showMyOrders_btn.TabIndex = 13;
            this.showMyOrders_btn.Text = "show my orders";
            this.showMyOrders_btn.UseVisualStyleBackColor = true;
            this.showMyOrders_btn.Click += new System.EventHandler(this.showMyOrders_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "name";
            // 
            // reloadCounterOrders_btn
            // 
            this.reloadCounterOrders_btn.Location = new System.Drawing.Point(212, 317);
            this.reloadCounterOrders_btn.Name = "reloadCounterOrders_btn";
            this.reloadCounterOrders_btn.Size = new System.Drawing.Size(109, 23);
            this.reloadCounterOrders_btn.TabIndex = 15;
            this.reloadCounterOrders_btn.Text = "reload orders";
            this.reloadCounterOrders_btn.UseVisualStyleBackColor = true;
            this.reloadCounterOrders_btn.Click += new System.EventHandler(this.reloadCounterOrders_btn_Click);
            // 
            // reloadMyOrders_btn
            // 
            this.reloadMyOrders_btn.Location = new System.Drawing.Point(185, 317);
            this.reloadMyOrders_btn.Name = "reloadMyOrders_btn";
            this.reloadMyOrders_btn.Size = new System.Drawing.Size(128, 23);
            this.reloadMyOrders_btn.TabIndex = 16;
            this.reloadMyOrders_btn.Text = "reload my orders";
            this.reloadMyOrders_btn.UseVisualStyleBackColor = true;
            this.reloadMyOrders_btn.Click += new System.EventHandler(this.reloadMyOrders_btn_Click);
            // 
            // reloadStock_btn
            // 
            this.reloadStock_btn.Location = new System.Drawing.Point(731, 317);
            this.reloadStock_btn.Name = "reloadStock_btn";
            this.reloadStock_btn.Size = new System.Drawing.Size(104, 23);
            this.reloadStock_btn.TabIndex = 17;
            this.reloadStock_btn.Text = "reload stock";
            this.reloadStock_btn.UseVisualStyleBackColor = true;
            this.reloadStock_btn.Click += new System.EventHandler(this.reloadStock_btn_Click);
            // 
            // stockError
            // 
            this.stockError.AutoSize = true;
            this.stockError.BackColor = System.Drawing.Color.Transparent;
            this.stockError.ForeColor = System.Drawing.Color.Red;
            this.stockError.Location = new System.Drawing.Point(728, 607);
            this.stockError.Name = "stockError";
            this.stockError.Size = new System.Drawing.Size(73, 17);
            this.stockError.TabIndex = 18;
            this.stockError.Text = "stockError";
            this.stockError.Visible = false;
            this.stockError.Click += new System.EventHandler(this.stockError_Click);
            // 
            // PurchasingManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 720);
            this.Controls.Add(this.stockError);
            this.Controls.Add(this.reloadStock_btn);
            this.Controls.Add(this.reloadMyOrders_btn);
            this.Controls.Add(this.reloadCounterOrders_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.showMyOrders_btn);
            this.Controls.Add(this.showCustomerOrders_btn);
            this.Controls.Add(this.back);
            this.Controls.Add(this.confirmOrder_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.myOrderDescription);
            this.Controls.Add(this.customerOrderDescription);
            this.Controls.Add(this.myOrdersLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerOrdersLabel);
            this.Controls.Add(this.stockTable);
            this.Controls.Add(this.customerOrdersTable);
            this.Controls.Add(this.myOrdersTable);
            this.Name = "PurchasingManagerForm";
            this.Text = "PurchasingManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.myOrdersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrdersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView myOrdersTable;
        private System.Windows.Forms.DataGridView customerOrdersTable;
        private System.Windows.Forms.DataGridView stockTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn free;
        private System.Windows.Forms.DataGridViewTextBoxColumn reserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewButtonColumn addToReserve;
        private System.Windows.Forms.DataGridViewButtonColumn addToOrder;
        private System.Windows.Forms.Label customerOrdersLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label myOrdersLabel;
        private System.Windows.Forms.ListBox customerOrderDescription;
        private System.Windows.Forms.ListBox myOrderDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button confirmOrder_btn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button showCustomerOrders_btn;
        private System.Windows.Forms.Button showMyOrders_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button reloadCounterOrders_btn;
        private System.Windows.Forms.Button reloadMyOrders_btn;
        private System.Windows.Forms.Button reloadStock_btn;
        private System.Windows.Forms.Label stockError;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewButtonColumn processed;
        private System.Windows.Forms.DataGridViewButtonColumn showOrder;
        private System.Windows.Forms.DataGridViewButtonColumn showMyOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn payed;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrived;
        private System.Windows.Forms.DataGridViewButtonColumn showMyOrders;
    }
}