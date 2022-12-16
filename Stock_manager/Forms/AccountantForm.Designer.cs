
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
            this.products = new System.Windows.Forms.DataGridView();
            this.accountantName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createOrder_btn = new System.Windows.Forms.Button();
            this.nameError = new System.Windows.Forms.Label();
            this.productError = new System.Windows.Forms.Label();
            this.accountantOrder = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.products)).BeginInit();
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
            this.products.Size = new System.Drawing.Size(842, 269);
            this.products.TabIndex = 0;
            this.products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.products_CellContentClick);
            // 
            // accountantName
            // 
            this.accountantName.Location = new System.Drawing.Point(28, 288);
            this.accountantName.Name = "accountantName";
            this.accountantName.Size = new System.Drawing.Size(235, 22);
            this.accountantName.TabIndex = 1;
            this.accountantName.TextChanged += new System.EventHandler(this.accountantName_TextChanged);
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
            this.label3.Location = new System.Drawing.Point(290, 322);
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
            this.nameError.Click += new System.EventHandler(this.label5_Click);
            // 
            // productError
            // 
            this.productError.AutoSize = true;
            this.productError.ForeColor = System.Drawing.Color.Crimson;
            this.productError.Location = new System.Drawing.Point(290, 348);
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
            this.accountantOrder.Location = new System.Drawing.Point(293, 412);
            this.accountantOrder.Name = "accountantOrder";
            this.accountantOrder.Size = new System.Drawing.Size(842, 116);
            this.accountantOrder.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(673, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Your order";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            // AccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 574);
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
            this.Name = "AccountantForm";
            this.Text = "AccountantForm";
            ((System.ComponentModel.ISupportInitialize)(this.products)).EndInit();
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
    }
}