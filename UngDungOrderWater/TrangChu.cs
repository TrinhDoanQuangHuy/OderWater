using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UngDungOrderWater.Properties;


namespace UngDungOrderWater
{

    
    public partial class TrangChu : Form
    {

        private string connectionString = "Data Source=ABOY;Initial Catalog=OrderNuoc;Integrated Security=True";
        private void LoadDataIntoDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DrinkName, Quantity, Price, (Price * Quantity) AS TotalPrice, RealTime FROM Drinks";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dgvOrderWater.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }


        // Khai báo các UserControl
        private BrandPhucLong brandPhucLong;
        private BrandHighLand brandHighLand;
        private BrandStarBuck brandStarBuck;
        private BrandTheCoffeeHouse brandTheCoffeeHouse;
        //private Home home;
        public event Action<Product> OnProductSelected;
        private List<Product> cartProducts = new List<Product>();

        public TrangChu()
        {
            InitializeComponent();

            // Khởi tạo các UserControl
            brandPhucLong = new BrandPhucLong();
            brandHighLand = new BrandHighLand();
            brandStarBuck = new BrandStarBuck();
            brandTheCoffeeHouse = new BrandTheCoffeeHouse();
            //home = new Home();

            // Đặt Dock cho các UserControl
            brandPhucLong.Dock = DockStyle.Fill;
            brandHighLand.Dock = DockStyle.Fill;
            brandStarBuck.Dock = DockStyle.Fill;
            brandTheCoffeeHouse.Dock = DockStyle.Fill;
            //home.Dock = DockStyle.Fill;

            // Đăng ký sự kiện SelectedIndexChanged
            cmbChonNuoc.SelectedIndexChanged += cmbChonNuoc_SelectedIndexChanged;

            // Thiết lập ComboBox
            cmbChonNuoc.Items.Add("Phúc Long");
            cmbChonNuoc.Items.Add("Highland");
            cmbChonNuoc.Items.Add("Starbucks");
            cmbChonNuoc.Items.Add("CoffeeHouse");

            // Mặc định hiển thị Phúc Long
            //cmbChonNuoc.SelectedIndex = 0; // Đặt lại giá trị mặc định cho ComboBox
            cmbChonNuoc_SelectedIndexChanged(this, EventArgs.Empty); // Gọi sự kiện để hiển thị
            brandStarBuck.OnProductSelected += AddProductToCart;
            brandPhucLong.OnProductSelected += AddProductToCart;
            brandHighLand.OnProductSelected += AddProductToCart;
            brandTheCoffeeHouse.OnProductSelected += AddProductToCart;
 
            //// Khởi tạo DataGridView và thiết lập các thuộc tính
            //dgvOrderWater = new DataGridView();
            //dgvOrderWater.Dock = DockStyle.Fill; // Hoặc dùng các thuộc tính khác như Location, Size
            //dgvOrderWater.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Đặt cho các cột tự điều chỉnh kích thước

            //// Thêm DataGridView vào form
            //this.Controls.Add(dgvOrderWater);

            // Gọi hàm load dữ liệu vào DataGridView
            //LoadDataIntoDataGridView();
            //this.Controls.SetChildIndex(dgvOrderWater, 0);

        }

    
        private void TrangChu_Load(object sender, EventArgs e)

        {

            // TODO: This line of code loads data into the 'orderNuocDataSet.Drinks' table. You can move, or remove it, as needed.
            //this.drinksTableAdapter.Fill(this.orderNuocDataSet.Drinks);

            /*// Thêm các mục vào ComboBox
            cmbChonNuoc.Items.Add("Phúc Long");
            cmbChonNuoc.Items.Add("Highland");
            cmbChonNuoc.Items.Add("Starbucks");
            cmbChonNuoc.Items.Add("CoffeeHouse");*/

            // Đặt giá trị mặc định hiển thị khi load form
            panelContainer.Controls.Clear();
            //panelContainer.Controls.Add(home);
            //cmbChonNuoc.SelectedIndex = 0; // Đặt giá trị mặc định cho ComboBox
        }

