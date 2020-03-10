using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MapWinGIS;
using System.IO;
using AxMapWinGIS;
namespace App_tmp
{
    public partial class Form1 : Form
    {
        #region properties
        List<MapWinGIS.Point> pointSelected = new List<MapWinGIS.Point>();
        private static string CONNECTION_STRING = "PG:host=localhost dbname=tmpData user=postgres password=56tyghbn";
        Dictionary<string, int> indexShape = new Dictionary<string, int>();

        public Dictionary<string, int> IndexShape
        {
            get { return indexShape; }
            set { indexShape = value; }
        }

        Dictionary<string, MapWinGIS.Shapefile> dataShapeFile = new Dictionary<string, Shapefile>();

        public Dictionary<string, MapWinGIS.Shapefile> DataShapeFile
        {
            get { return dataShapeFile; }
            set { dataShapeFile = value; }
        }
        Dictionary<string, MapWinGIS.Shapefile> baseShapeFile = new Dictionary<string, Shapefile>();

        public Dictionary<string, MapWinGIS.Shapefile> BaseShapeFile
        {
            get { return baseShapeFile; }
            set { baseShapeFile = value; }
        }

        Dictionary<string, bool> options = new Dictionary<string, bool>();

        public Dictionary<string, bool> Options
        {
            get { return options; }
            set { options = value; }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            //ShowData();

        }
        private void ShowData()
        {
            List<string> listName = MapDataSource.LoadName();
            foreach (var item in listName)
            {
                AddShapeFile(item);
            }
            axMap1.Redraw();
            axMap1.ZoomToLayer(indexShape["dongnama"]);
            //TestPoint();
        }
        #region TestInShape
        private void TestPoint()
        {
            List<string> philippine_airports = new List<string>();
            List<string> brunei_airports = new List<string>();
            List<string> cambodia_airports = new List<string>();
            List<string> thailand_airports = new List<string>();
            List<string> singapore_airports = new List<string>();
            List<string> myanmar_airports = new List<string>();
            List<string> laos_airport = new List<string>();
            List<string> indo_airports = new List<string>();
            List<string> easttimor_airports = new List<string>();
            List<string> malaysia_airports = new List<string>();
            foreach (var item in dataShapeFile.Keys)
            {
                if (dataShapeFile[item].ShapefileType != ShpfileType.SHP_POLYGON)
                {
                    for (int i = 0; i < dataShapeFile[item].NumShapes; i++)
                    {
                        if (item == "philippine_airports")
                        {
                            var pt = dataShapeFile[item].Shape[i].get_Point(0);
                            if (!dataShapeFile["dongnama"].PointInShape(1, pt.x, pt.y))
                                philippine_airports.Add(dataShapeFile[item].Table.CellValue[4, i].ToString());
                        }
                        if (item == "brunei_airports")
                        {
                            var pt = dataShapeFile[item].Shape[i].get_Point(0);
                            if (!dataShapeFile["dongnama"].PointInShape(12, pt.x, pt.y))
                                brunei_airports.Add(dataShapeFile[item].Table.CellValue[4, i].ToString());
                        }
                        if (item == "cambodia_airports")
                        {
                            var pt = dataShapeFile[item].Shape[i].get_Point(0);
                            if (pt != null)
                            {
                                if (!dataShapeFile["dongnama"].PointInShape(9, pt.x, pt.y) && pt != null)
                                    cambodia_airports.Add(dataShapeFile[item].Table.CellValue[4, i].ToString());
                            }

                        }
                        if (item == "easttimor_airports")
                        {
                            var pt = dataShapeFile[item].Shape[i].get_Point(0);
                            if (!dataShapeFile["dongnama"].PointInShape(0, pt.x, pt.y))
                                easttimor_airports.Add(dataShapeFile[item].Table.CellValue[4, i].ToString());
                        }
                        if (item == "indo_airports")
                        {
                            var pt = dataShapeFile[item].Shape[i].get_Point(0);
                            if (!dataShapeFile["dongnama"].PointInShape(3, pt.x, pt.y))
                                indo_airports.Add(dataShapeFile[item].Table.CellValue[4, i].ToString());
                        }
                        if (item == "laos_airport")
                        {
                            var pt = dataShapeFile[item].Shape[i].get_Point(0);
                            if (!dataShapeFile["dongnama"].PointInShape(10, pt.x, pt.y))
                                laos_airport.Add(dataShapeFile[item].Table.CellValue[4, i].ToString());
                        }
                        if (item == "malaysia_airports")
                        {
                            var pt = dataShapeFile[item].Shape[i].get_Point(0);
                            if (!dataShapeFile["dongnama"].PointInShape(2, pt.x, pt.y))
                                malaysia_airports.Add(dataShapeFile[item].Table.CellValue[4, i].ToString());
                        }
                        if (item == "myanmar_airports")
                        {
                            var pt = dataShapeFile[item].Shape[i].get_Point(0);
                            if (!dataShapeFile["dongnama"].PointInShape(6, pt.x, pt.y))
                                myanmar_airports.Add(dataShapeFile[item].Table.CellValue[4, i].ToString());
                        }
                        if (item == "singapore_airports")
                        {
                            var pt = dataShapeFile[item].Shape[i].get_Point(0);
                            if (!dataShapeFile["dongnama"].PointInShape(4, pt.x, pt.y))
                                singapore_airports.Add(dataShapeFile[item].Table.CellValue[4, i].ToString());
                        }
                        if (item == "thailand_airports")
                        {
                            var pt = dataShapeFile[item].Shape[i].get_Point(0);
                            if (!dataShapeFile["dongnama"].PointInShape(5, pt.x, pt.y))
                                thailand_airports.Add(dataShapeFile[item].Table.CellValue[4, i].ToString());
                        }
                    }
                }
            }
            File.WriteAllText("D:\\laos_airport.txt", ConvertToString(laos_airport));
            File.WriteAllText("D:\\cambodia_airports.txt", ConvertToString(cambodia_airports));
            File.WriteAllText("D:\\easttimor_airports.txt", ConvertToString(easttimor_airports));
            File.WriteAllText("D:\\indo_airports.txt", ConvertToString(indo_airports));
            File.WriteAllText("D:\\malaysia_airports.txt", ConvertToString(malaysia_airports));
            File.WriteAllText("D:\\myanmar_airports.txt", ConvertToString(myanmar_airports));
            File.WriteAllText("D:\\philippine_airports.txt", ConvertToString(philippine_airports));
            File.WriteAllText("D:\\singapore_airports.txt", ConvertToString(singapore_airports));
            File.WriteAllText("D:\\thailand_airports.txt", ConvertToString(thailand_airports));
            File.WriteAllText("D:\\Brunei_Airports.txt", ConvertToString(brunei_airports));

        }
        string ConvertToString(List<string> lts)
        {
            string str = "";
            foreach (var item in lts)
            {
                str = str + " \t " + item;
            }
            return str;
        }
        #endregion

