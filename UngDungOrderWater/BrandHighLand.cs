using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace UngDungOrderWater
{
    public partial class BrandHighLand : UserControl
    {
        private DataGridView dgvOrderWater;
        private string connectionString = "Data Source=ABOY;Initial Catalog=OrderNuoc;Integrated Security=True";
        // Khai báo biến cho các thương hiệu
        private BrandPhucLong brandPhucLong;
        private BrandStarBuck brandStarBuck;
        private Panel panelContainer;

        public BrandHighLand()
        {
            InitializeComponent();
            // Khởi tạo và cấu hình DataGridView nhưng đặt Visible = false
            dgvOrderWater = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                Visible = false // Ẩn DataGridView
            };

            // Thêm DataGridView vào UserControl
            this.Controls.Add(dgvOrderWater);
        }

        public event Action<Product> OnProductSelected;

        public List<Product> GetSelectedProducts()
        {
            List<Product> selectedProducts = new List<Product>();

            if (int.TryParse(nudCoffeeDen.Text, out int CoffeeDenQuantity) && CoffeeDenQuantity > 0)
            {
                selectedProducts.Add(new Product
                {
                    Name = "Coffee Đen",
                    Quantity = CoffeeDenQuantity,
                    Price = 40000,
                });
            }

            if (int.TryParse(nudMatchaCream.Text, out int MatchaCreamQuantity) && MatchaCreamQuantity > 0)
            {
                selectedProducts.Add(new Product
                {
                    Name = "Matcha Cream",
                    Quantity = MatchaCreamQuantity,
                    Price = 45000,
                });
            }

            if (int.TryParse(nudTraSen.Text, out int TraSenQuantity) && TraSenQuantity > 0)
            {
                selectedProducts.Add(new Product
                {
                    Name = "Trà Sen",
                    Quantity = TraSenQuantity,
                    Price = 45000,
                });
            }

            return selectedProducts;
        }

       
        public bool HasProduct(string tenSanPham)
        {
            return tenSanPham.Equals("Trà Sen", StringComparison.OrdinalIgnoreCase) ||
                   tenSanPham.Equals("Coffee Đen", StringComparison.OrdinalIgnoreCase) ||
                   tenSanPham.Equals("Matcha Cream", StringComparison.OrdinalIgnoreCase);
        }

        private void btnCapnhatgiohang_Click(object sender, EventArgs e)
        {

            var selectedProducts = GetSelectedProducts();
            if (selectedProducts.Count == 0)
            {
                MessageBox.Show("Quý khách hãy chọn nước trước khi cập nhật giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var product in selectedProducts)
            {
                OnProductSelected?.Invoke(product); // Gọi sự kiện OnProductSelected để gửi sản phẩm về FormThanhToan
            }

            MessageBox.Show("Giỏ hàng đã được cập nhật!", "Thông báo", MessageBoxButtons.OK);
        }

        private void UpdateDataGridView()
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

                    //// Gán dữ liệu vào DataGridView
                    //dgvOrderWater.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private void SaveProductToDatabase(Product product)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Drinks (DrinkName, Quantity, Price, RealTime) VALUES (@DrinkName, @Quantity, @Price, @RealTime)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DrinkName", product.Name);
                        command.Parameters.AddWithValue("@Quantity", product.Quantity);
                        command.Parameters.AddWithValue("@Price", product.Price);
                        command.Parameters.AddWithValue("@RealTime", DateTime.Now);

                        command.ExecuteNonQuery(); // Thực thi truy vấn
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lưu vào cơ sở dữ liệu: " + ex.Message);
            }
        }

        public void AddProductToCart(Product product)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Drinks (DrinkName, Quantity, Price, TotalPrice, RealTime) VALUES (@Name, @Quantity, @Price, @TotalPrice, @RealTime)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", product.Name);
                        command.Parameters.AddWithValue("@Quantity", product.Quantity);
                        command.Parameters.AddWithValue("@Price", product.Price);
                        command.Parameters.AddWithValue("@TotalPrice", product.Quantity * product.Price); // Tính TotalPrice
                        command.Parameters.AddWithValue("@RealTime", DateTime.Now);

                        command.ExecuteNonQuery();
                    }
                }

                Console.WriteLine($"Đã thêm sản phẩm {product.Name} x{product.Quantity} vào giỏ hàng với giá {product.Price * product.Quantity} VNĐ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm sản phẩm vào giỏ hàng: " + ex.Message);
            }
        }


        private void BrandHighLand_Load(object sender, EventArgs e)
        {

        }
    }
}
