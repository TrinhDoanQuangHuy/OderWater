using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UngDungOrderWater
{
    public partial class FormHoTro : Form
    {
        TrangChu mainform;
        public FormHoTro(TrangChu form)
        {
            InitializeComponent();
            this.mainform = form;
            lklfb.LinkClicked += new LinkLabelLinkClickedEventHandler(lklfb_LinkClicked);
            lklgg.LinkClicked += new LinkLabelLinkClickedEventHandler(lklgg_LinkClicked);
        }



        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
            foreach (Form form in Application.OpenForms)
            {
                if (form is TrangChu)
                {
                    form.BringToFront();  
                    return;
                }

            }
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
        }

        private void FormHoTro_Load(object sender, EventArgs e)
        {

        }

        private void lklfb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.facebook.com/lehonggiahuy2407?locale=vi_VN";

            
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void lklgg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.google.com/intl/vi/account/about/";

            
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void btnGuiTinNhan_Click(object sender, EventArgs e)
        {
            string hoVaTen = txtHoTenKhachHang.Text;
            string email = txtEmail.Text;
            string soDienThoai = txtSDT.Text;
            string YeuCau = txtHoTro.Text;

         
            string content = $"\nHọ và Tên: {hoVaTen}\nEmail: {email}\nSố điện thoại: {soDienThoai}\nYêu cầu: {YeuCau}";

            string filePath = @"C:\HoTroKhachHang\SupportCusTomer.txt";



            try
            {
                System.IO.File.AppendAllText(filePath, content);
                MessageBox.Show("Thông tin đã được lưu vào Notepad!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi lưu thông tin: {ex.Message}");
            }
        }

    }
}