        // Sự kiện khi người dùng chọn thương hiệu trong ComboBox
        private void cmbChonNuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChonNuoc.SelectedItem != null)
            {
                panelContainer.Controls.Clear(); // Xóa tất cả các control hiện tại trong panelContainer

                switch (cmbChonNuoc.SelectedItem.ToString())
                {
                    case "Phúc Long":
                        panelContainer.Controls.Add(brandPhucLong);
                        break;
                    case "Highland":
                        panelContainer.Controls.Add(brandHighLand);
                        break;
                    case "Starbucks":
                        panelContainer.Controls.Add(brandStarBuck);
                        break;
                    case "CoffeeHouse":
                        panelContainer.Controls.Add(brandTheCoffeeHouse);
                        break;
                    default:
                        MessageBox.Show("Chọn một thương hiệu hợp lệ.");
                        break;
                }
            }

        }

        // Sự kiện khi bấm nút Trang Chủ
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // Xóa tất cả các control hiện tại trong panelContainer

            // Gọi hàm load dữ liệu vào DataGridView
            LoadDataIntoDataGridView();

            // Thêm DataGridView vào panelContainer khi nhấn nút Trang Chủ
            if (!panelContainer.Controls.Contains(dgvOrderWater))
            {
                panelContainer.Controls.Add(dgvOrderWater);
            }

        }


        private void btnDanhGia_Click_1(object sender, EventArgs e)
        {
            FormDanhGiaCuaKhachHang danhGia = new FormDanhGiaCuaKhachHang();
            danhGia.Show();
        }

        private void btnHoTro_Click_1(object sender, EventArgs e)
        {

            FormHoTro hoTro = new FormHoTro(this); // 'this' là TrangChu
            hoTro.Show();
            /*FormHoTro hoTro = new FormHoTro();
            hoTro.Show();*/
        }


        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
           FormThanhToan thanhToan = new FormThanhToan(cartProducts);

            // Thu thập số lượng sản phẩm từ các UserControl hiện tại
            /*if (panelContainer.Controls.Contains(brandPhucLong))
            {
                foreach (var product in brandPhucLong.GetSelectedProducts())
                {
                    thanhToan.AddProductToGrid(product);
                }
            }
            else if (panelContainer.Controls.Contains(brandHighLand))
            {
                foreach (var product in brandHighLand.GetSelectedProducts())
                {
                    thanhToan.AddProductToGrid(product);
                }
            }
            else if (panelContainer.Controls.Contains(brandStarBuck))
            {
                foreach (var product in brandStarBuck.GetSelectedProducts())
                {
                    thanhToan.AddProductToGrid(product);
                }
            }
            else if (panelContainer.Controls.Contains(brandTheCoffeeHouse))
            {
                foreach (var product in brandTheCoffeeHouse.GetSelectedProducts())
                {
                    thanhToan.AddProductToGrid(product);
                }
            }*/

            thanhToan.Show();

        }


        private void AddProductToCart(Product product)
        {
            var existingProduct = cartProducts.FirstOrDefault(p => p.Name == product.Name && p.Name == product.Name);

            if (existingProduct != null)
            {
                existingProduct.Quantity += product.Quantity; // Tăng số lượng nếu sản phẩm đã có trong giỏ hàng
            }
            else
            {
                cartProducts.Add(product); // Thêm sản phẩm mới vào giỏ hàng
            }

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbChonNuoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbChonNuoc.SelectedItem != null)
            {
                panelContainer.Controls.Clear(); // Xóa tất cả các control hiện tại trong panelContainer

                // Hiển thị UserControl theo thương hiệu được chọn mà không làm mất các sản phẩm đã thêm
                switch (cmbChonNuoc.SelectedItem.ToString())
                {
                    case "Phúc Long":
                        panelContainer.Controls.Add(brandPhucLong);
                        break;
                    case "Highland":
                        panelContainer.Controls.Add(brandHighLand);
                        break;
                    case "Starbucks":
                        panelContainer.Controls.Add(brandStarBuck);
                        break;
                    case "CoffeeHouse":
                        panelContainer.Controls.Add(brandTheCoffeeHouse);
                        break;
                    default:
                        MessageBox.Show("Chọn một thương hiệu hợp lệ.");
                        break;
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            // Lấy danh sách lịch sử mua hàng (LichSuDonHang)
            List<LichSuDonHang> lichSuMuaHang = GetPurchaseHistory();

            // Tạo và hiển thị báo cáo
            Report report = new Report(lichSuMuaHang);
            report.Show();
        }

        // Phương thức giả định để lấy lịch sử mua hàng
        private List<LichSuDonHang> GetPurchaseHistory()
        {
            List<LichSuDonHang> lichSu = new List<LichSuDonHang>();

            // Ví dụ: Lấy dữ liệu từ DataGridView hoặc từ cơ sở dữ liệu
            foreach (DataGridViewRow row in dgvOrderWater.Rows)
            {
                
                {
                    lichSu.Add(new LichSuDonHang
                    {
                        // Giả định bạn có các thuộc tính tương ứng
                        DrinkName = row.Cells["colTenSanPham"].Value.ToString(),
                        Quantity = Convert.ToInt32(row.Cells["colSoLuong"].Value),
                        Price = Convert.ToDecimal(row.Cells["colGia"].Value),
                        TotalPrice = Convert.ToDecimal(row.Cells["colTongTien"].Value),
                        NgayMua = Convert.ToDateTime(row.Cells["colThoiGianMuaHang"].Value)
                    });
                }
            }

            return lichSu;
        }

        private void btnLichSuMuaHang_Click(object sender, EventArgs e)
        {
            FormLichSuMuaHang lichSuMuaHang = new FormLichSuMuaHang();
            lichSuMuaHang.Show();
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvOrderWater_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim().ToLower();

            panelContainer.Controls.Clear();

            if (timKiem.Contains("phúc long"))
            {
                panelContainer.Controls.Add(brandPhucLong);
            }
            else if (timKiem.Contains("highland"))
            {
                panelContainer.Controls.Add(brandHighLand);
            }
            else if (timKiem.Contains("starbucks"))
            {
                panelContainer.Controls.Add(brandStarBuck);
            }
            else if (timKiem.Contains("coffeehouse") || timKiem.Contains("coffee house"))
            {
                panelContainer.Controls.Add(brandTheCoffeeHouse);
            }
            else if (brandPhucLong.HasProduct(timKiem))
            {
                panelContainer.Controls.Add(brandPhucLong);
            }
            else if (brandHighLand.HasProduct(timKiem))
            {
                panelContainer.Controls.Add(brandHighLand);
            }
            else if (brandStarBuck.HasProduct(timKiem))
            {
                panelContainer.Controls.Add(brandStarBuck);
            }
            else if (brandTheCoffeeHouse.HasProduct(timKiem))
            {
                panelContainer.Controls.Add(brandTheCoffeeHouse);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //panelContainer.Controls.Add(home);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
