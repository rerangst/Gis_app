using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapWinGIS;
using AxMapWinGIS;
using System.Windows.Forms;
namespace App_tmp
{
    class SpatialQuery
    {
        public delegate void LayerOption(string sfName, MapWinGIS.Shapefile sf);
        public event LayerOption ChangeOpion;           
        int index = 0;       
        Shapefile sf = new Shapefile();
        Shapefile tmp_sf = new Shapefile();
       
        public Shapefile AddNewShape(List<MapWinGIS.Point> pointSelected)
        {
            tmp_sf.CreateNew("", ShpfileType.SHP_POLYGON);
            Shape shp = new Shape();
            shp.Create(ShpfileType.SHP_POLYGON);
            for (int i = 0; i < pointSelected.Count; i++)
            {
                shp.InsertPoint(pointSelected[i], i);
            }
            //MessageBox.Show(Convert.ToString(sf.EditInsertShape(listShape[listShape.Count - 1], ref index)));
            tmp_sf.EditInsertShape(shp, ref index);
            index++;
            //int tmp_handle = axMap1.AddLayer(tmp_sf, false);            
            //axMap1.set_ShapeLayerFillColor(tmp_handle, Convert.ToUInt32(System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green)));
            var sfName= string.Format("tmp_sf {0}", index);
            return tmp_sf;
            //ChangeOpion(sfName,tmp_sf);
        }
    }
}
