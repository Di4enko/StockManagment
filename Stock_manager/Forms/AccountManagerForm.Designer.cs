
namespace Stock_manager.Forms
{
    partial class AccountManagerForm
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
            this.showOrders_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.DataGridView();
            this.accountant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.get_order = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orders)).BeginInit();
            this.SuspendLayout();
            // 
            // showStock_btn
            // 
            this.showStock_btn.Location = new System.Drawing.Point(55, 295);
            this.showStock_btn.Name = "showStock_btn";
            this.showStock_btn.Size = new System.Drawing.Size(122, 27);
            this.showStock_btn.TabIndex = 1;
            this.showStock_btn.Text = "Show stock";
            this.showStock_btn.UseVisualStyleBackColor = true;
            // 
            // showOrders_btn
            // 
            this.showOrders_btn.Location = new System.Drawing.Point(55, 201);
            this.showOrders_btn.Name = "showOrders_btn";
            this.showOrders_btn.Size = new System.Drawing.Size(122, 29);
            this.showOrders_btn.TabIndex = 2;
            this.showOrders_btn.Text = "Show my orders";
            this.showOrders_btn.UseVisualStyleBackColor = true;
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(55, 392);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(122, 23);
            this.return_btn.TabIndex = 4;
            this.return_btn.Text = "Back";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // date
            // 
            this.orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountant,
            this.date,
            this.get_order});
            this.orders.Location = new System.Drawing.Point(309, 12);
            this.orders.Name = "date";
            this.orders.RowHeadersWidth = 51;
            this.orders.RowTemplate.Height = 24;
            this.orders.Size = new System.Drawing.Size(429, 426);
            this.orders.TabIndex = 5;
            this.orders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.date_CellContentClick);
            // 
            // accountant
            // 
            this.accountant.HeaderText = "accountant";
            this.accountant.MinimumWidth = 6;
            this.accountant.Name = "accountant";
            this.accountant.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // get_order
            // 
            this.get_order.HeaderText = "get order";
            this.get_order.MinimumWidth = 6;
            this.get_order.Name = "get_order";
            this.get_order.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.get_order.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.get_order.Width = 125;
            // 
            // AccountManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.showOrders_btn);
            this.Controls.Add(this.showStock_btn);
            this.Name = "AccountManagerForm";
            this.Text = "AccountManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.orders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showStock_btn;
        private System.Windows.Forms.Button showOrders_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.DataGridView orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountant;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewButtonColumn get_order;
    }
}