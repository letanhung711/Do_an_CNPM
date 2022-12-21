using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKDD.DTO;
using QLKDD.DAO;
using QLKDD.BUS;

namespace QLKDD.GUI
{
    public partial class frmNguoiDung : Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        public void TT_ND()
        {
            DataTable dt = new DataTable();
            dt = NguoiDungDAO.TTND();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaNV"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["SDT"].ToString());
                lvds.Items[i].SubItems.Add("***********");
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenCV"].ToString());
            }
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            TT_ND();
        }

        private void lvds_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = NguoiDungDAO.TTMK(lvds.SelectedItems[0].SubItems[0].Text);
            txtmanv.Text = lvds.SelectedItems[0].SubItems[0].Text;
            txtsdt.Text= lvds.SelectedItems[0].SubItems[1].Text;
            txtchuc.Text= lvds.SelectedItems[0].SubItems[3].Text;
            txtmk.Text = dt.Rows[0][0].ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = NguoiDungDAO.TTMK(txtmanv.Text);
            if (txtmknow.Text == dt.Rows[0][0].ToString())
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.MaNV = txtmanv.Text;
                nv.MK = txtmknew.Text;
                NhanVienBUS.CapNhat_ND(nv);
                txtmknow.Text = txtmknew.Text = "";
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hiện tại. Xin mời nhập lại!", "Thông báo");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmanv.Text = txtsdt.Text = txtchuc.Text = txtmk.Text = txtmknow.Text = txtmknew.Text = "";
        }

        private void btntracuu_Click(object sender, EventArgs e)
        {
            lvds.Items.Clear();
            NhanVienDTO nv = new NhanVienDTO();
            nv.MaNV = txttimkiem.Text;
            DataTable dt = new DataTable();
            dt = NguoiDungDAO.TimND(nv);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaNV"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["SDT"].ToString());
                lvds.Items[i].SubItems.Add("***********");
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenCV"].ToString());
            }
        }
    }
}
