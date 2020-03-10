namespace BTL_HQTCSDL
{
    partial class FrmLoadData
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefersh = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lvData = new System.Windows.Forms.ListView();
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFeature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSRID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(516, 470);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(237, 470);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add layer";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRefersh
            // 
            this.btnRefersh.Location = new System.Drawing.Point(122, 470);
            this.btnRefersh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefersh.Name = "btnRefersh";
            this.btnRefersh.Size = new System.Drawing.Size(48, 23);
            this.btnRefersh.TabIndex = 7;
            this.btnRefersh.Text = "refersh";
            this.btnRefersh.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(9, 470);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(108, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Change conection";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lvData
            // 
            this.lvData.AutoArrange = false;
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clName,
            this.clType,
            this.clFeature,
            this.clSRID});
            this.lvData.FullRowSelect = true;
            this.lvData.GridLines = true;
            this.lvData.Location = new System.Drawing.Point(9, 10);
            this.lvData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(572, 457);
            this.lvData.TabIndex = 5;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // clName
            // 
            this.clName.Text = "Layer Name";
            this.clName.Width = 279;
            // 
            // clType
            // 
            this.clType.Text = "Shape Type";
            this.clType.Width = 132;
            // 
            // clFeature
            // 
            this.clFeature.Text = "Feature";
            this.clFeature.Width = 187;
            // 
            // clSRID
            // 
            this.clSRID.Text = "SRID";
            this.clSRID.Width = 140;
            // 
            // FrmLoadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 503);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefersh);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lvData);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLoadData";
            this.Text = "FrmLoadData";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefersh;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clType;
        private System.Windows.Forms.ColumnHeader clFeature;
        private System.Windows.Forms.ColumnHeader clSRID;

    }
}