namespace ReustrantApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            lblExit = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RosyBrown;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(119, 277);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(168, 55);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(95, 46);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 1;
            label1.Text = "Авторизация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 128);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 2;
            label2.Text = "Имя пользователя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 191);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "Пароль";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(39, 146);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(310, 23);
            txtLogin.TabIndex = 4;
            txtLogin.Text = "Клиент";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(39, 209);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(310, 23);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "client123";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblExit.Location = new Point(364, 9);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(20, 21);
            lblExit.TabIndex = 6;
            lblExit.Text = "X";
            lblExit.Click += lblExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 373);
            ControlBox = false;
            Controls.Add(lblExit);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Label lblExit;
    }
}
