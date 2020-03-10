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

namespace BTL_HQTCSDL
{
    public partial class FrmExportToDb : Form
    {
        Dictionary<string, byte[]> imgDict;
        string connStr;
        Shapefile sf;

        public Shapefile Sf
        {
            get { return sf; }
            set { sf = value; }
        }

        public string ConnStr
        {
            get { return connStr; }
            set { connStr = value; }
        }
        public FrmExportToDb()
        {
            InitializeComponent();
            ControlConfig();

        }
        public delegate void SelIdx(int idx);
        public event SelIdx SelShapeIdx;
        private void ControlConfig()
        {
            //this.ControlBox = false;
            groupBox1.Enabled = false;
            btnExport.Click += new EventHandler(btnExport_Click);
            btnAddImg.Click += new EventHandler(btnAddImg_Click);
            btnOpenImg.Click += new EventHandler(btnOpenImg_Click);
            //
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);

            //
            sf = new Shapefile();
            imgDict = new Dictionary<string, byte[]>();
            //
            //btnPreview.Visible = false;
            //btnPreview.Click += new EventHandler(btnPreview_Click);
        }

        void btnPreview_Click(object sender, EventArgs e)
        {
            FrmOpenImg frmOpenImg = new FrmOpenImg(connStr);
            frmOpenImg.connStr = this.connStr;
            frmOpenImg.layerName = txtLayerName.Text;
            frmOpenImg.Show(this);
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var key = (sender as ComboBox).Text;
            if (imgDict.ContainsKey(key))
            {
                byte[] pixelData = imgDict[key];
                if (pixelData.Length > 2)
                {
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(pixelData))
                    {
                        pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            else
            {
                pictureBox1.Image = null;
            }
            SelShapeIdx(Convert.ToInt32(key));
        }

        void btnOpenImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(ofd.FileName);
                var imgcvt = new ImageConverter();
                byte[] xByte = (byte[])imgcvt.ConvertTo(pictureBox1.Image, typeof(byte[]));
                if (imgDict.ContainsKey(comboBox1.Text))
                {
                    imgDict[comboBox1.Text] = xByte;
                }
                else
                {
                    imgDict.Add(comboBox1.Text, xByte);
                }
            }


        }

        void btnAddImg_Click(object sender, EventArgs e)
        {
            if (txtLayerName.Text.Length == 0)
            {
                MessageBox.Show("Pls!!! Enter layer name.");
                return;
            }
            if (sf.NumShapes == 0 || sf.Projection == "")
            {
                MessageBox.Show(string.Format("Cann't import layer with {0} shape and projection = ",
                                                sf.NumShapes, sf.Projection));
                this.Hide();
                return;
            }

            if (sf.NumShapes > 0)
            {
                for (int i = 0; i < sf.NumShapes; i++)
                {
                    var fieldIdx = sf.Table.FieldIndexByName["ID"];
                    comboBox1.Items.Add(sf.Table.CellValue[fieldIdx, i]);
                    //imgDict.Add(sf.Table.CellValue[fieldIdx, i],);
                }
            }
            comboBox1.SelectedIndex = 0;
            groupBox1.Enabled = true;
        }

        void btnExport_Click(object sender, EventArgs e)
        {
            var layerName = txtLayerName.Text;
            var ds = new OgrDatasource();

            if (!ds.Open(connStr))
            {
                Debug.Print("Failed to establish connection: " + ds.GdalLastErrorMsg);
            }
            else
            {
                if (!ds.ImportShapefile(sf, layerName, "OVERWRITE=YES", tkShapeValidationMode.NoValidation))
                {
                    MessageBox.Show("Failed to import shapefile: " + layerName);
                }
                else
                {
                    MessageBox.Show("Layer " + layerName + " was imported.");
                    string query = string.Format("ALTER TABLE {0} ADD image bytea", layerName);
                    DataProvider dp = new DataProvider();
                    dp.ExecuteQuery(query);
                    var imgcvt = new ImageConverter();
                    foreach (var item in imgDict.Keys)
                    {
                        byte[] xByte = imgDict[item];
                        dp.StoreImage(layerName, item, xByte);
                    }
                    DialogResult dialogResult = MessageBox.Show("Hiển thị Form preview", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        FrmOpenImg frmOpenImg = new FrmOpenImg(connStr);
                        frmOpenImg.connStr = this.connStr;
                        frmOpenImg.layerName = txtLayerName.Text;
                        frmOpenImg.ShowDialog(this);
                    }
                    else if (dialogResult == DialogResult.No)
                    {                        
                    }
                }
                ds.Close();
            }
            //btnPreview.Visible = true;
            this.Hide();
        }

    }
}
