using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;


namespace App_tmp
{
    public partial class fAdmin : Form
    {
        public delegate void dltruyen();
        public event dltruyen Sk_sua;
        public delegate void dltruyen_luu(string filenames);
        public event dltruyen_luu Sk_luu;
        public delegate void dltruyen_bang(string value, int ColumnIndex, int RowIndex);
        public event dltruyen_bang Sk_sua_table;
        public delegate void dltruyen_shape(int RowIndex);
        public event dltruyen_shape Sk_select_shape;
        public delegate void dltruyen_fieldtype(string s, int ft);
        public event dltruyen_fieldtype Sk_add_field, Sk_remove_field;

        public fAdmin(Dictionary<string, MapWinGIS.Shapefile> _sf)
        {
            InitializeComponent();
            dgvData.CellClick += new DataGridViewCellEventHandler(dgvData_CellClick);
            ShowData(_sf);
        }

        void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Sk_sua();
            Sk_select_shape(e.RowIndex);
        }
        void ShowData(Dictionary<string, MapWinGIS.Shapefile> sf)
        {
            dgvData.ReadOnly = true;
            foreach (var item in sf.Keys)
	        {
                string[] tmp=item.Split(new Char[] { '.' });
		        cbbLayers.Items.Add(tmp[0]);
	        }
            cbbLayers.SelectedIndexChanged += new EventHandler(cbbLayers_SelectedIndexChanged);
            tAccount.Enter += new EventHandler(tAccount_Enter);
        }

        void tAccount_Enter(object sender, EventArgs e)
        {
            dgvAccount.ReadOnly = true;
            DataProvider dp = new DataProvider();
            string sql = String.Format("SELECT * FROM account");
            dgvAccount.DataSource = dp.ExecuteQuery(sql);

        }

        void cbbLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbb_tmp = sender as ComboBox;
            string sql = String.Format("SELECT * FROM " + cbb_tmp.SelectedItem.ToString());
            DataProvider dp = new DataProvider();
            dgvData.DataSource= dp.ExecuteQuery(sql);
            fPanelAdd.Controls.Clear();
            //Add control
            for (int i = 0; i < dgvData.ColumnCount; i++)
            {
                Label tmp_lb = new Label();
                tmp_lb.Text = dgvData.Columns[i].HeaderText;
                fPanelAdd.Controls.Add(tmp_lb);
                TextBox txt_tmp = new TextBox();
                txt_tmp.Name = dgvData.Columns[i].HeaderText;
                txt_tmp.DataBindings.Add(new Binding("Text", dgvData.DataSource, dgvData.Columns[i].HeaderText));
                fPanelAdd.Controls.Add(txt_tmp);
            }
            
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] s = new string[dgvData.ColumnCount];
            int i=0;
            foreach (Control item in fPanelAdd.Controls)
            {
                if (item is TextBox)
                {
                    s[i]= item.Text;
                    i++;
                    
                }
            }
        }

        void btn_Cancel_Click(object sender, EventArgs e)
        {
            fPanelAdd.Controls.Clear();
        }

        void btn_Add_Click(object sender, EventArgs e)
        {
//            var dataSource = dataGridView1.DataSource as BindingSource;
//var dataTable = dataSource.DataSource as DataTable;

//dataTable.Rows.Add(value1, value2,...)
//            DataTable dt = dgvData.DataSource as DataTable;
//            DataRow row = dt.Rows[0];            
//            int RowIndex = dt.Rows.Count - 1;
//            
//            dt.Rows.Add();
//            dgvData.DataSource = dt;
        }        
    }
}
