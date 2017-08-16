using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Windows.Forms;
using System.Reflection;

namespace App_tmp
{
    class NpgSQL
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=56tyghbn;Database=gis;");
        public void OpenConn()
        {
            try
            {
                conn.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error :S");
            }
        }

        public void CloseConn()
        {
            try
            {
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error :S");
            }
        }

        public void InsertOnTable(Object objGen)
        {
            try
            {
                this.OpenConn();

                // Get type and properties (vector)
                Type typeObj = objGen.GetType();
                PropertyInfo[] properties = typeObj.GetProperties();

                // Get table
                string[] type = typeObj.ToString().Split('.');
                string table = type[2].ToLower();

                // Start mounting string to insert
                string SQL = "INSERT INTO " + table + " VALUES (";

                // It goes from second until second to last
                for (int i = 1; i < properties.Length - 1; i++)
                {
                    object propValue = properties[i].GetValue(objGen, null);
                    string[] typeValue = propValue.GetType().ToString().Split('.');
                    if (typeValue[1].Equals("String"))
                    {
                        SQL += "'" + propValue.ToString() + "',";
                    }
                    else if (typeValue[1].Equals("DateTime"))
                    {
                        SQL += "'" + Convert.ToDateTime(propValue.ToString()).ToShortDateString() + "',";
                    }
                    else
                    {
                        SQL += propValue.ToString() + ",";
                    }
                }

                // get last attribute here
                object lastValue = properties[properties.Length - 1].GetValue(objGen, null);
                string[] lastType = lastValue.GetType().ToString().Split('.');
                if (lastType[1].Equals("String"))
                {
                    SQL += "'" + lastValue.ToString() + "'";
                }
                else if (lastType[1].Equals("DateTime"))
                {
                    SQL += "'" + Convert.ToDateTime(lastValue.ToString()).ToShortDateString() + "'";
                }
                else
                {
                    SQL += lastValue.ToString();
                }

                // Ends string builder
                SQL += ");";

                // Execute command
                NpgsqlCommand command = new NpgsqlCommand(SQL, conn);
                Int32 rowsaffected = command.ExecuteNonQuery();

                this.CloseConn();
            }
            catch (Exception)
            {
                MessageBox.Show("Errr on insert!");
            }
        }

        public void UpdateOnTable(Object objGen, int idValue)
        {
            try
            {
                this.OpenConn();

                // Get table
                string[] type = objGen.GetType().ToString().Split('.');
                string table = type[2].ToLower();

                // Start building
                string SQL = "UPDATE " + table + " SET ";

                // Get types and properties
                Type type2 = objGen.GetType();
                PropertyInfo[] properties = type2.GetProperties();

                // Goes until second to last
                for (int i = 0; i < properties.Length - 1; i++)
                {
                    object propValue = properties[i].GetValue(objGen, null);
                    string[] nameAttribute = properties[i].ToString().Split(' ');
                    string[] typeAttribute = propValue.GetType().ToString().Split('.');

                    if (typeAttribute[1].Equals("String"))
                    {
                        SQL += nameAttribute[1] + " = '" + propValue.ToString() + "',";
                    }
                    else if (typeAttribute[1].Equals("DateTime"))
                    {
                        SQL += nameAttribute[1] + "= '" + Convert.ToDateTime(propValue.ToString()).ToShortDateString() + "',";
                    }
                    else
                    {
                        SQL += nameAttribute[1] + " = " + propValue.ToString() + ",";
                    }
                }

                // Process last attribute
                object lastValue = properties[properties.Length - 1].GetValue(objGen, null);
                string[] lastType = lastValue.GetType().ToString().Split('.');
                string[] ultimoCampo = properties[properties.Length - 1].ToString().Split(' ');
                if (lastType[1].Equals("String"))
                {
                    SQL += ultimoCampo[1] + " = '" + lastValue.ToString() + "'";
                }
                else if (lastType[1].Equals("DateTime"))
                {
                    SQL += ultimoCampo[1] + "= '" + Convert.ToDateTime(lastValue.ToString()).ToShortDateString() + "'";
                }
                else
                {
                    SQL += ultimoCampo[1] + " = " + lastValue.ToString();
                }

                // Ends string builder
                SQL += " WHERE id = " + idValue + ";";

                // Execute query
                NpgsqlCommand command = new NpgsqlCommand(SQL, conn);
                Int32 rowsaffected = command.ExecuteNonQuery();

                this.CloseConn();
            }
            catch (Exception)
            {
                MessageBox.Show("Errr on update!");
            }
        }

        public void DeleteOnTable(Object objGen, int idValue)
        {
            try
            {
                this.OpenConn();

                string[] type = objGen.GetType().ToString().Split('.');
                string table = type[2];

                string SQL = "DELETE FROM " + table + " WHERE id = " + idValue + ";";

                NpgsqlCommand command = new NpgsqlCommand(SQL, conn);
                Int32 rowsaffected = command.ExecuteNonQuery();

                this.CloseConn();
            }
            catch (Exception)
            {
                MessageBox.Show("Errr on update!");
            }
        }

        public List<Object> QueryAllOnTable(string table)
        {
            try
            {
                this.OpenConn();

                List<Object> lstSelect = new List<Object>();
                string SQL = "SELECT * FROM " + table + ";";

                NpgsqlCommand command = new NpgsqlCommand(SQL, conn);
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        lstSelect.Add(dr[i]);
                    }
                }

                this.CloseConn();

                return lstSelect;
            }
            catch (Exception)
            {
                MessageBox.Show("Errr on query!");
                return null;
            }
        }

        //public List<Object> QueryOnTableWithParams(string table, string[] paramName, string[] paramValue)
        //{
        //    try
        //    {
        //        if (paramName.Count != paramValue.Count)
        //        {
        //            MessageBox.Show("Wrong number of params");
        //            return null;
        //        }

        //        this.OpenConn();

        //        List<Object> lstSelect = new List<Object>();
        //        string SQL = "SELECT * FROM " + table + " WHERE ";

        //        // get params
        //        for (int i = 0; i < paramName.Count - 1; i++)
        //        {
        //            SQL += paramName[i] + " = " + paramValue[i] + " AND ";
        //        }

        //        // get last param
        //        SQL += paramName[paramName.Count - 1] + " = " + paramValue[paramValue.Count - 1] + ";";

        //        NpgsqlCommand command = new NpgsqlCommand(SQL, conn);
        //        NpgsqlDataReader dr = command.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            for (int i = 0; i < dr.FieldCount; i++)
        //            {
        //                lstSelect.Add(dr[i]);
        //            }
        //        }

        //        this.CloseConn();

        //        return lstSelect;
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Errr on query!");
        //        return null;
        //    }
        //}
    }
}
