namespace ReustrantApp
{
    partial class AdminForm
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
            comboBoxRole = new ComboBox();
            label4 = new Label();
            textBoxPass = new TextBox();
            label3 = new Label();
            textBoxLogin = new TextBox();
            label2 = new Label();
            dataGridViewUsers = new DataGridView();
            tabPage2 = new TabPage();
            btnDelete = new Button();
            btnUpdateReview = new Button();
            btnCreateReview = new Button();
            label5 = new Label();
            textBoxUserID = new TextBox();
            label8 = new Label();
            textBoxReviewID = new TextBox();
            label6 = new Label();
            textBoxComment = new TextBox();
            textBoxRating = new TextBox();
            label7 = new Label();
            dataGridViewReviews = new DataGridView();
            tabPage3 = new TabPage();
            panel1 = new Panel();
            labelExit = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReviews).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
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
            tabPage1.Controls.Add(comboBoxRole);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBoxPass);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBoxLogin);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dataGridViewUsers);
            tabPage1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabPage1.ForeColor = SystemColors.ControlText;
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 429);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Пользователи";
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
            btnDel.Click += btnDelete_Click;
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
            btnEdit.Click += btnUpdate_Click;
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
            btnCreate.Click += btnCreate_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Admin", "Emloyee", "Client" });
            comboBoxRole.Location = new Point(32, 99);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(269, 25);
            comboBoxRole.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 75);
            label4.Name = "label4";
            label4.Size = new Size(37, 17);
            label4.TabIndex = 1;
            label4.Text = "Роль";
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(32, 163);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(269, 25);
            textBoxPass.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 139);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 1;
            label3.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(32, 40);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(269, 25);
            textBoxLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 16);
            label2.Name = "label2";
            label2.Size = new Size(121, 17);
            label2.TabIndex = 1;
            label2.Text = "Имя пользователя";
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.BackgroundColor = SystemColors.Control;
            dataGridViewUsers.BorderStyle = BorderStyle.None;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(340, 0);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(455, 425);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDelete);
            tabPage2.Controls.Add(btnUpdateReview);
            tabPage2.Controls.Add(btnCreateReview);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(textBoxUserID);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBoxReviewID);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBoxComment);
            tabPage2.Controls.Add(textBoxRating);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(dataGridViewReviews);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(795, 429);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Отзывы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(33, 370);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(269, 33);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button1_Click;
            // 
            // btnUpdateReview
            // 
            btnUpdateReview.BackColor = Color.RosyBrown;
            btnUpdateReview.FlatStyle = FlatStyle.Flat;
            btnUpdateReview.ForeColor = Color.White;
            btnUpdateReview.Location = new Point(172, 331);
            btnUpdateReview.Name = "btnUpdateReview";
            btnUpdateReview.Size = new Size(130, 33);
            btnUpdateReview.TabIndex = 13;
            btnUpdateReview.Text = "Изменить";
            btnUpdateReview.UseVisualStyleBackColor = false;
            btnUpdateReview.Click += btnUpdateReview_Click;
            // 
            // btnCreateReview
            // 
            btnCreateReview.BackColor = Color.RosyBrown;
            btnCreateReview.FlatStyle = FlatStyle.Flat;
            btnCreateReview.ForeColor = Color.White;
            btnCreateReview.Location = new Point(33, 331);
            btnCreateReview.Name = "btnCreateReview";
            btnCreateReview.Size = new Size(130, 33);
            btnCreateReview.TabIndex = 14;
            btnCreateReview.Text = "Создать";
            btnCreateReview.UseVisualStyleBackColor = false;
            btnCreateReview.Click += btnCreateReview_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 82);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 6;
            label5.Text = "Комментарий";
            // 
            // textBoxUserID
            // 
            textBoxUserID.Location = new Point(33, 235);
            textBoxUserID.Name = "textBoxUserID";
            textBoxUserID.Size = new Size(269, 29);
            textBoxUserID.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 211);
            label8.Name = "label8";
            label8.Size = new Size(159, 21);
            label8.TabIndex = 7;
            label8.Text = "Номер пользователя";
            // 
            // textBoxReviewID
            // 
            textBoxReviewID.Location = new Point(33, 170);
            textBoxReviewID.Name = "textBoxReviewID";
            textBoxReviewID.Size = new Size(269, 29);
            textBoxReviewID.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 146);
            label6.Name = "label6";
            label6.Size = new Size(108, 21);
            label6.TabIndex = 7;
            label6.Text = "Номер заказа";
            // 
            // textBoxComment
            // 
            textBoxComment.Location = new Point(33, 106);
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(269, 29);
            textBoxComment.TabIndex = 10;
            // 
            // textBoxRating
            // 
            textBoxRating.Location = new Point(33, 47);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(269, 29);
            textBoxRating.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 23);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 8;
            label7.Text = "Оценка";
            // 
            // dataGridViewReviews
            // 
            dataGridViewReviews.BackgroundColor = SystemColors.Control;
            dataGridViewReviews.BorderStyle = BorderStyle.None;
            dataGridViewReviews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReviews.Location = new Point(340, 1);
            dataGridViewReviews.Name = "dataGridViewReviews";
            dataGridViewReviews.Size = new Size(455, 425);
            dataGridViewReviews.TabIndex = 5;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(795, 429);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Категории";
            tabPage3.UseVisualStyleBackColor = true;
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
            label1.Size = new Size(367, 25);
            label1.TabIndex = 0;
            label1.Text = "\"ГастроДом\" Панель администратора";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 513);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReviews).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Label labelExit;
        private Label label1;
        private DataGridView dataGridViewUsers;
        private ComboBox comboBoxRole;
        private Label label4;
        private TextBox textBoxPass;
        private Label label3;
        private TextBox textBoxLogin;
        private Label label2;
        private Button btnDel;
        private Button btnEdit;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdateReview;
        private Button btnCreateReview;
        private Label label5;
        private TextBox textBoxReviewID;
        private Label label6;
        private TextBox textBoxRating;
        private Label label7;
        private DataGridView dataGridViewReviews;
        private TabPage tabPage3;
        private TextBox textBoxUserID;
        private Label label8;
        private TextBox textBoxComment;
    }
}