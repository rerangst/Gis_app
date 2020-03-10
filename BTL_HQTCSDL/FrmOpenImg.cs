using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MapWinGIS;
using System.Diagnostics;
using System.IO;

namespace BTL_HQTCSDL
{
    public partial class FrmOpenImg : Form
    {
        public string connStr = "PG:host=127.0.0.1 dbname=gisdb user=postgres password=56tyghbn";
        public string layerName="";
        private string connStr_2;
        public FrmOpenImg()
        {
            InitializeComponent();
            textBox1.Text = layerName;
        }

        public FrmOpenImg(string connStr_2)
        {
            InitializeComponent();
            this.connStr = connStr_2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            layerName = textBox1.Text;
            var ds = new OgrDatasource();
            if (!ds.Open(connStr))
            {
                MessageBox.Show("Failed to establish connection: " + ds.GdalLastErrorMsg);
            }
            else
            {
                var lyr = ds.GetLayerByName(layerName);// .GetLayer(i);
                var sf = lyr.GetBuffer();

                for (int i = 0; i < sf.NumShapes; i++)
                {
                    var fieldIdx = sf.Table.FieldIndexByName["ID"];
                    comboBox1.Items.Add(sf.Table.CellValue[fieldIdx, i]);
                    //imgDict.Add(sf.Table.CellValue[fieldIdx, i],);
                }

                ds.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string query = string.Format("ALTER TABLE {0} ADD image bytea", layerName);

            DataProvider dp = new DataProvider();

            using (MemoryStream ms = new MemoryStream(dp.GetImage(layerName, comboBox1.Text)))
            {
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);
            }
        }
    }
}
