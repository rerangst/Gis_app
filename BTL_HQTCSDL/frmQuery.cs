using MapWinGIS;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Npgsql.LegacyPostgis;

namespace BTL_HQTCSDL
{
    public partial class frmQuery : Form
    {
        private List<string> layerName;
        private List<string> infor;
        NpgsqlConnection conn;
        public frmQuery()
        {
            InitializeComponent();
            
        }

        public frmQuery(List<string> layerName, string connect)
        {
            
            InitializeComponent();
            this.layerName = layerName;
            if (connect.Length<1)
            {
                MessageBox.Show("Bạn phải kết nối đến CSDL!!!");
                return;
            }
            string[] strlist = connect.Split(' ');
            infor = new List<string>();
            for (int i=0; i< strlist.Length; i++)
            {
                string tmp = strlist[i].Split('=')[1];
                infor.Add(tmp);
            }
        }

        private void frmQuery_Load(object sender, EventArgs e)
        {
            //checkBox1.Checked
            cbxQueryType.DataBindings.Add("Enabled", checkBox1, "Checked");
            var connStr = string.Format("Server=127.0.0.1;User Id={0};Password={1};Database={2};",
             infor[2], infor[3], infor[1]);
            //MessageBox.Show(connStr);
            conn = new NpgsqlConnection();

            conn.ConnectionString = connStr;

            conn.Open();
            //conn.TypeMapper.UseLegacyPostgis();
            string sql_query = string.Format("select diadanh from ao_ho");
            NpgsqlCommand cmd = new NpgsqlCommand(sql_query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                List<string> row = new List<string>();
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    var tmp = dr[i];
                    if (!cbxQueryType.Items.Contains(tmp.ToString())) 
                    {
                        cbxQueryType.Items.Add(tmp.ToString());
                    }
                }
            }
            ////////////////////////
            //cbxQueryType.Items.Add("ST_Intersects");
            ////cbxQueryType.Items.Add("ST_Crosses");
            //cbxQueryType.Items.Add("Joins");
            //for (int i = 0; i < layerName.Count; i++)
            //{
            //    cbxLayer1.Items.Add(layerName[i]);
            //    cbxLayer2.Items.Add(layerName[i]);
            //}
            //cbxLayer1.SelectedIndex = 0;
            //cbxLayer2.SelectedIndex = 0;

        }

