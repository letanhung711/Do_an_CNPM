using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKDD.DAO;
using QLKDD.DTO;
using QLKDD.BUS;

namespace QLKDD.GUI
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public void TT_KH()
        {
            DataTable dt = new DataTable();
            dt = KhachHangDAO.TTKH();
            int sokh = dt.Rows.Count;
            for(int i = 0; i < sokh; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaKH"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenKH"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["SDT"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["Tenduong"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenLoai"].ToString());
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            TT_KH();
        }

        private void lvds_Click(object sender, EventArgs e)
        {
            txtmakh.Text = lvds.SelectedItems[0].SubItems[0].Text;
            txttenkh.Text= lvds.SelectedItems[0].SubItems[1].Text;
            txtdiachi.Text= lvds.SelectedItems[0].SubItems[3].Text;
            txtsdt.Text= lvds.SelectedItems[0].SubItems[2].Text;
            if (lvds.SelectedItems[0].SubItems[4].Text == "Điện sinh hoạt")
                rdsinhhoat.Checked = true;
            else
                rdsanxuat.Checked = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = KhachHangDAO.Max_KH();
            string makh = dt.Rows[0][0].ToString();
            txtmakh.Text = (int.Parse(makh.Substring(makh.Length - 2, 2)) + 1).ToString("KH00");
            txttenkh.Text = txtdiachi.Text = txtsdt.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.Makh = txtmakh.Text;
            kh.Tenkh = txttenkh.Text;
            kh.Sdt = txtsdt.Text;
            kh.Diachi = txtdiachi.Text;
            if (rdsinhhoat.Checked == true)
                kh.Maloaikh = "SH";
            else
                kh.Maloaikh = "SX";
            KhachHangBUS.LuuKH(kh);
            lvds.Items.Clear();
            TT_KH();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.Makh = txtmakh.Text;
            KhachHangBUS.Xoa_KH(kh);
            lvds.Items.Clear();
            TT_KH();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.Makh = txtmakh.Text;
            kh.Tenkh = txttenkh.Text;
            kh.Sdt = txtsdt.Text;
            kh.Diachi = txtdiachi.Text;
            if (rdsinhhoat.Checked == true)
                kh.Maloaikh = "SH";
            else
                kh.Maloaikh = "SX";
            KhachHangBUS.CapNhat_KH(kh);
            lvds.Items.Clear();
            TT_KH();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmakh.Text = txttenkh.Text = txtsdt.Text = txtdiachi.Text = "";
        }

        private void btntracuu_Click(object sender, EventArgs e)
        {
            lvds.Items.Clear();
            DataTable dt = new DataTable();
            KhachHangDTO kh = new KhachHangDTO();
            kh.Tenkh = txttimkiem.Text;
            dt = KhachHangDAO.TimKH(kh);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaKH"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenKH"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["SDT"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["Tenduong"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenLoai"].ToString());
            }
        }
    }
}
