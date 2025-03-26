using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UngDungOrderWater
{
    public partial class BrandPhucLong : UserControl
    {
        public BrandPhucLong()
        {
            InitializeComponent();
        }

        public event Action<Product> OnProductSelected;

        public List<Product> GetSelectedProducts()
        {
            List<Product> selectedProducts = new List<Product>();

            if (int.TryParse(nudCoffeeSuaDa.Text, out int CoffeeSuaDaQuantity) && CoffeeSuaDaQuantity > 0)
            {
                selectedProducts.Add(new Product
                {
                    Name = "Coffee Sữa Đá",
                    Quantity = CoffeeSuaDaQuantity,
                    Price = 40000,
                });
            }

            if (int.TryParse(nudTraThanhLongDo.Text, out int TraThanhLongDoQuantity) && TraThanhLongDoQuantity > 0)
            {
                selectedProducts.Add(new Product
                {
                    Name = "Trà Thanh Long Đỏ",
                    Quantity = TraThanhLongDoQuantity,
                    Price = 45000,
                });
            }

            if (int.TryParse(nudTraDaoCamSa.Text, out int TraDaoCamSaQuantity) && TraDaoCamSaQuantity > 0)
            {
                selectedProducts.Add(new Product
                {
                    Name = "Trà Đào Cam Sả",
                    Quantity = TraDaoCamSaQuantity,
                    Price = 45000,
                });
            }

            return selectedProducts;
        }

        private void btnMuaNuocPhucLong1_Click(object sender, EventArgs e)
        {
            int soLuong = (int)nudTraDaoCamSa.Value;

            if (soLuong <= 0)
            {
                MessageBox.Show("Quý khách hãy chọn số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedProduct = new Product
            {
                Name = "Trà Đào Cam Sả",
                Quantity = soLuong,
                Price = 45000
            };

            OnProductSelected?.Invoke(selectedProduct);
        }

        private void btnMuaNuocPhucLong2_Click(object sender, EventArgs e)
        {
            int soLuong = (int)nudTraThanhLongDo.Value;

            if (soLuong <= 0)
            {
                MessageBox.Show("Quý khách hãy chọn số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedProduct = new Product
            {
                Name = "Trà Thanh Long Đỏ",
                Quantity = soLuong,
                Price = 45000
            };

            OnProductSelected?.Invoke(selectedProduct);
        }

        private void btnMuaNuocPhucLong3_Click(object sender, EventArgs e)
        {
            int soLuong = (int)nudCoffeeSuaDa.Value;

            if (soLuong <= 0)
            {
                MessageBox.Show("Quý khách hãy chọn số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedProduct = new Product
            {
                Name = "Coffee Sữa Đá",
                Quantity = soLuong,
                Price = 40000
            };

            OnProductSelected?.Invoke(selectedProduct);
        }

        public bool HasProduct(string tenSanPham)
        {
            return tenSanPham.Equals("Trà Đào Cam Sả", StringComparison.OrdinalIgnoreCase) ||
                   tenSanPham.Equals("Trà Thanh Long Đỏ", StringComparison.OrdinalIgnoreCase) ||
                   tenSanPham.Equals("Coffee Sữa Đá", StringComparison.OrdinalIgnoreCase);
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

        public void AddProductToCart(Product product)
        {
            // Logic thêm sản phẩm vào giỏ hàng ở đây
            // Có thể gọi đến lớp quản lý giỏ hàng ở đây để thêm sản phẩm vào
            Console.WriteLine($"Đã thêm sản phẩm {product.Name} x{product.Quantity} vào giỏ hàng với giá {product.Price * product.Quantity} VNĐ.");
        }

        private void BrandPhucLong_Load(object sender, EventArgs e)
        {

        }

        
    }
}