        void SetDefault()
        {
            axMap1.CursorMode = tkCursorMode.cmPan;
            axMap1.ZoomToLayer(indexShape["dongnama"]);
            axMap1.Redraw();
        }



        private void EditMainShape(Shapefile mainShape)
        {
            Utils utils = new Utils();
            int fieldIndex = mainShape.Table.get_FieldIndexByName("gid");
            mainShape.Categories.Generate(fieldIndex, tkClassificationType.ctUniqueValues, 5);
            mainShape.Categories.Item[0].DrawingOptions.FillColor = utils.ColorByName(tkMapColor.LightSalmon);           //Dong Timor
            mainShape.Categories.Item[0].DrawingOptions.FillTransparency = 200;
            mainShape.Categories.Item[1].DrawingOptions.FillColor = utils.ColorByName(tkMapColor.Tomato);         //Philippine
            mainShape.Categories.Item[1].DrawingOptions.FillTransparency = 200;
            mainShape.Categories.Item[2].DrawingOptions.FillColor = utils.ColorByName(tkMapColor.Yellow);      //Malaysia
            mainShape.Categories.Item[2].DrawingOptions.FillTransparency = 200;
            mainShape.Categories.Item[3].DrawingOptions.FillColor = utils.ColorByName(tkMapColor.SpringGreen);          //Indonesia
            mainShape.Categories.Item[3].DrawingOptions.FillTransparency = 200;
            mainShape.Categories.Item[4].DrawingOptions.FillColor = utils.ColorByName(tkMapColor.Red);           //Singapore
            mainShape.Categories.Item[4].DrawingOptions.FillTransparency = 200;
            mainShape.Categories.Item[5].DrawingOptions.FillColor = utils.ColorByName(tkMapColor.BlanchedAlmond);   //Thai Lan
            mainShape.Categories.Item[5].DrawingOptions.FillTransparency = 200;
            mainShape.Categories.Item[6].DrawingOptions.FillColor = utils.ColorByName(tkMapColor.YellowGreen);      //Myanmar
            mainShape.Categories.Item[6].DrawingOptions.FillTransparency = 200;
            mainShape.Categories.Item[7].DrawingOptions.FillColor = utils.ColorByName(tkMapColor.DarkViolet);       //Dai Loan
            mainShape.Categories.Item[8].DrawingOptions.FillColor = utils.ColorByName(tkMapColor.Sienna);        //Trung Quoc
            mainShape.Categories.Item[8].DrawingOptions.FillTransparency = 200;
            mainShape.Categories.Item[9].DrawingOptions.FillColor = utils.ColorByName(tkMapColor.BurlyWood);        //Campuchia
            mainShape.Categories.Item[9].DrawingOptions.FillTransparency = 200;
            mainShape.Categories.Item[10].DrawingOptions.FillColor = utils.ColorByName(tkMapColor.GreenYellow);     //Lao
            mainShape.Categories.Item[10].DrawingOptions.FillTransparency = 200;
            mainShape.Categories.Item[11].DrawingOptions.FillColor = utils.ColorByName(tkMapColor.Red);           //Viet Nam
            mainShape.Categories.Item[11].DrawingOptions.FillTransparency = 150;
            mainShape.Categories.Item[12].DrawingOptions.FillColor = utils.ColorByName(tkMapColor.Violet);          //Brunei
            mainShape.Categories.ApplyExpressions();
            Point pt = new Point();
            string[] arrstring = new string[mainShape.NumShapes];
            for (int i = 0; i < mainShape.NumShapes - 1; i++)
            {
                arrstring[i] = Convert.ToString(mainShape.get_CellValue(1, i));

            }
            for (int i = 0; i < mainShape.NumShapes - 1; i++)
            {

                pt = mainShape.get_Shape(i).Extents.Center;
                mainShape.Labels.AddLabel(arrstring[i], pt.x, pt.y, 0, 0);

            }
            mainShape.Labels.FrameVisible = false;
            mainShape.Labels.FontSize = 12;
            //sf = axMap1.get_Shapefile(i_layer0);
        }

