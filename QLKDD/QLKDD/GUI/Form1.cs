using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKDD.GUI;
using QLKDD.DTO;
using QLKDD.DAO;

namespace QLKDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.MaNV = txttk.Text;
            nv.MK = txtmk.Text;
            DataTable dt = new DataTable();
            dt = NhanVienDAO.KTTK(nv);
            int stt = dt.Rows.Count;
            if (stt == 1)
            {
                frmMenu tc = new frmMenu(dt.Rows[0]["MaNV"].ToString(), dt.Rows[0]["MaCV"].ToString());
                tc.Show();
                this.Hide();
                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo");
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu \nVui lòng Kiểm tra lại !!", "Thông Báo");
                txttk.Focus();
            }
        }

        private bool isthoat = true;
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isthoat)
                Application.Exit();
        }
    }
}
