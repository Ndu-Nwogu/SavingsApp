using System;

namespace SavingsApp
{
    partial class LoginPage
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txt_loginassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.savingsAppDataSet = new SavingsApp.SavingsAppDataSet();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_createaccount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_createpassword = new System.Windows.Forms.TextBox();
            this.txt_createusername = new System.Windows.Forms.TextBox();
            this.btn_createaccount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.savingsAppDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Teal;
            this.btnLogin.Location = new System.Drawing.Point(151, 280);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(81, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.ForeColor = System.Drawing.Color.Teal;
            this.txtUsername.Location = new System.Drawing.Point(115, 137);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(177, 34);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txt_loginassword
            // 
            this.txt_loginassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_loginassword.ForeColor = System.Drawing.Color.Teal;
            this.txt_loginassword.Location = new System.Drawing.Point(115, 213);
            this.txt_loginassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_loginassword.MaxLength = 10;
            this.txt_loginassword.Name = "txt_loginassword";
            this.txt_loginassword.PasswordChar = '*';
            this.txt_loginassword.Size = new System.Drawing.Size(177, 34);
            this.txt_loginassword.TabIndex = 1;
            this.txt_loginassword.WordWrap = false;
            this.txt_loginassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.Image = global::SavingsApp.Properties.Resources.close_window_30px;
            this.btnExit.Location = new System.Drawing.Point(866, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 22);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = " ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.ForeColor = System.Drawing.Color.Teal;
            this.btnShowPassword.Image = global::SavingsApp.Properties.Resources.eye_30px;
            this.btnShowPassword.Location = new System.Drawing.Point(300, 213);
            this.btnShowPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(29, 23);
            this.btnShowPassword.TabIndex = 2;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // savingsAppDataSet
            // 
            this.savingsAppDataSet.DataSetName = "SavingsAppDataSet";
            this.savingsAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Candara Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(144, 29);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(106, 39);
            this.lbl_login.TabIndex = 8;
            this.lbl_login.Text = "LOGIN";
            // 
            // lbl_createaccount
            // 
            this.lbl_createaccount.AutoSize = true;
            this.lbl_createaccount.Font = new System.Drawing.Font("Candara Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_createaccount.Location = new System.Drawing.Point(520, 29);
            this.lbl_createaccount.Name = "lbl_createaccount";
            this.lbl_createaccount.Size = new System.Drawing.Size(263, 39);
            this.lbl_createaccount.TabIndex = 9;
            this.lbl_createaccount.Text = "CREATE ACCOUNT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // txt_createpassword
            // 
            this.txt_createpassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_createpassword.ForeColor = System.Drawing.Color.Teal;
            this.txt_createpassword.Location = new System.Drawing.Point(606, 226);
            this.txt_createpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_createpassword.MaxLength = 10;
            this.txt_createpassword.Name = "txt_createpassword";
            this.txt_createpassword.PasswordChar = '*';
            this.txt_createpassword.Size = new System.Drawing.Size(177, 34);
            this.txt_createpassword.TabIndex = 12;
            this.txt_createpassword.WordWrap = false;
            this.txt_createpassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_createusername
            // 
            this.txt_createusername.BackColor = System.Drawing.SystemColors.Window;
            this.txt_createusername.ForeColor = System.Drawing.Color.Teal;
            this.txt_createusername.Location = new System.Drawing.Point(606, 137);
            this.txt_createusername.Margin = new System.Windows.Forms.Padding(4);
            this.txt_createusername.Name = "txt_createusername";
            this.txt_createusername.Size = new System.Drawing.Size(177, 34);
            this.txt_createusername.TabIndex = 13;
            this.txt_createusername.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_createaccount
            // 
            this.btn_createaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createaccount.ForeColor = System.Drawing.Color.Teal;
            this.btn_createaccount.Location = new System.Drawing.Point(606, 280);
            this.btn_createaccount.Margin = new System.Windows.Forms.Padding(4);
            this.btn_createaccount.Name = "btn_createaccount";
            this.btn_createaccount.Size = new System.Drawing.Size(177, 42);
            this.btn_createaccount.TabIndex = 14;
            this.btn_createaccount.Text = "Create Account";
            this.btn_createaccount.UseVisualStyleBackColor = true;
            this.btn_createaccount.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Image = global::SavingsApp.Properties.Resources.eye_30px;
            this.button1.Location = new System.Drawing.Point(791, 226);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_createaccount);
            this.Controls.Add(this.txt_createusername);
            this.Controls.Add(this.txt_createpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_createaccount);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_loginassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Candara Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.savingsAppDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txt_loginassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnExit;
        private SavingsAppDataSet savingsAppDataSet;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_createaccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_createpassword;
        private System.Windows.Forms.TextBox txt_createusername;
        private System.Windows.Forms.Button btn_createaccount;
        private System.Windows.Forms.Button button1;
    }
}