        private void EditPointShape(Shapefile sf)
        {
            MapWinGIS.Image img = new MapWinGIS.Image();
            if (img.Open("Autopilot_24.png", ImageType.USE_FILE_EXTENSION, false, null))
            { MessageBox.Show(""); }
            var db= img.Open("Autopilot_24.png", ImageType.USE_FILE_EXTENSION, false, null);
            sf.DefaultDrawingOptions.PointType = tkPointSymbolType.ptSymbolPicture;
            sf.DefaultDrawingOptions.Picture = img;
            ////else
            //    //MessageBox.Show("ko chay"); 

            ////sf.DefaultDrawingOptions.PointSize = 5;
            ////sf.DefaultDrawingOptions.PointShape = tkPointShapeType.ptShapeCircle;
            //var ct_ukn = new ShapefileCategory();
            
            //ct_ukn = sf.Categories.Add("kk");
            //ct_ukn.Expression = "[loai]=\""+"National"+"\"";
            ////ct_ukn.DrawingOptions.PointType = tkPointSymbolType.ptSymbolPicture;
            ////ct_ukn.DrawingOptions.Picture = img;

            //var opt = ct_ukn.DrawingOptions;
            ////opt.PointShape = tkPointShapeType.ptShapeArrow;
            //opt.PointType = tkPointSymbolType.ptSymbolPicture;
            //opt.Picture = img;
            ////ct_ukn.DrawingOptions = opt;

            ////sf.DefaultDrawingOptions.PointType = tkPointSymbolType.ptSymbolPicture;
            ////sf.DefaultDrawingOptions.Picture = img;
            //sf.Categories.ApplyExpressions();
            ////MessageBox.Show("");
        }

