namespace App_tmp
{
    partial class fSelectLayer
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
            this.fPanelLayer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fPanelLayer
            // 
            this.fPanelLayer.Location = new System.Drawing.Point(12, 12);
            this.fPanelLayer.Name = "fPanelLayer";
            this.fPanelLayer.Size = new System.Drawing.Size(541, 287);
            this.fPanelLayer.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(228, 305);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 36);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Hiển thị";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(394, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fSelectLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 353);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.fPanelLayer);
            this.Name = "fSelectLayer";
            this.Text = "Chọn dữ liệu hiển thị";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fPanelLayer;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
    }
}