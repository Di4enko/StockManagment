
namespace Stock_manager.Forms
{
    partial class CustomerForm
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
            this.products = new System.Windows.Forms.DataGridView();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.accountantName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createOrder_btn = new System.Windows.Forms.Button();
            this.nameError = new System.Windows.Forms.Label();
            this.productError = new System.Windows.Forms.Label();
            this.accountantOrder = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.placedOrder = new System.Windows.Forms.Label();
            this.myOrders = new System.Windows.Forms.DataGridView();
            this.orderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.orderDescription = new System.Windows.Forms.ListBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.pay_btn = new System.Windows.Forms.Button();
            this.showOrders_btn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.payLabel = new System.Windows.Forms.Label();
            this.cancelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // products
            // 
            this.products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.count,
            this.price,
            this.add});
            this.products.Location = new System.Drawing.Point(293, 41);
            this.products.Name = "products";
            this.products.RowHeadersWidth = 51;
            this.products.RowTemplate.Height = 24;
            this.products.Size = new System.Drawing.Size(842, 194);
            this.products.TabIndex = 0;
            this.products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.products_CellContentClick);
            // 
            // product
            // 
            this.product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product.HeaderText = "product";
            this.product.MinimumWidth = 6;
            this.product.Name = "product";
            this.product.ReadOnly = true;
            // 
            // count
            // 
            this.count.HeaderText = "count";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // add
            // 
            this.add.HeaderText = "add";
            this.add.MinimumWidth = 6;
            this.add.Name = "add";
            this.add.Width = 125;
            // 
            // accountantName
            // 
            this.accountantName.Location = new System.Drawing.Point(28, 288);
            this.accountantName.Name = "accountantName";
            this.accountantName.Size = new System.Drawing.Size(235, 22);
            this.accountantName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input your name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(673, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "*Double click on product name to get description\r\n";
            // 
            // createOrder_btn
            // 
            this.createOrder_btn.Location = new System.Drawing.Point(82, 342);
            this.createOrder_btn.Name = "createOrder_btn";
            this.createOrder_btn.Size = new System.Drawing.Size(101, 23);
            this.createOrder_btn.TabIndex = 5;
            this.createOrder_btn.Text = "Create order";
            this.createOrder_btn.UseVisualStyleBackColor = true;
            this.createOrder_btn.Click += new System.EventHandler(this.createOrder_btn_click);
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.ForeColor = System.Drawing.Color.Crimson;
            this.nameError.Location = new System.Drawing.Point(25, 253);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(75, 17);
            this.nameError.TabIndex = 7;
            this.nameError.Text = "nameError";
            this.nameError.Visible = false;
            // 
            // productError
            // 
            this.productError.AutoSize = true;
            this.productError.ForeColor = System.Drawing.Color.Crimson;
            this.productError.Location = new System.Drawing.Point(290, 278);
            this.productError.Name = "productError";
            this.productError.Size = new System.Drawing.Size(88, 17);
            this.productError.TabIndex = 8;
            this.productError.Text = "productError";
            this.productError.Visible = false;
            // 
            // accountantOrder
            // 
            this.accountantOrder.FormattingEnabled = true;
            this.accountantOrder.ItemHeight = 16;
            this.accountantOrder.Location = new System.Drawing.Point(293, 342);
            this.accountantOrder.Name = "accountantOrder";
            this.accountantOrder.Size = new System.Drawing.Size(842, 116);
            this.accountantOrder.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(673, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Your order";
            // 
            // placedOrder
            // 
            this.placedOrder.AutoSize = true;
            this.placedOrder.BackColor = System.Drawing.SystemColors.Control;
            this.placedOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.placedOrder.ForeColor = System.Drawing.Color.Green;
            this.placedOrder.Location = new System.Drawing.Point(23, 168);
            this.placedOrder.Name = "placedOrder";
            this.placedOrder.Size = new System.Drawing.Size(252, 25);
            this.placedOrder.TabIndex = 11;
            this.placedOrder.Text = "Your order has been placed";
            this.placedOrder.Visible = false;
            // 
            // myOrders
            // 
            this.myOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumber,
            this.status});
            this.myOrders.Location = new System.Drawing.Point(12, 525);
            this.myOrders.Name = "myOrders";
            this.myOrders.RowHeadersWidth = 51;
            this.myOrders.RowTemplate.Height = 24;
            this.myOrders.Size = new System.Drawing.Size(300, 194);
            this.myOrders.TabIndex = 12;
            this.myOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myOrders_CellClick);
            // 
            // orderNumber
            // 
            this.orderNumber.HeaderText = "orderNumber";
            this.orderNumber.MinimumWidth = 6;
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "orderStatus";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(89, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "My orders";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(642, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Order description";
            // 
            // orderDescription
            // 
            this.orderDescription.FormattingEnabled = true;
            this.orderDescription.ItemHeight = 16;
            this.orderDescription.Location = new System.Drawing.Point(330, 525);
            this.orderDescription.Name = "orderDescription";
            this.orderDescription.Size = new System.Drawing.Size(805, 132);
            this.orderDescription.TabIndex = 15;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(455, 696);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(75, 23);
            this.confirm_btn.TabIndex = 16;
            this.confirm_btn.Text = "confirm";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(706, 696);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 17;
            this.cancel_btn.Text = "cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // pay_btn
            // 
            this.pay_btn.Location = new System.Drawing.Point(959, 696);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(75, 23);
            this.pay_btn.TabIndex = 18;
            this.pay_btn.Text = "pay";
            this.pay_btn.UseVisualStyleBackColor = true;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // showOrders_btn
            // 
            this.showOrders_btn.Location = new System.Drawing.Point(94, 735);
            this.showOrders_btn.Name = "showOrders_btn";
            this.showOrders_btn.Size = new System.Drawing.Size(128, 23);
            this.showOrders_btn.TabIndex = 19;
            this.showOrders_btn.Text = "show orders";
            this.showOrders_btn.UseVisualStyleBackColor = true;
            this.showOrders_btn.Click += new System.EventHandler(this.showOrders_btn_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(94, 388);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 20;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.ForeColor = System.Drawing.Color.Green;
            this.confirmLabel.Location = new System.Drawing.Point(452, 735);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(54, 17);
            this.confirmLabel.TabIndex = 21;
            this.confirmLabel.Text = "confirm";
            this.confirmLabel.Visible = false;
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.ForeColor = System.Drawing.Color.Green;
            this.payLabel.Location = new System.Drawing.Point(956, 735);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(31, 17);
            this.payLabel.TabIndex = 22;
            this.payLabel.Text = "pay";
            this.payLabel.Visible = false;
            // 
            // cancelLabel
            // 
            this.cancelLabel.AutoSize = true;
            this.cancelLabel.ForeColor = System.Drawing.Color.Green;
            this.cancelLabel.Location = new System.Drawing.Point(703, 741);
            this.cancelLabel.Name = "cancelLabel";
            this.cancelLabel.Size = new System.Drawing.Size(49, 17);
            this.cancelLabel.TabIndex = 23;
            this.cancelLabel.Text = "cancel";
            this.cancelLabel.Visible = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 785);
            this.Controls.Add(this.cancelLabel);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.back);
            this.Controls.Add(this.showOrders_btn);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.orderDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.myOrders);
            this.Controls.Add(this.placedOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accountantOrder);
            this.Controls.Add(this.productError);
            this.Controls.Add(this.nameError);
            this.Controls.Add(this.createOrder_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountantName);
            this.Controls.Add(this.products);
            this.MinimumSize = new System.Drawing.Size(1176, 621);
            this.Name = "CustomerForm";
            this.Text = "AccountantForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView products;
        private System.Windows.Forms.TextBox accountantName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createOrder_btn;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label productError;
        private System.Windows.Forms.ListBox accountantOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewButtonColumn add;
        private System.Windows.Forms.Label placedOrder;
        private System.Windows.Forms.DataGridView myOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox orderDescription;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.Button showOrders_btn;
        private System.Windows.Forms.Button back;
        protected System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label payLabel;
        protected System.Windows.Forms.Label cancelLabel;
    }
}