        private void AddShapeFile(string sfName)
        {
            indexShape.Add(sfName, axMap1.NumLayers);
            axMap1.AddLayerFromDatabase(CONNECTION_STRING, sfName, true);
            var tmp_sf = axMap1.get_Shapefile(indexShape[sfName]);
            if (sfName == "dongnama")
            {
                EditMainShape(tmp_sf);
                baseShapeFile.Add(sfName, tmp_sf);
            }
            if (sfName == "world_mini")
            {
                baseShapeFile.Add(sfName, tmp_sf);
            }
            if (sfName == "luoi_toa_do")
            {
                baseShapeFile.Add(sfName, tmp_sf);
            }
            if (tmp_sf.ShapefileType == ShpfileType.SHP_POINT)
            {
                dataShapeFile.Add(sfName, tmp_sf);
                EditPointShape(tmp_sf);
            }
            options.Add(sfName, true);
            axMap1.Redraw();
        }

        private void AddShapeFile(string sfName, Shapefile tmp_sf, bool visible = true)
        {
            baseShapeFile.Add(sfName, tmp_sf);
            indexShape.Add(sfName, axMap1.NumLayers);
            axMap1.AddLayer(tmp_sf, visible);
            options.Add(sfName, visible);
            axMap1.Redraw();
        }
        private void RemoveShapeFile(string sfName)
        {
            axMap1.RemoveLayer(indexShape[sfName]);
            baseShapeFile.Remove(sfName);
            options.Remove(sfName);
            indexShape.Remove(sfName);
        }

        private void EditLayerVisible(Dictionary<string, bool> _options)
        {
            this.options = _options;
            foreach (var item in options.Keys)
            {
                axMap1.set_LayerVisible(indexShape[item], options[item]);
            }
            axMap1.Redraw();
        }

        private void menu_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Mo tap tin du lieu";
            ofd.Filter = "*.shp|*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Shapefile tmp_sf = new Shapefile();
                string sfName = ofd.FileName.Substring(ofd.FileName.LastIndexOf('\\') + 1); // Xac dinh ten cua file dua vao                
                if (tmp_sf.Open(@ofd.FileName, null))
                {
                    AddShapeFile(sfName, tmp_sf);
                }
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fadmin = new fAdmin(dataShapeFile);
            fadmin.Sk_sua += new fAdmin.dltruyen(fadmin_Sk_sua);
            fadmin.Sk_select_shape += new fAdmin.dltruyen_shape(fadmin_Sk_select_shape);
            fadmin.ShowDialog();
        }

        void fadmin_Sk_select_shape(int RowIndex)
        {
            //sf.Values.First().set_ShapeSelected(RowIndex, true);
            //axMap1.Redraw();

        }

        void fadmin_Sk_sua()
        {

        }

        private void mnLoadData_Click(object sender, EventArgs e)
        {
            LoadData f_LoadData = new LoadData();
            f_LoadData.Add += new LoadData.SfLoad(fgis_Add);
            f_LoadData.ShowDialog(this);
        }

        void fgis_Add(string sfName, Shapefile tmp_sf)
        {
            AddShapeFile(sfName, tmp_sf);
        }

        private void test_Click(object sender, EventArgs e)
        {
            var f_ShowData = new fShowData(DataShapeFile, Options);
            f_ShowData.ZoomToShape += new fShowData.ZoomTo(f_ShowData_ZoomToShape);
            f_ShowData.ShowDialog(this);
        }

        void f_ShowData_ZoomToShape(string sfName, int indexOfShape)
        {
            axMap1.ZoomToShape(indexShape[sfName], indexOfShape);
        }

