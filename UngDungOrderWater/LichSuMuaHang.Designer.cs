namespace UngDungOrderWater
{
    partial class FormLichSuMuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLichSuMuaHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvLichSuMuaHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTenDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuMuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // dgvLichSuMuaHang
            // 
            this.dgvLichSuMuaHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLichSuMuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuMuaHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTenDonHang,
            this.dgvSoLuong,
            this.dgvGiaTien,
            this.dgvTongTien,
            this.dgvThoiGian});
            this.dgvLichSuMuaHang.Location = new System.Drawing.Point(236, 173);
            this.dgvLichSuMuaHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLichSuMuaHang.Name = "dgvLichSuMuaHang";
            this.dgvLichSuMuaHang.RowHeadersWidth = 62;
            this.dgvLichSuMuaHang.Size = new System.Drawing.Size(1227, 554);
            this.dgvLichSuMuaHang.TabIndex = 28;
            this.dgvLichSuMuaHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichSuMuaHang_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 46);
            this.label1.TabIndex = 29;
            this.label1.Text = "Danh Sách Lịch Sử Mua Hàng";
            // 
            // dgvTenDonHang
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTenDonHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTenDonHang.HeaderText = "Tên Đơn Hàng";
            this.dgvTenDonHang.MinimumWidth = 8;
            this.dgvTenDonHang.Name = "dgvTenDonHang";
            this.dgvTenDonHang.Width = 150;
            // 
            // dgvSoLuong
            // 
            this.dgvSoLuong.HeaderText = "Số Lượng";
            this.dgvSoLuong.MinimumWidth = 8;
            this.dgvSoLuong.Name = "dgvSoLuong";
            this.dgvSoLuong.Width = 150;
            // 
            // dgvGiaTien
            // 
            this.dgvGiaTien.HeaderText = "Giá Tiền";
            this.dgvGiaTien.MinimumWidth = 8;
            this.dgvGiaTien.Name = "dgvGiaTien";
            this.dgvGiaTien.Width = 150;
            // 
            // dgvTongTien
            // 
            this.dgvTongTien.HeaderText = "Tổng Tiền";
            this.dgvTongTien.MinimumWidth = 8;
            this.dgvTongTien.Name = "dgvTongTien";
            this.dgvTongTien.Width = 150;
            // 
            // dgvThoiGian
            // 
            this.dgvThoiGian.HeaderText = "Thời Gian Mua Hàng";
            this.dgvThoiGian.MinimumWidth = 8;
            this.dgvThoiGian.Name = "dgvThoiGian";
            this.dgvThoiGian.Width = 300;
            // 
            // FormLichSuMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1476, 814);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLichSuMuaHang);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormLichSuMuaHang";
            this.Text = "LichSuMuaHang";
            this.Load += new System.EventHandler(this.FormLichSuMuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuMuaHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvLichSuMuaHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvThoiGian;
    }
}