using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Odbc;

namespace SavingsApp
{

    public partial class LoginPage : Form
    {
        //this is to store user data
        Dictionary<string, string> credentials = new Dictionary<string , string>();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txt_loginassword.PasswordChar != '\0')
            {
                txt_loginassword.PasswordChar = '\0';
            }
            else
            {
                txt_loginassword.PasswordChar = '*';
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txt_loginassword.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Complete all fields");
            }
            else
            {
                if (credentials.ContainsKey(txtUsername.Text)&&credentials.ContainsValue(txt_loginassword.Text))
                {
                    MessageBox.Show("Login Successful");
                    mainPage mainPage = new mainPage();
                    this.Hide();
                    mainPage.Show();
                }

                else
                {
                    MessageBox.Show("User Not Found");
                }
            }
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txt_loginassword.MaxLength > 8)
            {
                txt_loginassword.MaxLength = 8;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_loginassword.MaxLength > 8)
            {
                txt_loginassword.MaxLength = 8;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt_createpassword.Text == "" || txt_createusername.Text == "")
            {
                MessageBox.Show("Complete all fields");
            }
            else
            {
             credentials.Add(txt_createusername.Text,txt_createpassword.Text);  
                
                MessageBox.Show("Account Creation successful!!");
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (txt_createpassword.PasswordChar != '\0')
            {
                txt_createpassword.PasswordChar = '\0';
            }
            else
            {
                txt_createpassword.PasswordChar = '*';
            }
            }
        }
    }

