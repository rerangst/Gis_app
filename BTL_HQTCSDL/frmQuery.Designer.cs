namespace BTL_HQTCSDL
{
    partial class frmQuery
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvQuery = new System.Windows.Forms.DataGridView();
            this.cbxLayer1 = new System.Windows.Forms.ComboBox();
            this.cbxLayer2 = new System.Windows.Forms.ComboBox();
            this.cbxQueryType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Layer 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Layer 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên ao hồ";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(316, 166);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 26);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvQuery);
            this.panel1.Location = new System.Drawing.Point(4, 199);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 261);
            this.panel1.TabIndex = 4;
            // 
            // dgvQuery
            // 
            this.dgvQuery.AllowUserToResizeColumns = false;
            this.dgvQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuery.Location = new System.Drawing.Point(0, 0);
            this.dgvQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvQuery.Name = "dgvQuery";
            this.dgvQuery.Size = new System.Drawing.Size(472, 261);
            this.dgvQuery.TabIndex = 0;
            // 
            // cbxLayer1
            // 
            this.cbxLayer1.Enabled = false;
            this.cbxLayer1.FormattingEnabled = true;
            this.cbxLayer1.Items.AddRange(new object[] {
            "rg_xa"});
            this.cbxLayer1.Location = new System.Drawing.Point(124, 36);
            this.cbxLayer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxLayer1.Name = "cbxLayer1";
            this.cbxLayer1.Size = new System.Drawing.Size(291, 24);
            this.cbxLayer1.TabIndex = 5;
            this.cbxLayer1.Text = "rg_xa";
            this.cbxLayer1.SelectedIndexChanged += new System.EventHandler(this.cbxLayer1_SelectedIndexChanged);
            // 
            // cbxLayer2
            // 
            this.cbxLayer2.Enabled = false;
            this.cbxLayer2.FormattingEnabled = true;
            this.cbxLayer2.Items.AddRange(new object[] {
            "ao_ho"});
            this.cbxLayer2.Location = new System.Drawing.Point(124, 74);
            this.cbxLayer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxLayer2.Name = "cbxLayer2";
            this.cbxLayer2.Size = new System.Drawing.Size(291, 24);
            this.cbxLayer2.TabIndex = 6;
            this.cbxLayer2.Text = "ao_ho";
            // 
            // cbxQueryType
            // 
            this.cbxQueryType.FormattingEnabled = true;
            this.cbxQueryType.Location = new System.Drawing.Point(123, 134);
            this.cbxQueryType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxQueryType.Name = "cbxQueryType";
            this.cbxQueryType.Size = new System.Drawing.Size(291, 24);
            this.cbxQueryType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Liệt kê các xã có ao hồ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(124, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Điều kiện";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 464);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxQueryType);
            this.Controls.Add(this.cbxLayer2);
            this.Controls.Add(this.cbxLayer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQuery";
            this.Text = "Query";
            this.Load += new System.EventHandler(this.frmQuery_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvQuery;
        private System.Windows.Forms.ComboBox cbxLayer1;
        private System.Windows.Forms.ComboBox cbxLayer2;
        private System.Windows.Forms.ComboBox cbxQueryType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}