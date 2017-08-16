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
    public partial class fSelectLayer : Form
    {
        public delegate void LayerOption(Dictionary<string, bool> options);
        public event LayerOption ChangeOpion;
        public fSelectLayer(Dictionary<string, MapWinGIS.Shapefile> _sf, Dictionary<string, bool> options)
        {
            InitializeComponent();
            ShowLayer(_sf, options);
        }
        void ShowLayer(Dictionary<string, MapWinGIS.Shapefile> sf, Dictionary<string, bool> options)
        {
            fPanelLayer.Controls.Clear();
            foreach (var item in sf.Keys)
            {
                if (item != "dongnama")
                {
                    CheckBox tmpCheckBox = new CheckBox();
                    
                    tmpCheckBox.Width = (fPanelLayer.Width -20) / 2;
                    tmpCheckBox.Height = (fPanelLayer.Height - 40) / (sf.Count / 2);
                    tmpCheckBox.Checked = options[item];
                    tmpCheckBox.Text = item;
                    tmpCheckBox.Name = item;
                    fPanelLayer.Controls.Add(tmpCheckBox);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Dictionary<string, bool> options = new Dictionary<string, bool>();
            foreach (CheckBox item in fPanelLayer.Controls)
            {
                options.Add(item.Name, item.Checked);
            }
            ChangeOpion(options);
        }
    }
}
