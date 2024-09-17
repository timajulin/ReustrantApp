namespace ReustrantApp
{
    partial class OrderForm
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
            dataGridViewOrderItems = new DataGridView();
            MenuID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            btnConfirmOrder = new Button();
            lblTotalPrice = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOrderItems
            // 
            dataGridViewOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewOrderItems.BackgroundColor = SystemColors.Control;
            dataGridViewOrderItems.BorderStyle = BorderStyle.None;
            dataGridViewOrderItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderItems.Columns.AddRange(new DataGridViewColumn[] { MenuID, name, price, quantity });
            dataGridViewOrderItems.Location = new Point(38, 63);
            dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            dataGridViewOrderItems.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewOrderItems.Size = new Size(303, 256);
            dataGridViewOrderItems.TabIndex = 0;
            // 
            // MenuID
            // 
            MenuID.Frozen = true;
            MenuID.HeaderText = "ID";
            MenuID.Name = "MenuID";
            MenuID.Visible = false;
            // 
            // name
            // 
            name.HeaderText = "Название";
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 84;
            // 
            // price
            // 
            price.HeaderText = "Цена";
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 60;
            // 
            // quantity
            // 
            quantity.HeaderText = "Количество";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Width = 97;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.BackColor = Color.RosyBrown;
            btnConfirmOrder.BackgroundImageLayout = ImageLayout.None;
            btnConfirmOrder.FlatStyle = FlatStyle.Flat;
            btnConfirmOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnConfirmOrder.ForeColor = Color.White;
            btnConfirmOrder.Location = new Point(76, 385);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(213, 44);
            btnConfirmOrder.TabIndex = 1;
            btnConfirmOrder.Text = "Заказать";
            btnConfirmOrder.UseVisualStyleBackColor = false;
            btnConfirmOrder.Click += btnConfirmOrder_Click_1;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(48, 352);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(38, 15);
            lblTotalPrice.TabIndex = 2;
            lblTotalPrice.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(48, 30);
            label1.Name = "label1";
            label1.Size = new Size(219, 30);
            label1.TabIndex = 3;
            label1.Text = "Оформление заказа";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 452);
            Controls.Add(label1);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnConfirmOrder);
            Controls.Add(dataGridViewOrderItems);
            Name = "OrderForm";
            Text = "Оформление";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewOrderItems;
        private Button btnConfirmOrder;
        private Label lblTotalPrice;
        private Label label1;
        private DataGridViewTextBoxColumn MenuID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
    }
}