using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_tmp
{
    public partial class fShowData : Form
    {
        public delegate void ZoomTo(string sfName,int indexOfShape);
        public event ZoomTo ZoomToShape;
        private DataTable dataSource = new DataTable();

        public DataTable DataSource
        {
            get { return dataSource; }
            set { dataSource = value; }
        }
        public fShowData(Dictionary<string, MapWinGIS.Shapefile> _sf, Dictionary<string, bool> options)
        {
            InitializeComponent();
            ShowTree(_sf,options);
        }
        void ShowTree(Dictionary<string, MapWinGIS.Shapefile> sf, Dictionary<string, bool> options)
        {
            foreach (var item in sf.Keys)
            {
                if (options[item])
                {
                    string sql = String.Format("SELECT * FROM " + item);
                    DataProvider dp = new DataProvider();
                    dataSource = dp.ExecuteQuery(sql);
                    TreeNode tmpRoot = new TreeNode();
                    tmpRoot.Text = item;
                    tmpRoot.Name = item;
                    tvData.Nodes.Add(tmpRoot);

                    //string options = "ten";
                    //DataTable dt = new DataTable();
                    //int id = (from DataRow dr in dt.Rows where (string)dr["CountryName"] == options select (int)dr["id"]).FirstOrDefault();

                    for (int i = 0; i < dataSource.Columns["ten"].Table.Rows.Count; i++)
                    {
                        TreeNode tmpChirld = new TreeNode();
                        Object cellValue = dataSource.Rows[i]["ten"];
                        tmpChirld.Name = Convert.ToString(cellValue);
                        tmpChirld.Text = Convert.ToString(cellValue);
                        tmpRoot.Nodes.Add(tmpChirld);
                    }
                    //tvData.AfterSelect += new TreeViewEventHandler(tvData_AfterSelect);
                    //tvData.NodeMouseClick += new TreeNodeMouseClickEventHandler(tvData_NodeMouseClick);
                    tvData.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(tvData_NodeMouseDoubleClick);
                    
                }
            }
        }

        void tvData_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var tmpChirldNode = (sender as TreeView).SelectedNode;

            //MessageBox.Show(e.GetType().ToString());
            if (tmpChirldNode.Parent == null)
            {
                return;
            }
            else
            {
                var tmpParentNode = tmpChirldNode;
                int indexOfChirld = 0;
                fPanelAdd.Controls.Clear();
                while (tmpParentNode.Parent != null)
                {
                    tmpParentNode = tmpParentNode.Parent;
                }

                string sql = String.Format("SELECT * FROM " + tmpParentNode.Text);

                DataProvider dp = new DataProvider();
                dataSource = dp.ExecuteQuery(sql);

                for (int i = 0; i < dataSource.Columns["ten"].Table.Rows.Count; i++)
                {
                    Object cellValue = dataSource.Rows[i]["ten"];
                    if (tmpChirldNode.Text == Convert.ToString(cellValue))
                    {
                        indexOfChirld = i;
                        break;
                    }
                }
                //Add control
                for (int i = 0; i < dataSource.Columns.Count; i++)
                {
                    Label tmp_lb = new Label();
                    tmp_lb.Text = dataSource.Columns[i].ColumnName;
                    fPanelAdd.Controls.Add(tmp_lb);
                    TextBox txt_tmp = new TextBox();
                    txt_tmp.Name = dataSource.Columns[i].ColumnName;
                    txt_tmp.Text = Convert.ToString(dataSource.Rows[indexOfChirld][i]);

                    fPanelAdd.Controls.Add(txt_tmp);
                }
                if (tmpParentNode.Text == "brunei_airports")
                {
                    //DataProvider tmpdp = new DataProvider();
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(dp.GetImage(tmpParentNode.Text, tmpChirldNode.Text)))
                    {
                        pbImage.Image = Image.FromStream(ms);
                    }
                    dp.GetImage(tmpParentNode.Text, tmpChirldNode.Text);
                }
                

                ZoomToShape(tmpParentNode.Text, indexOfChirld);
            }
        }

        void tvData_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var tmpChirldNode = (sender as TreeView).SelectedNode;
            if (tmpChirldNode.Parent == null)
            {
                return;
            }
            else
            {
                var tmpParentNode = tmpChirldNode;
                int indexOfChirld = 0;
                fPanelAdd.Controls.Clear();
                while (tmpParentNode.Parent != null)
                {
                    tmpParentNode = tmpParentNode.Parent;
                }

                string sql = String.Format("SELECT * FROM " + tmpParentNode.Text);

                DataProvider dp = new DataProvider();
                dataSource = dp.ExecuteQuery(sql);

                for (int i = 0; i < dataSource.Columns["ten"].Table.Rows.Count; i++)
                {
                    Object cellValue = dataSource.Rows[i]["ten"];
                    if (tmpChirldNode.Text == Convert.ToString(cellValue))
                    {
                        indexOfChirld = i;
                        break;
                    }
                }
                //Add control
                for (int i = 0; i < dataSource.Columns.Count; i++)
                {
                    Label tmp_lb = new Label();
                    tmp_lb.Text = dataSource.Columns[i].ColumnName;
                    fPanelAdd.Controls.Add(tmp_lb);
                    TextBox txt_tmp = new TextBox();
                    txt_tmp.Name = dataSource.Columns[i].ColumnName;
                    txt_tmp.Text = Convert.ToString(dataSource.Rows[indexOfChirld][i]);

                    fPanelAdd.Controls.Add(txt_tmp);
                }
            }
        }

        void tvData_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var tmpChirldNode = (sender as TreeView).SelectedNode;
            
            //MessageBox.Show(e.GetType().ToString());
            if (tmpChirldNode.Parent == null)
            {
                return;
            }
            else
            {
                var tmpParentNode = tmpChirldNode;
                int indexOfChirld = 0;
                fPanelAdd.Controls.Clear();
                while (tmpParentNode.Parent != null)
                {
                    tmpParentNode = tmpParentNode.Parent;
                }

                string sql = String.Format("SELECT * FROM " + tmpParentNode.Text);

                DataProvider dp = new DataProvider();
                dataSource = dp.ExecuteQuery(sql);

                for (int i = 0; i < dataSource.Columns["ten"].Table.Rows.Count; i++)
                {
                    Object cellValue = dataSource.Rows[i]["ten"];
                    if (tmpChirldNode.Text == Convert.ToString(cellValue))
                    {
                        indexOfChirld = i;
                        break;
                    }
                }
                //Add control
                for (int i = 0; i < dataSource.Columns.Count; i++)
                {
                    Label tmp_lb = new Label();
                    tmp_lb.Text = dataSource.Columns[i].ColumnName;
                    fPanelAdd.Controls.Add(tmp_lb);
                    TextBox txt_tmp = new TextBox();
                    txt_tmp.Name = dataSource.Columns[i].ColumnName;
                    txt_tmp.Text = Convert.ToString(dataSource.Rows[indexOfChirld][i]);

                    fPanelAdd.Controls.Add(txt_tmp);
                }
                if (tmpParentNode.Text == "brunei_airports")
                {
                    //DataProvider tmpdp = new DataProvider();
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(dp.GetImage(tmpParentNode.Text, tmpChirldNode.Text)))
                    {
                        pbImage.Image = Image.FromStream(ms);
                    }
                    dp.GetImage(tmpParentNode.Text, tmpChirldNode.Text);
                }
                
                ZoomToShape(tmpParentNode.Text, indexOfChirld);
            }
            
        }


    }
}
