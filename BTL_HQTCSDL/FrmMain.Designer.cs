namespace BTL_HQTCSDL
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImport = new System.Windows.Forms.ToolStripButton();
            this.zoom_in = new System.Windows.Forms.ToolStripButton();
            this.zoom_out = new System.Windows.Forms.ToolStripButton();
            this.pan = new System.Windows.Forms.ToolStripButton();
            this.zoom_more = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAnotation = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVP = new System.Windows.Forms.ToolStripButton();
            this.btnShowCellInfo = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbPrj = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvListLayer = new System.Windows.Forms.TreeView();
            this.axMap1 = new AxMapWinGIS.AxMap();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImport,
            this.zoom_in,
            this.zoom_out,
            this.pan,
            this.zoom_more,
            this.toolStripSeparator2,
            this.btnAnotation,
            this.btnExport,
            this.toolStripSeparator1,
            this.btnVP,
            this.btnShowCellInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(34, 687);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnImport
            // 
            this.btnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(32, 24);
            this.btnImport.Text = "Mở lớp dữ liệu";
            // 
            // zoom_in
            // 
            this.zoom_in.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoom_in.Image = ((System.Drawing.Image)(resources.GetObject("zoom_in.Image")));
            this.zoom_in.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoom_in.Name = "zoom_in";
            this.zoom_in.Size = new System.Drawing.Size(32, 24);
            this.zoom_in.Text = "Zoom out";
            // 
            // zoom_out
            // 
            this.zoom_out.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoom_out.Image = ((System.Drawing.Image)(resources.GetObject("zoom_out.Image")));
            this.zoom_out.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoom_out.Name = "zoom_out";
            this.zoom_out.Size = new System.Drawing.Size(32, 24);
            this.zoom_out.Text = "Zoom in";
            // 
            // pan
            // 
            this.pan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pan.Image = ((System.Drawing.Image)(resources.GetObject("pan.Image")));
            this.pan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(32, 24);
            this.pan.Text = "pan";
            // 
            // zoom_more
            // 
            this.zoom_more.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoom_more.Image = ((System.Drawing.Image)(resources.GetObject("zoom_more.Image")));
            this.zoom_more.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoom_more.Name = "zoom_more";
            this.zoom_more.Size = new System.Drawing.Size(32, 24);
            this.zoom_more.Text = "Zoom to layer";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(32, 6);
            // 
            // btnAnotation
            // 
            this.btnAnotation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnotation.Image = ((System.Drawing.Image)(resources.GetObject("btnAnotation.Image")));
            this.btnAnotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnotation.Name = "btnAnotation";
            this.btnAnotation.Size = new System.Drawing.Size(32, 24);
            this.btnAnotation.Text = "Gán nhãn dữ liệu";
            // 
            // btnExport
            // 
            this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(32, 24);
            this.btnExport.Text = "Lưu vào CDSL";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(32, 6);
            // 
            // btnVP
            // 
            this.btnVP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVP.Image = ((System.Drawing.Image)(resources.GetObject("btnVP.Image")));
            this.btnVP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVP.Name = "btnVP";
            this.btnVP.Size = new System.Drawing.Size(32, 24);
            this.btnVP.Text = "Chọn layer từ CSDL";
            // 
            // btnShowCellInfo
            // 
            this.btnShowCellInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowCellInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnShowCellInfo.Image")));
            this.btnShowCellInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowCellInfo.Name = "btnShowCellInfo";
            this.btnShowCellInfo.Size = new System.Drawing.Size(32, 24);
            this.btnShowCellInfo.Text = "Truy vấn";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbPrj,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(34, 665);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(912, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbPrj
            // 
            this.lbPrj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPrj.Name = "lbPrj";
            this.lbPrj.Size = new System.Drawing.Size(65, 17);
            this.lbPrj.Text = "Hệ tọa độ: ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 17);
            this.toolStripStatusLabel1.Text = "Kinh độ: ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(34, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvListLayer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axMap1);
            this.splitContainer1.Size = new System.Drawing.Size(912, 665);
            this.splitContainer1.SplitterDistance = 197;
            this.splitContainer1.TabIndex = 6;
            // 
            // tvListLayer
            // 
            this.tvListLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvListLayer.Location = new System.Drawing.Point(0, 0);
            this.tvListLayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvListLayer.Name = "tvListLayer";
            this.tvListLayer.Size = new System.Drawing.Size(197, 665);
            this.tvListLayer.TabIndex = 4;
            // 
            // axMap1
            // 
            this.axMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(0, 0);
            this.axMap1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(711, 665);
            this.axMap1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 687);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton zoom_in;
        private System.Windows.Forms.ToolStripButton zoom_out;
        private System.Windows.Forms.ToolStripButton pan;
        private System.Windows.Forms.ToolStripButton zoom_more;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAnotation;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnVP;
        private System.Windows.Forms.ToolStripButton btnShowCellInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbPrj;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvListLayer;
        private AxMapWinGIS.AxMap axMap1;
    }
}

