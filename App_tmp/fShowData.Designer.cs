namespace App_tmp
{
    partial class fShowData
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
            this.tvData = new System.Windows.Forms.TreeView();
            this.fPanelAdd = new System.Windows.Forms.FlowLayoutPanel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tvData
            // 
            this.tvData.Location = new System.Drawing.Point(12, 12);
            this.tvData.Name = "tvData";
            this.tvData.Size = new System.Drawing.Size(379, 729);
            this.tvData.TabIndex = 0;
            // 
            // fPanelAdd
            // 
            this.fPanelAdd.Location = new System.Drawing.Point(397, 12);
            this.fPanelAdd.Name = "fPanelAdd";
            this.fPanelAdd.Size = new System.Drawing.Size(573, 313);
            this.fPanelAdd.TabIndex = 4;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(397, 331);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(573, 410);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;
            // 
            // fShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.fPanelAdd);
            this.Controls.Add(this.tvData);
            this.Name = "fShowData";
            this.Text = "fShowData";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvData;
        private System.Windows.Forms.FlowLayoutPanel fPanelAdd;
        private System.Windows.Forms.PictureBox pbImage;
    }
}