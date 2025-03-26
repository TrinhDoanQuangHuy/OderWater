using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace UngDungOrderWater
{
    public partial class FormThanhToan : Form
    {
        private string connectionString = "Data Source=BOMSU;Initial Catalog=OrderNuoc;Integrated Security=True";

        // Khai báo danh sách để lưu trữ sản phẩm
        private List<Product> productList = new List<Product>();
        private List<LichSuDonHang> lichSuMuaHang = new List<LichSuDonHang>();
        private Timer timer;

        public FormThanhToan(List<Product> cartProducts)
        {
            InitializeComponent();
            // Lưu giỏ hàng nhận từ TrangChu
            this.productList = cartProducts;
            timer = new Timer();
            timer.Interval = 1000; // 1000 milliseconds = 1 second
            timer.Tick += Timer_Tick; // Đăng ký sự kiện Tick
            timer.Start(); // Bắt đầu Timer
            // Hiển thị giỏ hàng trên DataGridView hoặc các điều khiển khác
            if (productList.Any())
            {
                UpdateDataGridView();
            }
            txbTongTienThanhToan.ReadOnly = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Cập nhật thời gian thực cho từng sản phẩm trong danh sách
            foreach (var product in productList)
            {
                product.RealTime = DateTime.Now; // Cập nhật thời gian thực
            }

            // Cập nhật lại DataGridView để hiển thị thời gian mới
            UpdateDataGridView();
        }


        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            // Tạo các instance của các Brand và lắng nghe sự kiện OnProductSelected
            BrandStarBuck brandStarBuck = new BrandStarBuck();
            BrandHighLand brandHighLand = new BrandHighLand();
            BrandPhucLong brandPhucLong = new BrandPhucLong();
            BrandTheCoffeeHouse brandTheCoffeeHouse = new BrandTheCoffeeHouse();

            // Lắng nghe sự kiện chọn sản phẩm từ các thương hiệu khác nhau
            /*brandStarBuck.OnProductSelected += AddProductToGrid;
            brandHighLand.OnProductSelected += AddProductToGrid;
            brandPhucLong.OnProductSelected += AddProductToGrid;
            brandTheCoffeeHouse.OnProductSelected += AddProductToGrid;*/
            
        }

        public void AddProductToGrid(Product product)
        {
            var existingProduct = productList.Find(p => p.Name == product.Name);
            if (existingProduct != null)
            {
                // Cập nhật số lượng nếu sản phẩm đã tồn tại
                existingProduct.Quantity += product.Quantity; // Cộng thêm số lượng
            }
            else
            {
                productList.Add(product);
            }

            UpdateDataGridView(); // Cập nhật DataGridView
        }

        public void CapNhatGioHang(List<Product> selectedProducts)
        {
            // Tạo DataTable để hiển thị dữ liệu trong DataGridView
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tên Sản Phẩm", typeof(string));
            dataTable.Columns.Add("Số Lượng", typeof(int));
            dataTable.Columns.Add("Giá", typeof(decimal));
            dataTable.Columns.Add("Tổng Tiền", typeof(decimal));
            dataTable.Columns.Add("Thời Gian Mua Hàng", typeof(DateTime)); // Thêm cột thời gian thực

            foreach (var product in selectedProducts)
            {
                DataRow row = dataTable.NewRow();
                row["Tên Sản Phẩm"] = product.Name;
                row["Số Lượng"] = product.Quantity;
                row["Giá"] = product.Price;
                row["Tổng Tiền"] = product.TotalPrice; // Sử dụng thuộc tính TotalPrice
                row["Thời Gian Mua Hàng"] = product.RealTime; // Thêm thời gian thực vào DataTable
                dataTable.Rows.Add(row);
            }

            dgvOrderWater.DataSource = dataTable; // Gán DataTable vào DataGridView
        }

        private void UpdateDataGridView()
        {
            dgvOrderWater.Rows.Clear(); // Xóa dữ liệu cũ trong DataGridView

            foreach (var product in productList)
            {
                // Thêm một dòng mới vào DataGridView với các cột đã tạo sẵn
                dgvOrderWater.Rows.Add(
                    product.Name,                   // Tên Sản Phẩm
                    product.Quantity,               // Số Lượng
                    product.Price,                  // Giá
                    product.TotalPrice, // Tổng Tiền
                    product.RealTime            // Thời Gian Mua Hàng
                );
            }
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            decimal totalPrice = productList.Sum(p => p.Price * p.Quantity);
            txbTongTienThanhToan.Text = totalPrice.ToString(); // Hiển thị định dạng tiền tệ
        }


        private void btnTroVe_Click(object sender, EventArgs e)
        {
            // Hiển thị MessageBox xác nhận trước khi thoát
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát và xóa giỏ hàng không?",
                                                   "Xác nhận thoát",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            // Nếu người dùng chọn "Yes", thực hiện các thao tác
            if (result == DialogResult.Yes)
            {
                // Xóa danh sách sản phẩm trong giỏ hàng
                productList.Clear();
                dgvOrderWater.DataSource = null; // Xóa dữ liệu trong DataGridView

                // Ẩn form hiện tại
                this.Hide();

                // Kiểm tra và hiện form TrangChu
                foreach (Form form in Application.OpenForms)
                {
                    if (form is TrangChu)
                    {
                        form.Show(); // Hiện form TrangChu nếu nó đã mở
                        return;
                    }
                }

                // Nếu TrangChu chưa mở thì khởi tạo và hiện nó
                TrangChu trangChu = new TrangChu();
                trangChu.ShowDialog(); // Hiện form TrangChu nếu nó chưa mở
            }
        }



        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                // Cập nhật số lượng sản phẩm trong giỏ hàng
                UpdateCartQuantities();

                if (productList.Count == 0)
                {
                    MessageBox.Show("Giỏ hàng trống. Vui lòng thêm sản phẩm trước khi thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo danh sách lịch sử đơn hàng từ danh sách sản phẩm hiện tại
                foreach (var prod in productList)
                {
                    LichSuDonHang donHang = new LichSuDonHang
                    {
                        DrinkName = prod.Name,
                        Quantity = prod.Quantity,
                        Price = prod.Price,
                        TotalPrice = prod.TotalPrice,
                        NgayMua = DateTime.Now
                    };
                    lichSuMuaHang.Add(donHang);
                }

                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở FormReport và truyền danh sách lichSuMuaHang
                Report reportForm = new Report(lichSuMuaHang);
                reportForm.ShowDialog();

                // Sau khi thanh toán, làm trống danh sách sản phẩm
                productList.Clear();
                dgvOrderWater.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi trong quá trình thanh toán: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCartQuantities()
        {
            foreach (DataGridViewRow row in dgvOrderWater.Rows)
            {
                // Kiểm tra nếu dòng không phải dòng tiêu đề
                if (row.Index >= 0)
                {
                    var productName = row.Cells[0].Value?.ToString();
                    var productQuantityText = row.Cells[1].Value?.ToString();

                    if (int.TryParse(productQuantityText, out int productQuantity) && productName != null)
                    {
                        var existingProduct = productList.FirstOrDefault(p => p.Name == productName);
                        if (existingProduct != null)
                        {
                            existingProduct.Quantity = productQuantity; // Cập nhật số lượng sản phẩm
                        }
                    }
                }
            }
        }



        private void SaveLichSuToFile()
        {
            string filePath = "lichsu_mua_hang.csv";

            // Kiểm tra xem file có tồn tại không, nếu không thì tạo mới với tiêu đề cột
            if (!System.IO.File.Exists(filePath))
            {
                string header = "Tên Sản Phẩm,Số Lượng,Giá,Tổng Tiền,Ngày Mua\n";
                System.IO.File.WriteAllText(filePath, header);
            }

            // Ghi thêm lịch sử mới vào file
            foreach (var donHang in lichSuMuaHang)
            {
                string line = $"{donHang.DrinkName},{donHang.Quantity},{donHang.Price},{donHang.TotalPrice},{donHang.NgayMua:dd/MM/yyyy HH:mm:ss}\n";
                System.IO.File.AppendAllText(filePath, line);
            }
        }

        private void btnMuaThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form form in Application.OpenForms)
            {
                if (form is TrangChu)
                {
                    form.Show();
                    return;
                }
            }
        }

        private void dgvOrderWater_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvOrderWater.CurrentRow != null && dgvOrderWater.CurrentRow.Index >= 0)
            {
                string productName = dgvOrderWater.CurrentRow.Cells[0].Value.ToString();

                // Hiển thị MessageBox xác nhận việc xóa
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa món '{productName}' không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                // Nếu người dùng chọn "Yes", tiến hành xóa sản phẩm khỏi danh sách và DataGridView
                if (result == DialogResult.Yes)
                {
                    var productToRemove = productList.FirstOrDefault(p => p.Name == productName);
                    if (productToRemove != null)
                    {
                        productList.Remove(productToRemove); // Xóa khỏi danh sách sản phẩm
                    }

                    // Xóa dòng khỏi DataGridView
                    dgvOrderWater.Rows.RemoveAt(dgvOrderWater.CurrentRow.Index);
                    // Cập nhật lại DataGridView sau khi xóa
                    UpdateDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một món để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void txbTongTienThanhToan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
