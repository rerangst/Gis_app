using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapWinGIS;
using System.Windows.Forms;

namespace App_tmp
{
    class MapDataSource
    {
        private static string CONNECTION_STRING = "PG:host=localhost dbname=tmpData user=postgres password=56tyghbn";

        public static Dictionary<string, MapWinGIS.Shapefile> LoadData()
        {
            var dataSource = new OgrDatasource();
            if (!dataSource.Open(CONNECTION_STRING))
            {
                MessageBox.Show("Failed to establish connection: " + dataSource.GdalLastErrorMsg);
                return null;
            }
            else
            {
                Dictionary<string, MapWinGIS.Shapefile> listShape = new Dictionary<string, MapWinGIS.Shapefile>();
                int count = dataSource.LayerCount;
                
                for (int i = 0; i < count; i++)
                {
                    Shapefile sf = dataSource.GetLayer(i).GetBuffer();
                    listShape.Add(dataSource.GetLayer(i).Name, sf);                                        
                }
                dataSource.Close();
                return listShape;
            }
        }
    }
}
