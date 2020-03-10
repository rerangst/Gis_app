namespace App_tmp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLoadData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pan = new System.Windows.Forms.ToolStripButton();
            this.zoom_more = new System.Windows.Forms.ToolStripButton();
            this.test = new System.Windows.Forms.ToolStripButton();
            this.tsbSeclectLayer = new System.Windows.Forms.ToolStripButton();
            this.tsbQPolygon = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbPrj = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.axMap1 = new AxMapWinGIS.AxMap();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.mnLoadData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_open,
            this.infoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_open
            // 
            this.menu_open.Name = "menu_open";
            this.menu_open.Size = new System.Drawing.Size(114, 24);
            this.menu_open.Text = "Open";
            this.menu_open.Click += new System.EventHandler(this.menu_open_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // mnLoadData
            // 
            this.mnLoadData.Name = "mnLoadData";
            this.mnLoadData.Size = new System.Drawing.Size(90, 24);
            this.mnLoadData.Text = "Load Data";
            this.mnLoadData.Click += new System.EventHandler(this.mnLoadData_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pan,
            this.zoom_more,
            this.test,
            this.tsbSeclectLayer,
            this.tsbQPolygon});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(835, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pan
            // 
            this.pan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(23, 22);
            this.pan.Text = "Di chuyển";
            this.pan.Click += new System.EventHandler(this.pan_Click);
            // 
            // zoom_more
            // 
            this.zoom_more.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoom_more.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoom_more.Name = "zoom_more";
            this.zoom_more.Size = new System.Drawing.Size(23, 22);
            this.zoom_more.Text = "Hiển thị mặc định";
            this.zoom_more.Click += new System.EventHandler(this.zoom_more_Click);
            // 
            // test
            // 
            this.test.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.test.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(23, 22);
            this.test.Text = "Hiển thị thuộc tính các lớp";
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // tsbSeclectLayer
            // 
            this.tsbSeclectLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSeclectLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSeclectLayer.Name = "tsbSeclectLayer";
            this.tsbSeclectLayer.Size = new System.Drawing.Size(23, 22);
            this.tsbSeclectLayer.Text = "Lựa chọn lớp hiển thị";
            this.tsbSeclectLayer.Click += new System.EventHandler(this.tsbSeclectLayer_Click);
            // 
            // tsbQPolygon
            // 
            this.tsbQPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQPolygon.Name = "tsbQPolygon";
            this.tsbQPolygon.Size = new System.Drawing.Size(23, 22);
            this.tsbQPolygon.Text = "Lựa chọn vùng không gian";
            this.tsbQPolygon.Click += new System.EventHandler(this.tsbQPolygon_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbPrj,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 673);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(835, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbPrj
            // 
            this.lbPrj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPrj.Name = "lbPrj";
            this.lbPrj.Size = new System.Drawing.Size(128, 20);
            this.lbPrj.Text = "Hệ tọa độ WGS84";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 20);
            this.toolStripStatusLabel1.Text = "Kinh độ: ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripStatusLabel2.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(51, 20);
            this.toolStripStatusLabel2.Text = "Vĩ độ: ";
            // 
            // axMap1
            // 
            this.axMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(0, 53);
            this.axMap1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(835, 620);
            this.axMap1.TabIndex = 4;
            this.axMap1.MouseMoveEvent += new AxMapWinGIS._DMapEvents_MouseMoveEventHandler(this.axMap1_MouseMoveEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 698);
            this.Controls.Add(this.axMap1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_open;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton pan;
        private System.Windows.Forms.ToolStripButton zoom_more;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripButton test;
        private System.Windows.Forms.ToolStripButton tsbSeclectLayer;
        private System.Windows.Forms.ToolStripStatusLabel lbPrj;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnLoadData;
        private AxMapWinGIS.AxMap axMap1;
        private System.Windows.Forms.ToolStripButton tsbQPolygon;

    }
}

