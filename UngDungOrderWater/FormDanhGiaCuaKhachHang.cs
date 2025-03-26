using System;
using System.Windows.Forms;

namespace UngDungOrderWater
{
    public partial class FormDanhGiaCuaKhachHang : Form
    {
        // Số sao được chọn (0 đến 5)
        private int rating = 0;

        public FormDanhGiaCuaKhachHang()
        {
            InitializeComponent();
        }

        private void FormDanhGiaCuaKhachHang_Load(object sender, EventArgs e)
        {
            // Khởi tạo các ngôi sao ban đầu là chưa sáng
            SetStars(0);
        }

        // Phương thức cập nhật trạng thái của các ngôi sao
        private void SetStars(int numberOfStars)
        {
            PictureBox[] stars = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };

            for (int i = 0; i < stars.Length; i++)
            {
                if (i < numberOfStars)
                {
                    stars[i].Image = Properties.Resources.sang;  // Ngôi sao sáng
                }
                else
                {
                    stars[i].Image = Properties.Resources.kosang;  // Ngôi sao chưa sáng
                }
            }
        }

        // Hàm xử lý khi người dùng nhấn vào ngôi sao bất kỳ
        private void ToggleStar(int starIndex)
        {
            if (rating == starIndex)
            {
                rating = starIndex - 1;
            }
            else
            {
                rating = starIndex;
            }

            SetStars(rating);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ToggleStar(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ToggleStar(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ToggleStar(3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ToggleStar(4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ToggleStar(5);
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Chúng tôi đã ghi nhận lời đánh giá với {rating} sao! Cảm ơn quý khách đã ủng hộ!!!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.Hide();

            foreach (Form form in Application.OpenForms)
            {
                if (form is TrangChu)
                {
                    form.Show();
                    return;
                }
            }

            TrangChu trangChu = new TrangChu();
            trangChu.Show();
        }

        // Cập nhật sự kiện Click cho các nút nhận xét
        private void btnNhanXet1_Click(object sender, EventArgs e)
        {
            // Lấy nội dung từ nút bấm
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;

            // Gán nội dung vào TextBox
            txbNhanXetKhachHang.Text = buttonText;
        }

        private void btnNhanXet2_Click(object sender, EventArgs e)
        {
            // Lấy nội dung từ nút bấm
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;

            // Gán nội dung vào TextBox
            txbNhanXetKhachHang.Text = buttonText;
        }

        private void btnNhanXet3_Click(object sender, EventArgs e)
        {
            // Lấy nội dung từ nút bấm
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;

            // Gán nội dung vào TextBox
            txbNhanXetKhachHang.Text = buttonText;
        }

        private void btnNhanXet4_Click(object sender, EventArgs e)
        {
            // Lấy nội dung từ nút bấm
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;

            // Gán nội dung vào TextBox
            txbNhanXetKhachHang.Text = buttonText;
        }

        private void btnNhanXet5_Click(object sender, EventArgs e)
        {
            // Lấy nội dung từ nút bấm
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;

            // Gán nội dung vào TextBox
            txbNhanXetKhachHang.Text = buttonText;
        }

        private void txbNhanXetKhachHang_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi nội dung TextBox thay đổi (nếu cần)
        }

        private void btnTroVe_Click(object sender, EventArgs e)
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
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
        }
    }
}
