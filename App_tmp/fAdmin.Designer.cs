namespace App_tmp
{
    partial class fAdmin
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
            this.tAdmin = new System.Windows.Forms.TabControl();
            this.tData = new System.Windows.Forms.TabPage();
            this.fPanelAdd = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLayers = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tAccount = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSreachAccount = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.tAdmin.SuspendLayout();
            this.tData.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tAccount.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tAdmin
            // 
            this.tAdmin.Controls.Add(this.tData);
            this.tAdmin.Controls.Add(this.tAccount);
            this.tAdmin.Location = new System.Drawing.Point(12, 12);
            this.tAdmin.Name = "tAdmin";
            this.tAdmin.SelectedIndex = 0;
            this.tAdmin.Size = new System.Drawing.Size(916, 665);
            this.tAdmin.TabIndex = 0;
            // 
            // tData
            // 
            this.tData.Controls.Add(this.fPanelAdd);
            this.tData.Controls.Add(this.panel3);
            this.tData.Controls.Add(this.panel2);
            this.tData.Controls.Add(this.panel1);
            this.tData.Location = new System.Drawing.Point(4, 25);
            this.tData.Name = "tData";
            this.tData.Padding = new System.Windows.Forms.Padding(3);
            this.tData.Size = new System.Drawing.Size(908, 636);
            this.tData.TabIndex = 0;
            this.tData.Text = "Dữ liệu";
            this.tData.UseVisualStyleBackColor = true;
            // 
            // fPanelAdd
            // 
            this.fPanelAdd.Location = new System.Drawing.Point(547, 77);
            this.fPanelAdd.Name = "fPanelAdd";
            this.fPanelAdd.Size = new System.Drawing.Size(355, 556);
            this.fPanelAdd.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvData);
            this.panel3.Location = new System.Drawing.Point(6, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 556);
            this.panel3.TabIndex = 2;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(3, 3);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(529, 550);
            this.dgvData.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbbLayers);
            this.panel2.Location = new System.Drawing.Point(547, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 65);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn lớp dữ liệu:";
            // 
            // cbbLayers
            // 
            this.cbbLayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLayers.FormattingEnabled = true;
            this.cbbLayers.Location = new System.Drawing.Point(132, 21);
            this.cbbLayers.Name = "cbbLayers";
            this.cbbLayers.Size = new System.Drawing.Size(220, 24);
            this.cbbLayers.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(403, 12);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(89, 41);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(274, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 41);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(149, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 41);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa ";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tAccount
            // 
            this.tAccount.Controls.Add(this.flowLayoutPanel2);
            this.tAccount.Controls.Add(this.panel4);
            this.tAccount.Controls.Add(this.panel5);
            this.tAccount.Controls.Add(this.panel6);
            this.tAccount.Location = new System.Drawing.Point(4, 25);
            this.tAccount.Name = "tAccount";
            this.tAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tAccount.Size = new System.Drawing.Size(908, 636);
            this.tAccount.TabIndex = 1;
            this.tAccount.Text = "Tài khoản";
            this.tAccount.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(547, 76);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(355, 556);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvAccount);
            this.panel4.Location = new System.Drawing.Point(6, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 556);
            this.panel4.TabIndex = 6;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(3, 3);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(529, 550);
            this.dgvAccount.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSreachAccount);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Location = new System.Drawing.Point(547, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(355, 65);
            this.panel5.TabIndex = 5;
            // 
            // btnSreachAccount
            // 
            this.btnSreachAccount.Location = new System.Drawing.Point(248, 12);
            this.btnSreachAccount.Name = "btnSreachAccount";
            this.btnSreachAccount.Size = new System.Drawing.Size(89, 41);
            this.btnSreachAccount.TabIndex = 4;
            this.btnSreachAccount.Text = "Tìm kiếm";
            this.btnSreachAccount.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 22);
            this.textBox2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnViewAccount);
            this.panel6.Controls.Add(this.btnEditAccount);
            this.panel6.Controls.Add(this.btnDeleteAccount);
            this.panel6.Controls.Add(this.btnAddAccount);
            this.panel6.Location = new System.Drawing.Point(6, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(535, 65);
            this.panel6.TabIndex = 4;
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Location = new System.Drawing.Point(403, 12);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(89, 41);
            this.btnViewAccount.TabIndex = 3;
            this.btnViewAccount.Text = "Xem";
            this.btnViewAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(274, 12);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(89, 41);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(149, 12);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(89, 41);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(29, 12);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(89, 41);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm ";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 689);
            this.Controls.Add(this.tAdmin);
            this.Name = "fAdmin";
            this.Text = "fAdmin";
            this.tAdmin.ResumeLayout(false);
            this.tData.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tAccount.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tAdmin;
        private System.Windows.Forms.TabPage tData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tAccount;
        private System.Windows.Forms.FlowLayoutPanel fPanelAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLayers;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSreachAccount;
        private System.Windows.Forms.TextBox textBox2;
    }
}