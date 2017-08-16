namespace App_tmp
{
    partial class LoadData
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
            this.lvData = new System.Windows.Forms.ListView();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRefersh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFeature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSRID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.lvData.Location = new System.Drawing.Point(12, 12);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(762, 561);
            this.lvData.TabIndex = 0;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 579);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(144, 28);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Change conection";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnRefersh
            // 
            this.btnRefersh.Location = new System.Drawing.Point(162, 579);
            this.btnRefersh.Name = "btnRefersh";
            this.btnRefersh.Size = new System.Drawing.Size(64, 28);
            this.btnRefersh.TabIndex = 2;
            this.btnRefersh.Text = "refersh";
            this.btnRefersh.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(316, 579);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add layer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click +=new System.EventHandler(btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(688, 579);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // clName
            // 
            this.clName.Text = "Layer Name";
            this.clName.Width = 279;
            // 
            // clType
            // 
            this.clType.Text = "Shape Type";
            this.clType.Width = 166;
            // 
            // clFeature
            // 
            this.clFeature.Text = "Feature";
            this.clFeature.Width = 187;
            // 
            // clSRID
            // 
            this.clSRID.Text = "SRID";
            this.clSRID.Width = 114;
            // 
            // LoadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 647);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefersh);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lvData);
            this.Name = "LoadData";
            this.Text = "LoadData";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clType;
        private System.Windows.Forms.ColumnHeader clFeature;
        private System.Windows.Forms.ColumnHeader clSRID;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRefersh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;


    }
}