namespace UngDungOrderWater
{
    partial class TrangChu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grpThongTinTrangChu = new System.Windows.Forms.GroupBox();
            this.btnLichSuMuaHang = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnDanhGia = new System.Windows.Forms.Button();
            this.cmbChonNuoc = new System.Windows.Forms.ComboBox();
            this.btnHoTro = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblGioHang = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.dgvOrderWater = new System.Windows.Forms.DataGridView();
            this.drinkNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderNuocDataSet = new UngDungOrderWater.OrderNuocDataSet();
            this.drinksTableAdapter = new UngDungOrderWater.OrderNuocDataSetTableAdapters.DrinksTableAdapter();
            this.brandPhucLong1 = new UngDungOrderWater.BrandPhucLong();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.FlowLayoutPanel1.SuspendLayout();
            this.grpThongTinTrangChu.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNuocDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 48);
            this.label2.TabIndex = 14;
            this.label2.Text = "Group: AnhSinhViên";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(694, 86);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(518, 35);
            this.txtTimKiem.TabIndex = 12;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Aqua;
            this.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Panel2.Controls.Add(this.Panel3);
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.pictureBox1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(324, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1330, 78);
            this.Panel2.TabIndex = 9;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Transparent;
            this.Panel3.BackgroundImage = global::UngDungOrderWater.Properties.Resources.cpht;
            this.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Panel3.Location = new System.Drawing.Point(4, 0);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(119, 78);
            this.Panel3.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox1.BackgroundImage = global::UngDungOrderWater.Properties.Resources.logo_RGB_02;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(753, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.BackColor = System.Drawing.Color.MistyRose;
            this.FlowLayoutPanel1.Controls.Add(this.grpThongTinTrangChu);
            this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(324, 749);
            this.FlowLayoutPanel1.TabIndex = 8;
            // 
            // grpThongTinTrangChu
            // 
            this.grpThongTinTrangChu.BackColor = System.Drawing.Color.White;
            this.grpThongTinTrangChu.BackgroundImage = global::UngDungOrderWater.Properties.Resources.mg1;
            this.grpThongTinTrangChu.Controls.Add(this.btnLichSuMuaHang);
            this.grpThongTinTrangChu.Controls.Add(this.btnTrangChu);
            this.grpThongTinTrangChu.Controls.Add(this.btnThanhToan);
            this.grpThongTinTrangChu.Controls.Add(this.btnDanhGia);
            this.grpThongTinTrangChu.Controls.Add(this.cmbChonNuoc);
            this.grpThongTinTrangChu.Controls.Add(this.btnHoTro);
            this.grpThongTinTrangChu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.grpThongTinTrangChu.Location = new System.Drawing.Point(4, 4);
            this.grpThongTinTrangChu.Margin = new System.Windows.Forms.Padding(4);
            this.grpThongTinTrangChu.Name = "grpThongTinTrangChu";
            this.grpThongTinTrangChu.Padding = new System.Windows.Forms.Padding(4);
            this.grpThongTinTrangChu.Size = new System.Drawing.Size(320, 865);
            this.grpThongTinTrangChu.TabIndex = 1;
            this.grpThongTinTrangChu.TabStop = false;
            this.grpThongTinTrangChu.Text = "Thông Tin Trang Chủ";
            // 
            // btnLichSuMuaHang
            // 
            this.btnLichSuMuaHang.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSuMuaHang.Location = new System.Drawing.Point(27, 295);
            this.btnLichSuMuaHang.Name = "btnLichSuMuaHang";
            this.btnLichSuMuaHang.Size = new System.Drawing.Size(260, 59);
            this.btnLichSuMuaHang.TabIndex = 7;
            this.btnLichSuMuaHang.Text = "Lịch Sử Mua Hàng";
            this.btnLichSuMuaHang.UseVisualStyleBackColor = true;
            this.btnLichSuMuaHang.Click += new System.EventHandler(this.btnLichSuMuaHang_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(27, 46);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(260, 66);
            this.btnTrangChu.TabIndex = 5;
            this.btnTrangChu.Text = "   Trang Chủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(27, 197);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(260, 66);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "   Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click_1);
            // 
            // btnDanhGia
            // 
            this.btnDanhGia.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDanhGia.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhGia.Image")));
            this.btnDanhGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhGia.Location = new System.Drawing.Point(27, 385);
            this.btnDanhGia.Margin = new System.Windows.Forms.Padding(4);
            this.btnDanhGia.Name = "btnDanhGia";
            this.btnDanhGia.Size = new System.Drawing.Size(260, 66);
            this.btnDanhGia.TabIndex = 3;
            this.btnDanhGia.Text = "   Đánh Giá";
            this.btnDanhGia.UseVisualStyleBackColor = true;
            this.btnDanhGia.Click += new System.EventHandler(this.btnDanhGia_Click_1);
            // 
            // cmbChonNuoc
            // 
            this.cmbChonNuoc.FormattingEnabled = true;
            this.cmbChonNuoc.Location = new System.Drawing.Point(27, 140);
            this.cmbChonNuoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChonNuoc.Name = "cmbChonNuoc";
            this.cmbChonNuoc.Size = new System.Drawing.Size(260, 37);
            this.cmbChonNuoc.TabIndex = 2;
            this.cmbChonNuoc.SelectedIndexChanged += new System.EventHandler(this.cmbChonNuoc_SelectedIndexChanged_1);
            // 
            // btnHoTro
            // 
            this.btnHoTro.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHoTro.Image = ((System.Drawing.Image)(resources.GetObject("btnHoTro.Image")));
            this.btnHoTro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoTro.Location = new System.Drawing.Point(27, 486);
            this.btnHoTro.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoTro.Name = "btnHoTro";
            this.btnHoTro.Size = new System.Drawing.Size(260, 66);
            this.btnHoTro.TabIndex = 0;
            this.btnHoTro.Text = "   Hỗ Trợ";
            this.btnHoTro.UseVisualStyleBackColor = true;
            this.btnHoTro.Click += new System.EventHandler(this.btnHoTro_Click_1);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimKiem.CausesValidation = false;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(1220, 86);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(166, 39);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblGioHang
            // 
            this.lblGioHang.AutoSize = true;
            this.lblGioHang.Font = new System.Drawing.Font("Tahoma", 19F);
            this.lblGioHang.Location = new System.Drawing.Point(331, 79);
            this.lblGioHang.Name = "lblGioHang";
            this.lblGioHang.Size = new System.Drawing.Size(490, 46);
            this.lblGioHang.TabIndex = 27;
            this.lblGioHang.Text = "Giỏ Hàng Hiện Tại Của Bạn!";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.dgvOrderWater);
            this.panelContainer.Location = new System.Drawing.Point(324, 128);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1307, 609);
            this.panelContainer.TabIndex = 16;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // dgvOrderWater
            // 
            this.dgvOrderWater.AutoGenerateColumns = false;
            this.dgvOrderWater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderWater.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drinkNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.realTimeDataGridViewTextBoxColumn});
            this.dgvOrderWater.DataSource = this.drinksBindingSource;
            this.dgvOrderWater.Location = new System.Drawing.Point(15, 16);
            this.dgvOrderWater.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrderWater.Name = "dgvOrderWater";
            this.dgvOrderWater.RowHeadersWidth = 62;
            this.dgvOrderWater.Size = new System.Drawing.Size(815, 399);
            this.dgvOrderWater.TabIndex = 26;
            this.dgvOrderWater.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderWater_CellContentClick);
            // 
            // drinkNameDataGridViewTextBoxColumn
            // 
            this.drinkNameDataGridViewTextBoxColumn.DataPropertyName = "DrinkName";
            this.drinkNameDataGridViewTextBoxColumn.HeaderText = "DrinkName";
            this.drinkNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.drinkNameDataGridViewTextBoxColumn.Name = "drinkNameDataGridViewTextBoxColumn";
            this.drinkNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // realTimeDataGridViewTextBoxColumn
            // 
            this.realTimeDataGridViewTextBoxColumn.DataPropertyName = "RealTime";
            this.realTimeDataGridViewTextBoxColumn.HeaderText = "RealTime";
            this.realTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.realTimeDataGridViewTextBoxColumn.Name = "realTimeDataGridViewTextBoxColumn";
            this.realTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // drinksBindingSource
            // 
            this.drinksBindingSource.DataMember = "Drinks";
            this.drinksBindingSource.DataSource = this.orderNuocDataSet;
            // 
            // orderNuocDataSet
            // 
            this.orderNuocDataSet.DataSetName = "OrderNuocDataSet";
            this.orderNuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drinksTableAdapter
            // 
            this.drinksTableAdapter.ClearBeforeFill = true;
            // 
            // brandPhucLong1
            // 
            this.brandPhucLong1.Location = new System.Drawing.Point(0, 0);
            this.brandPhucLong1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brandPhucLong1.Name = "brandPhucLong1";
            this.brandPhucLong1.Size = new System.Drawing.Size(1115, 824);
            this.brandPhucLong1.TabIndex = 0;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 749);
            this.Controls.Add(this.lblGioHang);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.FlowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrangChu";
            this.Text = "TrangChu";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.grpThongTinTrangChu.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNuocDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpThongTinTrangChu;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDanhGia;
        private System.Windows.Forms.ComboBox cmbChonNuoc;
        private System.Windows.Forms.Button btnHoTro;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        private UngDungOrderWater.BrandPhucLong brandPhucLong1;
        private System.Windows.Forms.Button btnLichSuMuaHang;
        private System.Windows.Forms.Label lblGioHang;
        private System.Windows.Forms.Panel panelContainer;
        private OrderNuocDataSet orderNuocDataSet;
        private System.Windows.Forms.BindingSource drinksBindingSource;
        private OrderNuocDataSetTableAdapters.DrinksTableAdapter drinksTableAdapter;
        private System.Windows.Forms.DataGridView dgvOrderWater;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinkNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realTimeDataGridViewTextBoxColumn;
    }
}