        private void tsbSeclectLayer_Click(object sender, EventArgs e)
        {
            fSelectLayer f_SeclectLayer = new fSelectLayer(DataShapeFile, Options);
            f_SeclectLayer.ChangeOpion += new fSelectLayer.LayerOption(f_SeclectLayer_ChangeOpion);
            f_SeclectLayer.ShowDialog(this);

        }

        void f_SeclectLayer_ChangeOpion(Dictionary<string, bool> options)
        {
            EditLayerVisible(options);
        }

        #region Simple Function
        private void axMap1_MouseMoveEvent(object sender, _DMapEvents_MouseMoveEvent e)
        {
            double x, y;
            x = y = 0;
            axMap1.PixelToProj(e.x, e.y, ref x, ref y);
            x = Math.Round(x, 3);
            y = Math.Round(y, 3);
            toolStripStatusLabel1.Text = "Kinh độ: " + Convert.ToString(x);
            toolStripStatusLabel2.Text = "Vĩ độ: " + Convert.ToString(y);
        }

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
                    System.Drawing.Image img = layer as System.Drawing.Image;
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

            MessageBox.Show(axMap1.NumLayers.ToString());
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayersInfo();
        }

        private void pan_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan;
        }

        private void zoom_more_Click(object sender, EventArgs e)
        {
            axMap1.ZoomToLayer(indexShape["dongnama"]);
        }

        #endregion

        private void tsbQPolygon_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = tkCursorMode.cmMeasure;
            axMap1.Measuring.MeasuringType = tkMeasuringType.MeasureArea;
            axMap1.MeasuringChanged += new AxMapWinGIS._DMapEvents_MeasuringChangedEventHandler(axMap1_MeasuringChanged);


        }

        //void qry_ChangeOpion(string sfName, Shapefile sf)
        //{
        //    AddShapeFile(sfName, sf,false);
        //    TestPoint(sfName);

        //}
        void axMap1_MeasuringChanged(object sender, AxMapWinGIS._DMapEvents_MeasuringChangedEvent e)
        {
            if (e.action == tkMeasuringAction.MesuringStopped)
            {
                //Area = axMap1.Measuring.Area;
                double x, y;
                if (pointSelected.Count != 0) pointSelected.Clear();
                for (int i = 0; i < axMap1.Measuring.PointCount; i++)
                {
                    if (axMap1.Measuring.get_PointXY(i, out x, out y))
                    {
                        MapWinGIS.Point pt_0 = new MapWinGIS.Point();
                        pt_0.x = x;
                        pt_0.y = y;
                        pointSelected.Add(pt_0);
                    }
                }
                if (pointSelected.Count > 3)
                {
                    SpatialQuery SpaQuery = new SpatialQuery();
                    var sfName = string.Format("tmp_sf {0}", axMap1.NumLayers);
                    AddShapeFile(sfName, SpaQuery.AddNewShape(pointSelected), true);
                    axMap1.Redraw();
                    MessageBox.Show(baseShapeFile[sfName].Shape[0].Area.ToString());
                    //var list = TestPoint(sfName);
                    //fShowTable FShowTable = new App_tmp.fShowTable(list);
                    //FShowTable.Show(this);
                    //RemoveShapeFile(sfName);
                    //SetDefault();
                }
            }
        }       

        private Dictionary<string,string> TestPoint(string sfName)
        {
            Shapefile sf_t = new Shapefile();
            Dictionary<string, string> airports = new Dictionary<string, string>();
            foreach (var item in dataShapeFile.Keys)
            {
                //if (options[item])
                //{
                //    for (int i = 0; i < dataShapeFile[item].NumShapes; i++)
                //    {
                //        var pt = dataShapeFile[item].Shape[i].get_Point(0);
                //        if (pt != null && baseShapeFile[sfName].PointInShape(0, pt.x, pt.y))
                //        {
                //            var nameAirPort = dataShapeFile[item].Table.CellValue[4, i].ToString();
                //            airports.Add(nameAirPort, item);
                //        }
                //    }    
                //}
                
            }            
            return airports;
        }
    }
}
