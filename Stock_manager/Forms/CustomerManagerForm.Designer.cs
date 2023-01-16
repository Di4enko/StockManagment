
namespace Stock_manager.Forms
{
    partial class CustomerManagerForm
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
            this.showStock_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.reloadOrders_btn = new System.Windows.Forms.Button();
            this.managerName = new System.Windows.Forms.Label();
            this.inStock_btn = new System.Windows.Forms.Button();
            this.notInStock_btn = new System.Windows.Forms.Button();
            this.stockTable = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.free = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productNameFind = new System.Windows.Forms.TextBox();
            this.productName_label = new System.Windows.Forms.Label();
            this.orderDescription = new System.Windows.Forms.ListBox();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showOrder_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTable)).BeginInit();
            this.SuspendLayout();
            // 
            // showStock_btn
            // 
            this.showStock_btn.Location = new System.Drawing.Point(1064, 495);
            this.showStock_btn.Name = "showStock_btn";
            this.showStock_btn.Size = new System.Drawing.Size(122, 27);
            this.showStock_btn.TabIndex = 1;
            this.showStock_btn.Text = "Show stock";
            this.showStock_btn.UseVisualStyleBackColor = true;
            this.showStock_btn.Click += new System.EventHandler(this.showStock_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(55, 274);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(122, 23);
            this.return_btn.TabIndex = 4;
            this.return_btn.Text = "Back";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.back_Click);
            // 
            // orders
            // 
            this.orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.accountant,
            this.date,
            this.showOrder_btn});
            this.orders.Location = new System.Drawing.Point(349, 57);
            this.orders.Name = "orders";
            this.orders.RowHeadersWidth = 51;
            this.orders.RowTemplate.Height = 24;
            this.orders.Size = new System.Drawing.Size(554, 310);
            this.orders.TabIndex = 5;
            this.orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orders_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(540, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Order Description";
            // 
            // reloadOrders_btn
            // 
            this.reloadOrders_btn.Location = new System.Drawing.Point(55, 106);
            this.reloadOrders_btn.Name = "reloadOrders_btn";
            this.reloadOrders_btn.Size = new System.Drawing.Size(122, 26);
            this.reloadOrders_btn.TabIndex = 9;
            this.reloadOrders_btn.Text = "Reload orders";
            this.reloadOrders_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reloadOrders_btn.UseVisualStyleBackColor = true;
            this.reloadOrders_btn.Click += new System.EventHandler(this.reloadOrders_btn_Click);
            // 
            // managerName
            // 
            this.managerName.AutoSize = true;
            this.managerName.Location = new System.Drawing.Point(93, 25);
            this.managerName.Name = "managerName";
            this.managerName.Size = new System.Drawing.Size(43, 17);
            this.managerName.TabIndex = 10;
            this.managerName.Text = "name";
            this.managerName.Click += new System.EventHandler(this.managerName_Click);
            // 
            // inStock_btn
            // 
            this.inStock_btn.Location = new System.Drawing.Point(367, 594);
            this.inStock_btn.Name = "inStock_btn";
            this.inStock_btn.Size = new System.Drawing.Size(178, 23);
            this.inStock_btn.TabIndex = 11;
            this.inStock_btn.Text = "items in stock";
            this.inStock_btn.UseVisualStyleBackColor = true;
            this.inStock_btn.Click += new System.EventHandler(this.inStock_btn_Click);
            // 
            // notInStock_btn
            // 
            this.notInStock_btn.Location = new System.Drawing.Point(691, 594);
            this.notInStock_btn.Name = "notInStock_btn";
            this.notInStock_btn.Size = new System.Drawing.Size(176, 23);
            this.notInStock_btn.TabIndex = 12;
            this.notInStock_btn.Text = "items not in stock";
            this.notInStock_btn.UseVisualStyleBackColor = true;
            this.notInStock_btn.Click += new System.EventHandler(this.notInStock_btn_Click);
            // 
            // stockTable
            // 
            this.stockTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.free,
            this.reserve});
            this.stockTable.Location = new System.Drawing.Point(1064, 57);
            this.stockTable.Name = "stockTable";
            this.stockTable.RowHeadersWidth = 51;
            this.stockTable.RowTemplate.Height = 24;
            this.stockTable.Size = new System.Drawing.Size(429, 357);
            this.stockTable.TabIndex = 13;
            // 
            // productName
            // 
            this.productName.HeaderText = "product name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.Width = 125;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(582, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Orders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1249, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Stock";
            // 
            // productNameFind
            // 
            this.productNameFind.Location = new System.Drawing.Point(1154, 444);
            this.productNameFind.Name = "productNameFind";
            this.productNameFind.Size = new System.Drawing.Size(260, 22);
            this.productNameFind.TabIndex = 16;
            this.productNameFind.TextChanged += new System.EventHandler(this.productNameFind_TextChanged);
            // 
            // productName_label
            // 
            this.productName_label.AutoSize = true;
            this.productName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productName_label.Location = new System.Drawing.Point(1059, 444);
            this.productName_label.Name = "productName_label";
            this.productName_label.Size = new System.Drawing.Size(79, 25);
            this.productName_label.TabIndex = 19;
            this.productName_label.Text = "Product";
            // 
            // orderDescription
            // 
            this.orderDescription.FormattingEnabled = true;
            this.orderDescription.ItemHeight = 16;
            this.orderDescription.Location = new System.Drawing.Point(367, 429);
            this.orderDescription.Name = "orderDescription";
            this.orderDescription.Size = new System.Drawing.Size(500, 148);
            this.orderDescription.TabIndex = 21;
            // 
            // orderID
            // 
            this.orderID.HeaderText = "№";
            this.orderID.MinimumWidth = 6;
            this.orderID.Name = "orderID";
            this.orderID.ReadOnly = true;
            this.orderID.Width = 125;
            // 
            // accountant
            // 
            this.accountant.HeaderText = "accountant";
            this.accountant.MinimumWidth = 6;
            this.accountant.Name = "accountant";
            this.accountant.ReadOnly = true;
            this.accountant.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 125;
            // 
            // showOrder_btn
            // 
            this.showOrder_btn.HeaderText = "show order";
            this.showOrder_btn.MinimumWidth = 6;
            this.showOrder_btn.Name = "showOrder_btn";
            this.showOrder_btn.Width = 125;
            // 
            // CustomerManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1564, 706);
            this.Controls.Add(this.orderDescription);
            this.Controls.Add(this.productName_label);
            this.Controls.Add(this.productNameFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stockTable);
            this.Controls.Add(this.notInStock_btn);
            this.Controls.Add(this.inStock_btn);
            this.Controls.Add(this.managerName);
            this.Controls.Add(this.reloadOrders_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.showStock_btn);
            this.Name = "CustomerManagerForm";
            this.Text = "AccountManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showStock_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.DataGridView orders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reloadOrders_btn;
        private System.Windows.Forms.DataGridViewButtonColumn getOrder_btn;
        private System.Windows.Forms.Label managerName;
        private System.Windows.Forms.Button inStock_btn;
        private System.Windows.Forms.Button notInStock_btn;
        private System.Windows.Forms.DataGridView stockTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn free;
        private System.Windows.Forms.DataGridViewTextBoxColumn reserve;
        private System.Windows.Forms.TextBox productNameFind;
        private System.Windows.Forms.Label productName_label;
        private System.Windows.Forms.ListBox orderDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountant;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewButtonColumn showOrder_btn;
    }
}