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
    public partial class BrandStarBuck : UserControl
    {
        public BrandStarBuck()
        {
            InitializeComponent();
        }

        public event Action<Product> OnProductSelected;

        private void btnMuaNuocStarBuck1_Click(object sender, EventArgs e)
        {
            // Lấy số lượng từ NumericUpDown
            int soLuong = (int)nudFreezeCaCao.Value;

            var selectedProduct = new Product
            {
                Name = "Freeze Cacao",
                Quantity = soLuong,  // Số lượng lấy từ NumericUpDown
                Price = 65000
            };

            OnProductSelected?.Invoke(selectedProduct);
        }

        private void btnMuaNuocStarBuck2_Click(object sender, EventArgs e)
        {
            // Lấy số lượng từ NumericUpDown
            int soLuong = (int)nudFrezzeCaramel.Value;

            var selectedProduct = new Product
            {
                Name = "Freeze Cacao",
                Quantity = soLuong,  // Số lượng lấy từ NumericUpDown
                Price = 60000
            };

            OnProductSelected?.Invoke(selectedProduct);
          
        }

        private void btnMuaNuocStarBuck3_Click(object sender, EventArgs e)
        {
            // Lấy số lượng từ NumericUpDown
            int soLuong = (int)nudFreezeMatcha.Value;

            var selectedProduct = new Product
            {
                Name = "Freeze Matcha",
                Quantity = soLuong,  // Số lượng lấy từ NumericUpDown
                Price = 60000
            };

            OnProductSelected?.Invoke(selectedProduct);
        }
    }
}
