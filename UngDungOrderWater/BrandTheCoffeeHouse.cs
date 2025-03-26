using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UngDungOrderWater
{
    public partial class BrandTheCoffeeHouse : UserControl
    {
        private const int CoffeeDenPrice = 40000;
        private const int FreezeCacaoPrice = 45000;
        private const int FreezeMangoPrice = 45000;

        public BrandTheCoffeeHouse()
        {
            InitializeComponent();
        }

        public event Action<Product> OnProductSelected;

        public List<Product> GetSelectedProducts()
        {
            List<Product> selectedProducts = new List<Product>();

            if (int.TryParse(nudCoffeeDen.Text, out int coffeeDenQuantity) && coffeeDenQuantity > 0)
            {
                selectedProducts.Add(new Product
                {
                    Name = "Coffee Đen",
                    Quantity = coffeeDenQuantity,
                    Price = CoffeeDenPrice,
                });
            }

            if (int.TryParse(nudFreezeCacao.Text, out int freezeCacaoQuantity) && freezeCacaoQuantity > 0)
            {
                selectedProducts.Add(new Product
                {
                    Name = "Freeze Cacao",
                    Quantity = freezeCacaoQuantity,
                    Price = FreezeCacaoPrice,
                });
            }

            if (int.TryParse(nudFreezeMango.Text, out int freezeMangoQuantity) && freezeMangoQuantity > 0)
            {
                selectedProducts.Add(new Product
                {
                    Name = "Freeze Mango",
                    Quantity = freezeMangoQuantity,
                    Price = FreezeMangoPrice,
                });
            }

            return selectedProducts;
        }

        private void PurchaseButton_Click(string productName, int quantity, int price)
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

        private void btnMuaNuocCoffeeHouse1_Click(object sender, EventArgs e)
        {
            PurchaseButton_Click("Coffee Đen", (int)nudCoffeeDen.Value, CoffeeDenPrice);
        }

        private void btnMuaNuocCoffeeHouse2_Click(object sender, EventArgs e)
        {
            PurchaseButton_Click("Freeze Mango", (int)nudFreezeMango.Value, FreezeMangoPrice);
        }

        private void btnMuaNuocCoffeeHouse3_Click(object sender, EventArgs e)
        {
            PurchaseButton_Click("Freeze Cacao", (int)nudFreezeCacao.Value, FreezeCacaoPrice);
        }

        public bool HasProduct(string tenSanPham)
        {
            return tenSanPham.Equals("Coffee Đen", StringComparison.OrdinalIgnoreCase) ||
                   tenSanPham.Equals("Freeze Mango", StringComparison.OrdinalIgnoreCase) ||
                   tenSanPham.Equals("Freeze Cacao", StringComparison.OrdinalIgnoreCase);
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

        private void BrandTheCoffeeHouse_Load(object sender, EventArgs e)
        {
            // Logic có thể thêm ở đây nếu cần khởi tạo
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
