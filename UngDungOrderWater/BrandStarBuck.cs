using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UngDungOrderWater
{
    public partial class BrandStarBuck : UserControl
    {
        public BrandStarBuck()
        {
            InitializeComponent();
        }

        public event Action<Product> OnProductSelected;

        public List<Product> GetSelectedProducts()
        {
            List<Product> selectedProducts = new List<Product>();

            if (int.TryParse(nudFreezeCaCao.Value.ToString(), out int freezeCacaoQuantity) && freezeCacaoQuantity > 0)
            {
                selectedProducts.Add(new Product
                {
                    Name = "Freeze Cacao",
                    Quantity = freezeCacaoQuantity,
                    Price = 65000,
                });
            }

            if (int.TryParse(nudFrezzeCaramel.Value.ToString(), out int freezeCaramelQuantity) && freezeCaramelQuantity > 0)
            {
                selectedProducts.Add(new Product
                {
                    Name = "Freeze Caramel",
                    Quantity = freezeCaramelQuantity,
                    Price = 60000,
                });
            }

            if (int.TryParse(nudFreezeMatcha.Value.ToString(), out int freezeMatchaQuantity) && freezeMatchaQuantity > 0)
            {
                selectedProducts.Add(new Product
                {
                    Name = "Freeze Matcha",
                    Quantity = freezeMatchaQuantity,
                    Price = 65000,
                });
            }

            return selectedProducts;
        }

        private void PurchaseButton_Click(string productName, int quantity, decimal price)
        {
            if (quantity <= 0)
            {
                MessageBox.Show("Quý khách hãy chọn số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedProduct = new Product
            {
                Name = productName,
                Quantity = quantity,
                Price = price
            };

            OnProductSelected?.Invoke(selectedProduct);
        }

        private void btnMuaNuocStarBuck1_Click(object sender, EventArgs e)
        {
            PurchaseButton_Click("Freeze Cacao", (int)nudFreezeCaCao.Value, 65000);
        }

        private void btnMuaNuocStarBuck2_Click(object sender, EventArgs e)
        {
            PurchaseButton_Click("Freeze Caramel", (int)nudFrezzeCaramel.Value, 60000);
        }

        private void btnMuaNuocStarBuck3_Click(object sender, EventArgs e)
        {
            PurchaseButton_Click("Freeze Matcha", (int)nudFreezeMatcha.Value, 65000);
        }

        public bool HasProduct(string tenSanPham)
        {
            return tenSanPham.Equals("Freeze Cacao", StringComparison.OrdinalIgnoreCase) ||
                   tenSanPham.Equals("Freeze Caramel", StringComparison.OrdinalIgnoreCase) ||
                   tenSanPham.Equals("Freeze Matcha", StringComparison.OrdinalIgnoreCase);
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
            Console.WriteLine($"Đã thêm sản phẩm {product.Name} x{product.Quantity} vào giỏ hàng với giá {product.Price * product.Quantity} VNĐ.");
        }
    }
}
