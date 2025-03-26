using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungOrderWater
{
    public partial class FormLichSuMuaHang : Form
    {
        public FormLichSuMuaHang()
        {
            InitializeComponent();
        }

        private void dgvLichSuMuaHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormLichSuMuaHang_Load(object sender, EventArgs e)
        {
            // Đọc dữ liệu từ file CSV và hiển thị trên DataGridView
            string filePath = "lichsu_mua_hang.csv";
            if (System.IO.File.Exists(filePath))
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);

                // Bỏ qua dòng tiêu đề
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');
                    int rowIndex = dgvLichSuMuaHang.Rows.Add();
                    dgvLichSuMuaHang.Rows[rowIndex].Cells[0].Value = data[0]; // Tên sản phẩm
                    dgvLichSuMuaHang.Rows[rowIndex].Cells[1].Value = data[1]; // Số lượng
                    dgvLichSuMuaHang.Rows[rowIndex].Cells[2].Value = data[2]; // Giá
                    dgvLichSuMuaHang.Rows[rowIndex].Cells[3].Value = data[3]; // Tổng tiền
                    dgvLichSuMuaHang.Rows[rowIndex].Cells[4].Value = data[4]; // Ngày mua
                }
            }
            else
            {
                MessageBox.Show("Chưa có lịch sử mua hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
