using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MapWinGIS;

namespace App_tmp
{
    public partial class LoadData : Form
    {
        private static string CONNECTION_STRING = "PG:host=localhost dbname=gisdb user=postgres password=56tyghbn";
        public delegate void SfLoad(string sfName, Shapefile tmp_sf);
        public event SfLoad Add;
        public LoadData()
        {
            InitializeComponent();
            ShowData();
        }
        void ShowData()
        {
            var ds = new OgrDatasource();
            if (!ds.Open(CONNECTION_STRING))
            {
                MessageBox.Show("Failed to establish connection: " + ds.GdalLastErrorMsg);
            }
            else
            {
                int count = ds.LayerCount;
                //MessageBox.Show("Number of layers: " + count);
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
            ds.Open(CONNECTION_STRING);
            string sfName = lvData.SelectedItems[0].Text;
            Shapefile sf = ds.GetLayer(lvData.SelectedItems[0].Index).GetBuffer();
            Add(sfName, sf);
        }

        private void btnRefersh_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }
    }

}