        private void cbxLayer1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxLayer2.Items.Clear();
            for (int i = 0; i < cbxLayer1.Items.Count; i++)
            {
                if (cbxLayer1.Items[i] != cbxLayer1.SelectedItem)
                {
                    cbxLayer2.Items.Add(cbxLayer1.Items[i]);
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dgvQuery.DataSource = null;
            dgvQuery.Columns.Clear();
            dgvQuery.Rows.Clear();
            var connStr = string.Format("Server=127.0.0.1;User Id={0};Password={1};Database={2};", 
               infor[2], infor[3], infor[1]);
            //MessageBox.Show(connStr);
            conn = new NpgsqlConnection();

            conn.ConnectionString = connStr;

            conn.Open();
            string sql_query = "";
            if (checkBox1.Checked)
            {
                sql_query = string.Format("select {0}.diadanh from {0} join {1} on ST_Intersects({0}.geom,{1}.geom) where ao_ho.diadanh='{2}' group by {0}.diadanh",
                                                    cbxLayer1.SelectedItem, cbxLayer2.SelectedItem,cbxQueryType.Text);
            }
            else
            {

                sql_query = string.Format("select {0}.diadanh from {0} join {1} on ST_Intersects({0}.geom,{1}.geom) group by {0}.diadanh",
                                                    cbxLayer1.SelectedItem, cbxLayer2.SelectedItem);
            }
            NpgsqlCommand cmd = new NpgsqlCommand(sql_query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();
            List<List<string>> lstResult = new List<List<string>>();

            while (dr.Read())
            {
                List<string> row = new List<string>();
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    var tmp = dr[i];
                    row.Add(dr[i].ToString());
                }
                lstResult.Add(row);
            }

            dgvQuery.ColumnCount = dr.FieldCount;
            for (int i = 0; i < dr.FieldCount; i++)
            {
                dgvQuery.Columns[i].Name = dr.GetName(i);
            }
            for (int i = 0; i < lstResult.Count; i++)
            {
                string[] row = new string[dr.FieldCount];
                for (int j = 0; j < lstResult[i].Count; j++)
                {
                    row[j] = lstResult[i][j];
                }

                dgvQuery.Rows.Add(row);
            }
            if (dgvQuery.Columns.Contains("geom"))
            {
                dgvQuery.Columns.Remove("geom");

            }

            //if (cbxQueryType.SelectedItem.ToString() == "ST_Intersects")
            //{
            //    string sql_query = string.Format("select {0}.diadanh from {0} join {1} on ST_Intersects({0}.geom,{1}.geom) group by {0}.diadanh", 
            //                                        cbxLayer1.SelectedItem, cbxLayer2.SelectedItem);
            //    NpgsqlCommand cmd = new NpgsqlCommand(sql_query, conn);

            //    // Execute a query
            //    NpgsqlDataReader dr = cmd.ExecuteReader();
            //    List<List<string>> lstResult = new List<List<string>>();

            //    while (dr.Read())
            //    {
            //        List<string> row = new List<string>();
            //        for (int i = 0; i < dr.FieldCount; i++)
            //        {
            //            var tmp = dr[i];
            //            row.Add(dr[i].ToString());
            //        }
            //        lstResult.Add(row);
            //    }

            //    dgvQuery.ColumnCount = dr.FieldCount;
            //    for (int i = 0; i < dr.FieldCount; i++)
            //    {
            //        dgvQuery.Columns[i].Name = dr.GetName(i);
            //    }
            //    for (int i = 0; i < lstResult.Count; i++)
            //    {
            //        string[] row = new string[dr.FieldCount];
            //        for (int j = 0; j < lstResult[i].Count; j++)
            //        {
            //            row[j] = lstResult[i][j];
            //        }

            //        dgvQuery.Rows.Add(row);
            //    }
            //    if (dgvQuery.Columns.Contains("geom"))
            //    {
            //        dgvQuery.Columns.Remove("geom");
                    
            //    }
            //}
            //else if (cbxQueryType.SelectedItem.ToString() == "Joins")
            //{
            //    string sql_query = string.Format("select * from {0} join {1} on ({0}.huyen= {1}.diadanh)", cbxLayer1.SelectedItem, cbxLayer2.SelectedItem);
            //    NpgsqlCommand cmd = new NpgsqlCommand(sql_query, conn);

            //    // Execute a query
            //    NpgsqlDataReader dr = cmd.ExecuteReader();
            //    List<List<string>> lstResult = new List<List<string>>();

            //    while (dr.Read())
            //    {
            //        List<string> row = new List<string>();
            //        for (int i = 0; i < dr.FieldCount; i++)
            //        {
            //            var tmp = dr[i];
            //            row.Add(dr[i].ToString());
            //        }
            //        lstResult.Add(row);
            //    }

            //    dgvQuery.ColumnCount = dr.FieldCount;
            //    for (int i = 0; i < dr.FieldCount; i++)
            //    {
            //        dgvQuery.Columns[i].Name = dr.GetName(i);
            //    }
            //    for (int i = 0; i < lstResult.Count; i++)
            //    {
            //        string[] row = new string[dr.FieldCount];
            //        for (int j = 0; j < lstResult[i].Count; j++)
            //        {
            //            row[j] = lstResult[i][j];
            //        }

            //        dgvQuery.Rows.Add(row);
            //    }
            //    if (dgvQuery.Columns.Contains("geom"))
            //    {
            //        dgvQuery.Columns.Remove("geom");

            //    }
            //}
        }
    }
}
