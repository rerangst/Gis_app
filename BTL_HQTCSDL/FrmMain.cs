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
    public partial class FrmMain : Form
    {
        List<string> listLayerName = new List<string>();
        ContextMenu rightClickMenu = new ContextMenu();
        int idxLayerTmp = -1;
        int idxLayerRaster = -1;
        int currHandle = 0;
        int currNodeIdx = 0;
        MapWinGIS.Image img;
        Shapefile tmpLayer;
        FrmLoadData frmLoad = new FrmLoadData();
        FrmExportToDb frmExport = new FrmExportToDb();
        public FrmMain()
        {
            InitializeComponent();
            ConfigConTrol();
        }

        private void ConfigConTrol()
        {
            //
            axMap1.ShowRedrawTime = false;
            axMap1.GrabProjectionFromData = true;
            axMap1.CursorMode = tkCursorMode.cmPan;
            axMap1.SendMouseMove = true;
            axMap1.Measuring.ShowBearing = false;
            axMap1.Measuring.ShowLength = false;
            axMap1.Measuring.ShowTotalLength = false;
            axMap1.Measuring.MeasuringType = tkMeasuringType.MeasureDistance;
            axMap1.Measuring.LineColor = Convert.ToUInt32(System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue));
            axMap1.MeasuringChanged += new AxMapWinGIS._DMapEvents_MeasuringChangedEventHandler(axMap1_MeasuringChanged);

            this.axMap1.MouseMoveEvent += new AxMapWinGIS._DMapEvents_MouseMoveEventHandler(axMap1_MouseMoveEvent);
            //
            //
            MenuItem itemOpenTable = new MenuItem("Mở bảng thuộc tính");
            itemOpenTable.Click += new EventHandler(ItemOpenTable_Click);
            MenuItem itemDel = new MenuItem("Xóa");
            itemDel.Click += new EventHandler(ItemDel_Click);
            rightClickMenu.MenuItems.Add(itemOpenTable);
            rightClickMenu.MenuItems.Add(itemDel);
            //
            tvListLayer.CheckBoxes = true;
            tvListLayer.AfterCheck += new TreeViewEventHandler(TvListLayer_AfterCheck);
            tvListLayer.NodeMouseClick += new TreeNodeMouseClickEventHandler(TvListLayer_NodeMouseClick);
            //
            btnAnotation.Click += new EventHandler(BtnAnotation_Click);
            btnVP.Click += new EventHandler(BtnVP_Click);
            btnImport.Click += new EventHandler(BtnImport_Click);
            btnExport.Click += new EventHandler(BtnExport_Click);
            btnShowCellInfo.Click += new EventHandler(BtnShowCellInfo_Click);
            btnExport.Enabled = false;
            btnAnotation.Checked = false;
            btnVP.Checked = false;
            //
            zoom_in.Click += new EventHandler(zoom_in_Click);
            zoom_out.Click += new EventHandler(zoom_out_Click);
            zoom_more.Click += new EventHandler(zoom_more_Click);
            pan.Click += new EventHandler(pan_Click);
            //
            frmLoad.AddFromDb += new FrmLoadData.SfLoad(frmLoad_AddFromDb);
            //
            frmExport.SelShapeIdx += new FrmExportToDb.SelIdx(frmExport_SelShapeIdx);
            //

        }

        void frmExport_SelShapeIdx(int idx)
        {
            tmpLayer.SelectNone();
            tmpLayer.set_ShapeSelected(idx, true);
            axMap1.ZoomToShape(idxLayerTmp, idx);
        }

        private void BtnShowCellInfo_Click(object sender, EventArgs e)
        {
            List<string> listName = new List<string>();
            for (int i = 0; i < tvListLayer.Nodes.Count; i++)
			{
			 listName.Add(tvListLayer.Nodes[i].Text);
			}
            frmQuery frmQuery = new frmQuery(listName, frmLoad.ConnStr);
            frmQuery.Show(this);
            //if (idxLayerRaster < 0)
            //{
            //    return;
            //}
            //btnShowCellInfo.Checked = !btnShowCellInfo.Checked;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            axMap1.Measuring.Clear();
            axMap1.Redraw();
            frmExport.ConnStr = frmLoad.ConnStr;
            frmExport.Sf = tmpLayer;
            frmExport.ShowDialog(this);
            BtnAnotation_Click(this.btnAnotation, e);
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Mo tap tin du lieu";
            ofd.Filter = "(*.shp)|*.shp|(*.tif)|*.tif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.ToLower().EndsWith(".shp"))
                {
                    MapWinGIS.Shapefile tmpSf = new Shapefile();
                    var result = tmpSf.Open(@ofd.FileName, null);
                    int iHandle = axMap1.AddLayer(tmpSf, true);
                    AddLayer(axMap1.get_LayerName(iHandle));
                }
                else if (ofd.FileName.ToLower().EndsWith(".tif") ||
                    ofd.FileName.ToLower().EndsWith(".png") ||
                    ofd.FileName.ToLower().EndsWith(".jpg"))
                {
                    img = new MapWinGIS.Image();
                    img.Open(@ofd.FileName);
                    var ds = img.GeoProjection;
                    idxLayerRaster = axMap1.AddLayer(img, true);
                    AddLayer(axMap1.get_LayerName(idxLayerRaster));
                }
            }
        }

        private void BtnAnotation_Click(object sender, EventArgs e)
        {
            btnAnotation.Checked = !btnAnotation.Checked;
            if (btnAnotation.Checked)
            {
                btnExport.Enabled = true;
                //toolStripButton6.Enabled
                axMap1.CursorMode = tkCursorMode.cmMeasure;

                tmpLayer = new Shapefile();
                if (!tmpLayer.CreateNewWithShapeID("", ShpfileType.SHP_POLYLINE))
                {
                    MessageBox.Show("Failed to create shapefile: " + tmpLayer.ErrorMsg[tmpLayer.LastErrorCode]);
                    return;
                }
                tmpLayer.SelectionColor = Convert.ToUInt32(System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red));
                int fldX = tmpLayer.EditAddField("ID", FieldType.INTEGER_FIELD, 9, 12);
                //int fldY = sf.EditAddField("y", FieldType. .DOUBLE_FIELD, 9, 12);
                //int fldArea = sf.EditAddField("area", FieldType.DOUBLE_FIELD, 9, 12);

                tmpLayer.GeoProjection = axMap1.GeoProjection;
                idxLayerTmp = axMap1.AddLayer(tmpLayer, true);
                axMap1.set_ShapeLayerLineColor(idxLayerTmp, Convert.ToUInt32(System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)));
            }
            else
            {
                btnExport.Enabled = false;
                axMap1.CursorMode = tkCursorMode.cmPan;
                if (idxLayerTmp >= 0)
                {
                    axMap1.RemoveLayer(idxLayerTmp);
                }
            }
        }

        private void ItemDel_Click(object sender, EventArgs e)
        {
            axMap1.RemoveLayer(currHandle);
            tvListLayer.Nodes.RemoveAt(currNodeIdx);
            axMap1.Redraw();
        }

        private void ItemOpenTable_Click(object sender, EventArgs e)
        {
            //var sfTmp = axMap1.get_Shapefile(currHandle);
            //if (sfTmp == null)
            //{

            //}
        }

        private void TvListLayer_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            TreeNode node_here = tvListLayer.GetNodeAt(e.X, e.Y);
            tvListLayer.SelectedNode = node_here;

            if (node_here == null) return;

            currHandle = axMap1.get_LayerHandle(node_here.Index);
            currNodeIdx = node_here.Index;
            if (e.Button == MouseButtons.Right)
            {

                if (axMap1.get_Shapefile(currHandle) == null)
                {
                    rightClickMenu.MenuItems[0].Text = "Chọn band render";
                }
                else
                {
                    rightClickMenu.MenuItems[0].Text = "Mở bảng thuộc tính";

                }
                rightClickMenu.Show(tvListLayer, new System.Drawing.Point(e.X, e.Y));
            }

        }

        void AddLayer(string layerName)
        {
            listLayerName.Add(layerName);
            TreeNode tmp = new TreeNode(layerName);
            tmp.Checked = true;
            tvListLayer.Nodes.Add(tmp);
        }

        private void TvListLayer_AfterCheck(object sender, TreeViewEventArgs e)
        {
            tvListLayer.SelectedNode = e.Node;
            axMap1.set_LayerVisible(e.Node.Index, e.Node.Checked);
            axMap1.Redraw();
        }


        private void axMap1_MouseMoveEvent(object sender, AxMapWinGIS._DMapEvents_MouseMoveEvent e)
        {
            if (btnShowCellInfo.Checked)
            {
                string stt = "";
                int row;
                int column;
                double X = 0;
                double Y = 0;
                axMap1.PixelToProj(e.x, e.y, ref X, ref Y);
                stt += "Kinh độ: " + Convert.ToString(Math.Round(X, 3)) +
                        " Vĩ độ: " + Convert.ToString(Math.Round(Y, 3)) +
                        ". Giá trị Band: ";
                MapWinGIS.Image img = axMap1.get_Image(idxLayerRaster);
                img.ProjectionToImage(X, Y, out column, out row);
                double[] vals = new double[img.NoBands];
                for (int i = 1; i <= img.NoBands; i++)
                {
                    //GdalRasterBand rst = img.get_Band(i);
                    double pVal = 0;
                    //rst.get_Value(row, column, out pVal);
                    vals[i - 1] = pVal;
                    stt += i.ToString() + " : " + Math.Round(pVal, 3).ToString() + "; ";
                }

                toolStripStatusLabel1.Text = stt;
            }
            else
            {
                lbPrj.Text = "Hệ tọa độ : " + axMap1.GeoProjection.ExportToProj4();
                double x, y;
                x = y = 0;
                axMap1.PixelToProj(e.x, e.y, ref x, ref y);
                x = Math.Round(x, 3);
                y = Math.Round(y, 3);

                toolStripStatusLabel1.Text = "Kinh độ: " + Convert.ToString(x) + " Vĩ độ: " + Convert.ToString(y);
            }
        }

        private void zoom_in_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn;
        }

        private void zoom_out_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut;
        }

        private void pan_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan;
        }

        private void zoom_more_Click(object sender, EventArgs e)
        {

            axMap1.ZoomToLayer(currHandle);
        }


        /****************************/
        public void LayersInfo()
        {
            int pointCount = 0;
            int lineCount = 0;
            int polyCount = 0;
            int imgCount = 0;

            for (int i = 0; i < axMap1.NumLayers; i++)
            {
                object layer = axMap1.get_GetObject(axMap1.get_LayerHandle(i));
                Shapefile sf_test = layer as Shapefile;
                if (sf_test != null)
                {
                    switch (sf_test.ShapefileType)
                    {
                        case ShpfileType.SHP_POINT:
                            pointCount++;
                            break;
                        case ShpfileType.SHP_POLYLINE:
                            lineCount++;
                            break;
                        case ShpfileType.SHP_POLYGON:
                            polyCount++;
                            break;
                    }
                }
                else
                {
                    MapWinGIS.Image img = layer as MapWinGIS.Image;
                    if (img != null)
                    {
                        imgCount++;
                    }
                }
            }

            string s = string.Format("Thong tin map:" + Environment.NewLine +
                                     "So Point shapefiles: {0}" + Environment.NewLine +
                                     "So Polyline shapefiles: {1}" + Environment.NewLine +
                                     "So Polygon shapefiles: {2}" + Environment.NewLine +
                                     "So Images: {3}", pointCount, lineCount, polyCount, imgCount);
            MessageBox.Show(s);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayersInfo();
        }

        private void edit_1_Click(object sender, EventArgs e)
        {

        }



        private void rasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnVP_Click(object sender, EventArgs e)
        {

            frmLoad.Show();
        }

        void frmLoad_AddFromDb(string sfName)
        {
            var strQuery = string.Format("select * from " + sfName);
            int iHandle = axMap1.AddLayerFromDatabase(frmLoad.ConnStr, strQuery, true);
            var tmpSf = axMap1.get_Shapefile(iHandle);
            currHandle = iHandle;
            AddLayer(sfName);
        }

        void axMap1_MeasuringChanged(object sender, AxMapWinGIS._DMapEvents_MeasuringChangedEvent e)
        {
            if (e.action == tkMeasuringAction.PointAdded)
            {

            }
            if (e.action == tkMeasuringAction.MesuringStopped)
            {
                if (btnAnotation.Checked)
                {
                    var fldX = tmpLayer.Table.FieldIndexByName["ID"];
                    Shape shp = new Shape();
                    shp.Create(ShpfileType.SHP_POLYLINE);
                    //shp_tmp.EditAddShape()
                    double x, y;
                    //Debug.WriteLine("Measured points (in map units.): " + axMap1.Measuring.PointCount);
                    for (int i = 0; i < axMap1.Measuring.PointCount; i++)
                    {
                        if (axMap1.Measuring.get_PointXY(i, out x, out y))
                        {
                            //var c = 0;
                            MapWinGIS.Point ptn = new MapWinGIS.Point();
                            ptn.x = x;
                            ptn.y = y;
                            shp.InsertPoint(ptn, ref i);
                            //Debug.WriteLine("x={0}; y={1}", x, y);
                        }
                    }
                    var idx = tmpLayer.EditAddShape(shp);
                    tmpLayer.EditCellValue(fldX, idx, idx);
                    //var a= axMap1.AddLayer(tmpLayer,true);
                    axMap1.set_LayerVisible(idxLayerTmp, true);
                    axMap1.Redraw();
                }
            }
        }
    }
}
