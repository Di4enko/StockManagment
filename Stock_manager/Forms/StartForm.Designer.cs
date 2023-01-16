
namespace Stock_manager.Forms
{
    partial class StartForm
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
            this.enter_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.users = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enter_btn
            // 
            this.enter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_btn.Location = new System.Drawing.Point(502, 179);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(166, 53);
            this.enter_btn.TabIndex = 0;
            this.enter_btn.Text = "Enter";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_click);
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_btn.Location = new System.Drawing.Point(771, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(35, 35);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(157, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stock Managment App";
            // 
            // users
            // 
            this.users.FormattingEnabled = true;
            this.users.Location = new System.Drawing.Point(167, 221);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(277, 24);
            this.users.TabIndex = 4;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(167, 179);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(277, 22);
            this.name.TabIndex = 5;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(167, 275);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(46, 17);
            this.error.TabIndex = 6;
            this.error.Text = "label2";
            this.error.Visible = false;
            this.error.Click += new System.EventHandler(this.label2_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.error);
            this.Controls.Add(this.name);
            this.Controls.Add(this.users);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.enter_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox users;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label error;
    }
}