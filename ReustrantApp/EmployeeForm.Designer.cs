namespace ReustrantApp
{
    partial class EmployeeForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnDel = new Button();
            btnEdit = new Button();
            btnCreate = new Button();
            comboBoxOrderStatus = new ComboBox();
            label4 = new Label();
            textBoxTotalPrice = new TextBox();
            label3 = new Label();
            textBoxUserID = new TextBox();
            label2 = new Label();
            dataGridViewOrders = new DataGridView();
            panel1 = new Panel();
            labelExit = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl1.Location = new Point(0, 50);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 463);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDel);
            tabPage1.Controls.Add(btnEdit);
            tabPage1.Controls.Add(btnCreate);
            tabPage1.Controls.Add(comboBoxOrderStatus);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBoxTotalPrice);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBoxUserID);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dataGridViewOrders);
            tabPage1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabPage1.ForeColor = SystemColors.ControlText;
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 429);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Заказы";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.IndianRed;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(32, 363);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(269, 33);
            btnDel.TabIndex = 4;
            btnDel.Text = "Удалить";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDeleteOrder_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.RosyBrown;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(171, 324);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(130, 33);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnUpdateOrder_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.RosyBrown;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(32, 324);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(130, 33);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreateOrder_Click;
            // 
            // comboBoxOrderStatus
            // 
            comboBoxOrderStatus.FormattingEnabled = true;
            comboBoxOrderStatus.Items.AddRange(new object[] { "Новый", "В работе", "Исполнен" });
            comboBoxOrderStatus.Location = new Point(32, 159);
            comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            comboBoxOrderStatus.Size = new Size(269, 25);
            comboBoxOrderStatus.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 75);
            label4.Name = "label4";
            label4.Size = new Size(90, 17);
            label4.TabIndex = 1;
            label4.Text = "Сумма заказа";
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Location = new Point(32, 95);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.Size = new Size(269, 25);
            textBoxTotalPrice.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 139);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 1;
            label3.Text = "Статус";
            // 
            // textBoxUserID
            // 
            textBoxUserID.Location = new Point(32, 40);
            textBoxUserID.Name = "textBoxUserID";
            textBoxUserID.Size = new Size(269, 25);
            textBoxUserID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 16);
            label2.Name = "label2";
            label2.Size = new Size(136, 17);
            label2.TabIndex = 1;
            label2.Text = "Номер пользователя";
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.BackgroundColor = SystemColors.Control;
            dataGridViewOrders.BorderStyle = BorderStyle.None;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(340, 0);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.Size = new Size(455, 425);
            dataGridViewOrders.TabIndex = 0;
            dataGridViewOrders.CellClick += dataGridViewOrders_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(labelExit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 44);
            panel1.TabIndex = 1;
            // 
            // labelExit
            // 
            labelExit.AutoSize = true;
            labelExit.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            labelExit.ForeColor = Color.White;
            labelExit.Location = new Point(767, 5);
            labelExit.Name = "labelExit";
            labelExit.Size = new Size(24, 30);
            labelExit.TabIndex = 0;
            labelExit.Text = "x";
            labelExit.Click += labelExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(339, 25);
            label1.TabIndex = 0;
            label1.Text = "\"ГастроДом\" Управление заказами";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 513);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel1;
        private Label labelExit;
        private Label label1;
        private DataGridView dataGridViewOrders;
        private ComboBox comboBoxOrderStatus;
        private Label label4;
        private TextBox textBoxTotalPrice;
        private Label label3;
        private TextBox textBoxUserID;
        private Label label2;
        private Button btnDel;
        private Button btnEdit;
        private Button btnCreate;
    }
}