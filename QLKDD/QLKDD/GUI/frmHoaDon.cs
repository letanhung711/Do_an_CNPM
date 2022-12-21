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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public void TT_HD()
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.TTHD();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaHD"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["Dot"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenKH"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["NgayDocChiSo"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["Ngaygui"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["NgayThuTien"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaTieuThu"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TrangThai"].ToString());
            }
        }
        public void Combobox_KH()
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.TTKH();
            cbkh.DataSource = dt;
            cbkh.ValueMember = "MaKH";
            cbkh.DisplayMember = "TenKH";
        }
        public void Combobox_TT()
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.TTTT();
            cbmatt.DataSource = dt;
            cbmatt.ValueMember = "MaTieuThu";
            cbmatt.DisplayMember = "MaTieuThu";
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            cbtrangthai.Items.Add("Đã thanh toán");
            cbtrangthai.Items.Add("Chưa thanh toán");
            TT_HD();
            Combobox_KH();
            Combobox_TT();
        }

        private void lvds_Click(object sender, EventArgs e)
        {
            txtmahd.Text = lvds.SelectedItems[0].SubItems[0].Text;
            txtdot.Text = lvds.SelectedItems[0].SubItems[1].Text;
            cbkh.Text= lvds.SelectedItems[0].SubItems[2].Text;
            dtpngaydoccs.Text= lvds.SelectedItems[0].SubItems[3].Text;
            cbmatt.Text= lvds.SelectedItems[0].SubItems[6].Text;
            dtpngaythutien.Text= lvds.SelectedItems[0].SubItems[5].Text;
            dtpngaygui.Text= lvds.SelectedItems[0].SubItems[4].Text;
            cbtrangthai.Text= lvds.SelectedItems[0].SubItems[7].Text;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.Max_HD();
            string mahd = dt.Rows[0][0].ToString();
            txtmahd.Text = (int.Parse(mahd.Substring(mahd.Length - 2, 2)) + 1).ToString("HD00");
            cbkh.Text = cbmatt.Text = cbtrangthai.Text = txtdot.Text = "";
            dtpngaydoccs.ResetText();
            dtpngaygui.ResetText();
            dtpngaythutien.ResetText();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            cbkh.Text = cbmatt.Text = cbtrangthai.Text = txtdot.Text=txtmahd.Text=txttimkiem.Text = "";
            dtpngaydoccs.ResetText();
            dtpngaygui.ResetText();
            dtpngaythutien.ResetText();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.Mahd = txtmahd.Text;
            HoaDonBUS.Xoa_HD(hd);
            lvds.Items.Clear();
            TT_HD();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.Mahd = txtmahd.Text;
            hd.Dot = int.Parse(txtdot.Text);
            hd.Makh = cbkh.SelectedValue.ToString();
            hd.Matt = cbmatt.SelectedValue.ToString();
            hd.Trangthai = cbtrangthai.SelectedItem.ToString();
            hd.Ngaydoccs = dtpngaydoccs.Value.ToString("MM/dd/yyyy");
            hd.Ngaygui = dtpngaygui.Value.ToString("MM/dd/yyyy");
            hd.Ngaythutien = dtpngaythutien.Value.ToString("MM/dd/yyyy");
            HoaDonBUS.Sua_HD(hd);
            lvds.Items.Clear();
            TT_HD();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.Mahd = txtmahd.Text;
            hd.Dot = int.Parse(txtdot.Text);
            hd.Makh = cbkh.SelectedValue.ToString();
            hd.Matt = cbmatt.SelectedValue.ToString();
            hd.Trangthai = cbtrangthai.SelectedItem.ToString();
            hd.Ngaydoccs = dtpngaydoccs.Value.ToString("MM/dd/yyyy");
            hd.Ngaygui = dtpngaygui.Value.ToString("MM/dd/yyyy");
            hd.Ngaythutien = dtpngaythutien.Value.ToString("MM/dd/yyyy");
            HoaDonBUS.Luu_HD(hd);
            lvds.Items.Clear();
            TT_HD();
        }

        private void btntracuu_Click(object sender, EventArgs e)
        {
            lvds.Items.Clear();
            DataTable dt = new DataTable();
            HoaDonDTO hd = new HoaDonDTO();
            hd.Mahd = txttimkiem.Text;
            dt = HoaDonDAO.TimHD(hd);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaHD"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["Dot"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenKH"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["NgayDocChiSo"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["Ngaygui"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["NgayThuTien"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaTieuThu"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TrangThai"].ToString());
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            frmINHoaDon fr = new frmINHoaDon();
            fr.mahd = txtmahd.Text;
            fr.Show();
        }
    }
}
