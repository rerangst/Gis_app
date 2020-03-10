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
    public partial class fShowTable : Form
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

        public fShowTable(Dictionary<string, string> listAirPort)
        {
            InitializeComponent();
            ShowData(listAirPort);
        }
        void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Sk_sua();
            Sk_select_shape(e.RowIndex);
        }
        void ShowData(Dictionary<string, string> list)
        {
            dgvData.ReadOnly = true;
            DataTable dt = new DataTable();
            
            DataProvider dp = new DataProvider();
            foreach (var item in list.Keys)
            {
                var query = "SELECT * FROM " + list[item] +" WHERE ten= '"+item+"'";
                var tmpData = dp.ExecuteQuery(query);
                if (dt.Rows.Count==0)
                {
                    dt = tmpData; 
                }
                else
                {
                    DataRow tmp_row = tmpData.Rows[0];
                    dt.NewRow();
                    dt.ImportRow(tmp_row);
                }                
            }
            dgvData.DataSource = dt;
        } 

        void btn_Cancel_Click(object sender, EventArgs e)
        {
            fPanelAdd.Controls.Clear();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportPDF exPDF = new ExportPDF();
            exPDF.ExportToPdf((DataTable)dgvData.DataSource);
            MessageBox.Show("done");
        }
        


       
    }
}
