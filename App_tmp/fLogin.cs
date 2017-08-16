using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_tmp
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(txtUserName.Text, txtPassword.Text))
            {
                txtPassword.Text = null;
                var frm_1 = new Form1();
                this.Hide();
                frm_1.Show();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
            //var frm_1 = new Form1();
            //this.Hide();
            //frm_1.ShowDialog();
            //this.Show();
        }
        bool Login(string userName, string passWord)
        {
            string query = string.Format("select *from account where username='" + userName + "' and password='" + passWord + "'");
            DataProvider dp = new DataProvider();
            DataTable result = dp.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
