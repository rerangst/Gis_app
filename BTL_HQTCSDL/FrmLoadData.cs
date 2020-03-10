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
    public partial class FrmLoadData : Form
    {
        string connStr = "";

        public string ConnStr
        {
            get { return connStr; }
            set { connStr = value; }
        }
        public delegate void SfLoad(string sfName);
        public event SfLoad AddFromDb;
        FrmConn frmCOnn = new FrmConn();
        public FrmLoadData()
        {
            InitializeComponent();
            ControlConfig();
            //ShowData();
        }
        void ControlConfig()
        {
            this.ControlBox = false;
            btnExit.Click += new EventHandler(btnExit_Click);
            btnAdd.Click +=new EventHandler(btnAdd_Click);
            //
            btnRefersh.Click += new EventHandler(btnRefersh_Click);
            frmCOnn.ChangeConnStr += new FrmConn.SendStr(frmCOnn_ChangeConnStr);
        }

        void frmCOnn_ChangeConnStr(string connSTr)
        {
            connStr = connSTr;
            ShowData();
        }

        void btnRefersh_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        
        void ShowData()
        {
            var ds = new OgrDatasource();
            if (!ds.Open(connStr))
            {
                MessageBox.Show("Failed to establish connection: " + ds.GdalLastErrorMsg);
            }
            else
            {
                lvData.Items.Clear();
                int count = ds.LayerCount;
                for (int i = 0; i < count; i++)
                {
                    var lyr = ds.GetLayer(i);
                    ListViewItem item = new ListViewItem();
                    item.Text = lyr.Name;
                    for (int j = 1; j < lvData.Columns.Count; j++)
                    {
                        ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
                        switch (j)
                        {
                            case 1:
                                subItem.Text = Convert.ToString(lyr.GetBuffer().NumShapes);
                                item.SubItems.Add(subItem);
                                break;
                            case 2:
                                subItem.Text = Convert.ToString(lyr.ShapeType);
                                item.SubItems.Add(subItem);
                                break;
                            case 3:
                                subItem.Text = Convert.ToString(lyr.GeoProjection.Name);
                                
                                item.SubItems.Add(subItem);
                                break;
                        }
                    }
                    lvData.Items.Add(item);
                    lyr.Close();
                }
                ds.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var ds = new OgrDatasource();
            ds.Open(connStr);
            foreach (var item in lvData.SelectedItems)
            {
                string sfName = (item as ListViewItem).Text;
                AddFromDb(sfName);
            }
        }
        void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            frmCOnn.ShowDialog(this);
        }

      
    }
}
