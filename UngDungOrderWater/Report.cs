using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UngDungOrderWater
{
    public partial class Report : Form
    {
        private List<LichSuDonHang> lichSuMuaHang;

        public Report(List<LichSuDonHang> lichSuMuaHang)
        {
            InitializeComponent();
            this.lichSuMuaHang = lichSuMuaHang;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // Gọi hàm để hiển thị dữ liệu khi form được tải
            LoadDataFromPurchaseHistory();
        }

        private void LoadDataFromPurchaseHistory()
        {
            // Xóa tất cả các nguồn dữ liệu cũ trước khi thêm mới
            reportViewer1.LocalReport.DataSources.Clear();

            // Thêm dữ liệu vào ReportDataSource
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", lichSuMuaHang));

            // Cập nhật ReportViewer
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // Đặt tham số thời gian (nếu cần)
            string thoiGianMuaHang = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("ThoiGianMuaHang", thoiGianMuaHang, true);
            reportViewer1.LocalReport.SetParameters(parameters);
        }
    }
}
