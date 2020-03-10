using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MapWinGIS;

namespace BTL_HQTCSDL
{
    public partial class FrmConn : Form
    {
        string connStr = "PG:host=localhost dbname=gisdb user=postgres password=56tyghbn";

        public string ConnStr
        {
            get { return connStr; }
            set { connStr = value; }
        }
        public FrmConn()
        {
            this.ControlBox = false;
            InitializeComponent();

        }
        public delegate void SendStr(string connSTr);
        public event SendStr ChangeConnStr;
        private void btnTest_Click(object sender, EventArgs e)
        {
            connStr = string.Format("PG:host={0} dbname={1} user={2} password={3}", 
                                     txtHost.Text,txtDb.Text,txtUser.Text,txtPass.Text);
            var ds = new OgrDatasource();
            if (!ds.Open(connStr))
            {
                MessageBox.Show("Failed to establish connection: " + ds.GdalLastErrorMsg);
            }
            else
            {
                MessageBox.Show("Connected sussces!!!");
                ds.Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            connStr = string.Format("PG:host={0} dbname={1} user={2} password={3}",
                         txtHost.Text, txtDb.Text, txtUser.Text, txtPass.Text);
            var ds = new OgrDatasource();
            if (!ds.Open(connStr))
            {
                MessageBox.Show("Failed to establish connection: " + ds.GdalLastErrorMsg);
            }
            else
            {
                ds.Close();
            }
            this.Hide();
            ChangeConnStr(connStr);
        }
    }
}
