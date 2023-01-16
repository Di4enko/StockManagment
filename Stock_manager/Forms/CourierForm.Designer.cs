
namespace Stock_manager.Forms
{
    partial class CourierForm
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
            this.ordersTable = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deliver_btn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.reloadOrders_btn = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.orderDelivered = new System.Windows.Forms.Label();
            this.orderID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersTable
            // 
            this.ordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order,
            this.customer,
            this.mass,
            this.count,
            this.chooseOrder});
            this.ordersTable.Location = new System.Drawing.Point(248, 26);
            this.ordersTable.Name = "ordersTable";
            this.ordersTable.RowHeadersWidth = 51;
            this.ordersTable.RowTemplate.Height = 24;
            this.ordersTable.Size = new System.Drawing.Size(679, 334);
            this.ordersTable.TabIndex = 0;
            this.ordersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersTable_CellContentClick);
            // 
            // order
            // 
            this.order.HeaderText = "order";
            this.order.MinimumWidth = 6;
            this.order.Name = "order";
            this.order.Width = 125;
            // 
            // customer
            // 
            this.customer.HeaderText = "customer";
            this.customer.MinimumWidth = 6;
            this.customer.Name = "customer";
            this.customer.Width = 125;
            // 
            // mass
            // 
            this.mass.HeaderText = "mass";
            this.mass.MinimumWidth = 6;
            this.mass.Name = "mass";
            this.mass.Width = 125;
            // 
            // count
            // 
            this.count.HeaderText = "count";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.Width = 125;
            // 
            // chooseOrder
            // 
            this.chooseOrder.HeaderText = "choose";
            this.chooseOrder.MinimumWidth = 6;
            this.chooseOrder.Name = "chooseOrder";
            this.chooseOrder.Width = 125;
            // 
            // deliver_btn
            // 
            this.deliver_btn.Location = new System.Drawing.Point(91, 127);
            this.deliver_btn.Name = "deliver_btn";
            this.deliver_btn.Size = new System.Drawing.Size(75, 23);
            this.deliver_btn.TabIndex = 1;
            this.deliver_btn.Text = "deliver";
            this.deliver_btn.UseVisualStyleBackColor = true;
            this.deliver_btn.Click += new System.EventHandler(this.deliver_btn_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(91, 194);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 2;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // reloadOrders_btn
            // 
            this.reloadOrders_btn.Location = new System.Drawing.Point(248, 381);
            this.reloadOrders_btn.Name = "reloadOrders_btn";
            this.reloadOrders_btn.Size = new System.Drawing.Size(106, 23);
            this.reloadOrders_btn.TabIndex = 3;
            this.reloadOrders_btn.Text = "reload orders";
            this.reloadOrders_btn.UseVisualStyleBackColor = true;
            this.reloadOrders_btn.Click += new System.EventHandler(this.reloadOrders_btn_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(408, 387);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(39, 17);
            this.error.TabIndex = 4;
            this.error.Text = "error";
            this.error.Visible = false;
            // 
            // orderDelivered
            // 
            this.orderDelivered.AutoSize = true;
            this.orderDelivered.ForeColor = System.Drawing.Color.Green;
            this.orderDelivered.Location = new System.Drawing.Point(88, 82);
            this.orderDelivered.Name = "orderDelivered";
            this.orderDelivered.Size = new System.Drawing.Size(104, 17);
            this.orderDelivered.TabIndex = 5;
            this.orderDelivered.Text = "order delivered";
            this.orderDelivered.Visible = false;
            // 
            // orderID
            // 
            this.orderID.AutoSize = true;
            this.orderID.Location = new System.Drawing.Point(12, 130);
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(57, 17);
            this.orderID.TabIndex = 6;
            this.orderID.Text = "order id";
            // 
            // CourierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 450);
            this.Controls.Add(this.orderID);
            this.Controls.Add(this.orderDelivered);
            this.Controls.Add(this.error);
            this.Controls.Add(this.reloadOrders_btn);
            this.Controls.Add(this.back);
            this.Controls.Add(this.deliver_btn);
            this.Controls.Add(this.ordersTable);
            this.Name = "CourierForm";
            this.Text = "CourierForm";
            this.Load += new System.EventHandler(this.CourierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn mass;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.Button deliver_btn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button reloadOrders_btn;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.DataGridViewButtonColumn chooseOrder;
        private System.Windows.Forms.Label orderDelivered;
        private System.Windows.Forms.Label orderID;
    }
}