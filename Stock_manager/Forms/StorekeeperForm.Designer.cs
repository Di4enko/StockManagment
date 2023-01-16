
namespace Stock_manager.Forms
{
    partial class StorekeeperForm
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
            this.reloadOrders = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.collect = new System.Windows.Forms.Button();
            this.ordersTable = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.choose = new System.Windows.Forms.DataGridViewButtonColumn();
            this.orderDescription = new System.Windows.Forms.ListBox();
            this.error = new System.Windows.Forms.Label();
            this.collectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // reloadOrders
            // 
            this.reloadOrders.Location = new System.Drawing.Point(220, 245);
            this.reloadOrders.Name = "reloadOrders";
            this.reloadOrders.Size = new System.Drawing.Size(118, 23);
            this.reloadOrders.TabIndex = 0;
            this.reloadOrders.Text = "reload orders";
            this.reloadOrders.UseVisualStyleBackColor = true;
            this.reloadOrders.Click += new System.EventHandler(this.reloadOrders_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(82, 245);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // collect
            // 
            this.collect.Location = new System.Drawing.Point(82, 161);
            this.collect.Name = "collect";
            this.collect.Size = new System.Drawing.Size(75, 23);
            this.collect.TabIndex = 2;
            this.collect.Text = "collect";
            this.collect.UseVisualStyleBackColor = true;
            this.collect.Click += new System.EventHandler(this.collect_Click);
            // 
            // ordersTable
            // 
            this.ordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.customer,
            this.showOrder,
            this.choose});
            this.ordersTable.Location = new System.Drawing.Point(220, 12);
            this.ordersTable.Name = "ordersTable";
            this.ordersTable.RowHeadersWidth = 51;
            this.ordersTable.RowTemplate.Height = 24;
            this.ordersTable.Size = new System.Drawing.Size(549, 212);
            this.ordersTable.TabIndex = 3;
            this.ordersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersTable_CellContentClick);
            // 
            // number
            // 
            this.number.HeaderText = "number";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.Width = 125;
            // 
            // customer
            // 
            this.customer.HeaderText = "customer";
            this.customer.MinimumWidth = 6;
            this.customer.Name = "customer";
            this.customer.Width = 125;
            // 
            // showOrder
            // 
            this.showOrder.HeaderText = "show order";
            this.showOrder.MinimumWidth = 6;
            this.showOrder.Name = "showOrder";
            this.showOrder.Width = 125;
            // 
            // choose
            // 
            this.choose.HeaderText = "choose";
            this.choose.MinimumWidth = 6;
            this.choose.Name = "choose";
            this.choose.Width = 125;
            // 
            // orderDescription
            // 
            this.orderDescription.FormattingEnabled = true;
            this.orderDescription.ItemHeight = 16;
            this.orderDescription.Location = new System.Drawing.Point(268, 290);
            this.orderDescription.Name = "orderDescription";
            this.orderDescription.Size = new System.Drawing.Size(426, 100);
            this.orderDescription.TabIndex = 4;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(268, 397);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(39, 17);
            this.error.TabIndex = 5;
            this.error.Text = "error";
            this.error.Visible = false;
            // 
            // collectLabel
            // 
            this.collectLabel.AutoSize = true;
            this.collectLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.collectLabel.Location = new System.Drawing.Point(65, 104);
            this.collectLabel.Name = "collectLabel";
            this.collectLabel.Size = new System.Drawing.Size(102, 17);
            this.collectLabel.TabIndex = 6;
            this.collectLabel.Text = "order collected";
            this.collectLabel.Visible = false;
            // 
            // StorekeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.collectLabel);
            this.Controls.Add(this.error);
            this.Controls.Add(this.orderDescription);
            this.Controls.Add(this.ordersTable);
            this.Controls.Add(this.collect);
            this.Controls.Add(this.back);
            this.Controls.Add(this.reloadOrders);
            this.Name = "StorekeeperForm";
            this.Text = "StorekeeperForm";
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reloadOrders;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button collect;
        private System.Windows.Forms.DataGridView ordersTable;
        private System.Windows.Forms.ListBox orderDescription;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewButtonColumn showOrder;
        private System.Windows.Forms.DataGridViewButtonColumn choose;
        private System.Windows.Forms.Label collectLabel;
    }
}