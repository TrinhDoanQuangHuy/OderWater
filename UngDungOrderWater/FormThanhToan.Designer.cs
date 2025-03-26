namespace UngDungOrderWater
{
    partial class FormThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThanhToan));
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.dgvOrderWater = new System.Windows.Forms.DataGridView();
            this.txbTongTienThanhToan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txbGhiChu = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblCamOn = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMuaThem = new System.Windows.Forms.Button();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpThanhToan.BackgroundImage")));
            this.grpThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grpThanhToan.Controls.Add(this.dgvOrderWater);
            this.grpThanhToan.Controls.Add(this.txbTongTienThanhToan);
            this.grpThanhToan.Controls.Add(this.label2);
            this.grpThanhToan.Controls.Add(this.Label1);
            this.grpThanhToan.Controls.Add(this.txbGhiChu);
            this.grpThanhToan.Controls.Add(this.pictureBox1);
            this.grpThanhToan.Controls.Add(this.Panel1);
            this.grpThanhToan.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThanhToan.Location = new System.Drawing.Point(-2, 5);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(1132, 532);
            this.grpThanhToan.TabIndex = 5;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "Giỏ Hàng Của Bạn";
            // 
            // dgvOrderWater
            // 
            this.dgvOrderWater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderWater.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenSanPham,
            this.colSoLuong,
            this.colGia,
            this.colTongTien,
            this.colThoiGianMua});
            this.dgvOrderWater.Location = new System.Drawing.Point(231, 83);
            this.dgvOrderWater.Name = "dgvOrderWater";
            this.dgvOrderWater.RowHeadersWidth = 62;
            this.dgvOrderWater.Size = new System.Drawing.Size(880, 244);
            this.dgvOrderWater.TabIndex = 31;
            this.dgvOrderWater.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderWater_CellContentClick);
            // 
            // txbTongTienThanhToan
            // 
            this.txbTongTienThanhToan.Location = new System.Drawing.Point(618, 451);
            this.txbTongTienThanhToan.Multiline = true;
            this.txbTongTienThanhToan.Name = "txbTongTienThanhToan";
            this.txbTongTienThanhToan.Size = new System.Drawing.Size(396, 57);
            this.txbTongTienThanhToan.TabIndex = 30;
            this.txbTongTienThanhToan.TextChanged += new System.EventHandler(this.txbTongTienThanhToan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tổng Tiền Thanh Toán";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(55, 416);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(189, 25);
            this.Label1.TabIndex = 28;
            this.Label1.Text = "Ghi Chú Đơn Hàng";
            // 
            // txbGhiChu
            // 
            this.txbGhiChu.Location = new System.Drawing.Point(60, 451);
            this.txbGhiChu.Multiline = true;
            this.txbGhiChu.Name = "txbGhiChu";
            this.txbGhiChu.Size = new System.Drawing.Size(396, 57);
            this.txbGhiChu.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.lblCamOn);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(3, 29);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1126, 47);
            this.Panel1.TabIndex = 0;
            // 
            // lblCamOn
            // 
            this.lblCamOn.AutoSize = true;
            this.lblCamOn.Location = new System.Drawing.Point(18, 17);
            this.lblCamOn.Name = "lblCamOn";
            this.lblCamOn.Size = new System.Drawing.Size(377, 25);
            this.lblCamOn.TabIndex = 0;
            this.lblCamOn.Text = "Cảm Ơn Quý Khách Đã Mua Hàng ^-^";
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTroVe.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTroVe.Location = new System.Drawing.Point(909, 543);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(170, 55);
            this.btnTroVe.TabIndex = 7;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Cyan;
            this.btnThanhToan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.Location = new System.Drawing.Point(686, 543);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(170, 55);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Salmon;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(483, 543);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(152, 55);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnMuaThem
            // 
            this.btnMuaThem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMuaThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMuaThem.Location = new System.Drawing.Point(305, 543);
            this.btnMuaThem.Name = "btnMuaThem";
            this.btnMuaThem.Size = new System.Drawing.Size(152, 53);
            this.btnMuaThem.TabIndex = 9;
            this.btnMuaThem.Text = "Mua Thêm";
            this.btnMuaThem.UseVisualStyleBackColor = false;
            this.btnMuaThem.Click += new System.EventHandler(this.btnMuaThem_Click);
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.HeaderText = "Tên Sản Phẩm";
            this.colTenSanPham.MinimumWidth = 8;
            this.colTenSanPham.Name = "colTenSanPham";
            this.colTenSanPham.Width = 250;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 8;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá";
            this.colGia.MinimumWidth = 8;
            this.colGia.Name = "colGia";
            this.colGia.Width = 150;
            // 
            // colTongTien
            // 
            this.colTongTien.HeaderText = "Tổng Tiền";
            this.colTongTien.MinimumWidth = 8;
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Width = 150;
            // 
            // colThoiGianMua
            // 
            this.colThoiGianMua.HeaderText = "Thời Gian Mua";
            this.colThoiGianMua.MinimumWidth = 8;
            this.colThoiGianMua.Name = "colThoiGianMua";
            this.colThoiGianMua.Width = 250;
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 614);
            this.Controls.Add(this.btnMuaThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grpThanhToan);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnThanhToan);
            this.Name = "FormThanhToan";
            this.Text = "FormThanhToan";
            this.Load += new System.EventHandler(this.FormThanhToan_Load);
            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpThanhToan;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txbGhiChu;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lblCamOn;
        internal System.Windows.Forms.Button btnTroVe;
        internal System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMuaThem;
        internal System.Windows.Forms.TextBox txbTongTienThanhToan;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvOrderWater;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianMua;
    }
}