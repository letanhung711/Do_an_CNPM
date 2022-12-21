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
    public partial class frmTieuThu : Form
    {
        public frmTieuThu()
        {
            InitializeComponent();
        }

        public void Combobox_KH()
        {
            DataTable dt = new DataTable();
            dt = TieuThuDAO.TTKH();
            cbkh.DataSource = dt;
            cbkh.ValueMember = "MaKH";
            cbkh.DisplayMember = "TenKH";
        }
        public void Combobox_NV()
        {
            DataTable dt = new DataTable();
            dt = TieuThuDAO.TTNV();
            cbnv.DataSource = dt;
            cbnv.ValueMember = "MaNV";
            cbnv.DisplayMember = "TenNV";
        }
        public void Combobox_DK()
        {
            DataTable dt = new DataTable();
            dt = TieuThuDAO.TTDK();
            cbdk.DataSource = dt;
            cbdk.ValueMember = "MaDK";
            cbdk.DisplayMember = "MaDK";
        }
        public void TT_TieuThu()
        {
            DataTable dt = new DataTable();
            dt = TieuThuDAO.TTTT();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaTieuThu"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenKH"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["DienCu"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["DienMoi"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TongTT"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["Ngaynhap"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenNV"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaDK"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TienDien"].ToString());
            }
        }

        private void frmTieuThu_Load(object sender, EventArgs e)
        {
            Combobox_KH();
            Combobox_NV();
            Combobox_DK();
            TT_TieuThu();
        }

        private void lvds_Click(object sender, EventArgs e)
        {
            txtmatt.Text = lvds.SelectedItems[0].SubItems[0].Text;
            cbkh.Text= lvds.SelectedItems[0].SubItems[1].Text;
            cbnv.Text= lvds.SelectedItems[0].SubItems[6].Text;
            cbdk.Text= lvds.SelectedItems[0].SubItems[7].Text;
            txtdiencu.Text= lvds.SelectedItems[0].SubItems[2].Text;
            txtdienmoi.Text= lvds.SelectedItems[0].SubItems[3].Text;
            dtpngaynhap.Text= lvds.SelectedItems[0].SubItems[5].Text;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = TieuThuDAO.Max_TT();
            string matt = dt.Rows[0][0].ToString();
            txtmatt.Text= (int.Parse(matt.Substring(matt.Length - 2, 2)) + 1).ToString("TT00");
            txtdiencu.Text = txtdienmoi.Text = cbdk.Text = cbkh.Text = cbnv.Text = "";
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtdiencu.Text = txtdienmoi.Text = cbdk.Text = cbkh.Text = cbnv.Text = "";
            dtpngaynhap.ResetText();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            TieuThuDTO tt = new TieuThuDTO();
            tt.Matt = txtmatt.Text;
            TieuThuBUS.Xoa_TT(tt);
            lvds.Items.Clear();
            TT_TieuThu();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            TieuThuDTO tt = new TieuThuDTO();
            tt.Matt = txtmatt.Text;
            tt.Madk = cbdk.SelectedValue.ToString();
            tt.Makh = cbkh.SelectedValue.ToString();
            tt.Manv = cbnv.SelectedValue.ToString();
            tt.Diencu = int.Parse(txtdiencu.Text);
            tt.Dienmoi = int.Parse(txtdienmoi.Text);
            tt.Ngaynhap = dtpngaynhap.Value.ToString("MM/dd/yyyy");
            tt.Tiendien = int.Parse(lbltongtien.Text);
            TieuThuBUS.Sua_TT(tt);
            lvds.Items.Clear();
            TT_TieuThu();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            TieuThuDTO tt = new TieuThuDTO();
            tt.Matt = txtmatt.Text;
            tt.Madk = cbdk.SelectedValue.ToString();
            tt.Makh = cbkh.SelectedValue.ToString();
            tt.Manv = cbnv.SelectedValue.ToString();
            tt.Diencu = int.Parse(txtdiencu.Text);
            tt.Dienmoi = int.Parse(txtdienmoi.Text);
            tt.Ngaynhap = dtpngaynhap.Value.ToString("MM/dd/yyyy");
            tt.Tiendien = int.Parse(lbltongtien.Text);
            TieuThuBUS.Luu_TT(tt);
            lvds.Items.Clear();
            TT_TieuThu();
            btnluu.Enabled = false;
        }

        private void btntinhtien_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;
            int tongtien = 0;
            int luongtt = int.Parse(txtdienmoi.Text) - int.Parse(txtdiencu.Text);

            DataTable dt = new DataTable();
            dt = TieuThuDAO.TTKH();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["MaKH"].ToString() == cbkh.SelectedValue.ToString())
                {
                    if (dt.Rows[i]["MaLoai"].ToString() == "SH")
                    {
                        if (luongtt <= 100)
                        {
                            tongtien = luongtt * 500;
                            lbltongtien.Text = tongtien.ToString();
                        }
                        if (luongtt >= 100 && luongtt <= 120)
                        {
                            tongtien = luongtt * 650;
                            lbltongtien.Text = tongtien.ToString();
                        }
                        if (luongtt >= 120)
                        {
                            tongtien = luongtt * 800;
                            lbltongtien.Text = tongtien.ToString();
                        }
                    }

                    if ((dt.Rows[i]["MaLoai"].ToString() == "SX"))
                    {
                        if (luongtt <= 500)
                        {
                            tongtien = luongtt * 850;
                            lbltongtien.Text = tongtien.ToString();
                        }
                        if (luongtt >= 500)
                        {
                            tongtien = luongtt * 1000;
                            lbltongtien.Text = tongtien.ToString();
                        }
                    }
                }
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            lvds.Items.Clear();
            DataTable dt = new DataTable();
            KhachHangDTO kh = new KhachHangDTO();
            kh.Tenkh = txttimkiem.Text;
            dt = TieuThuDAO.Tim_TT(kh);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaTieuThu"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenKH"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["DienCu"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["DienMoi"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TongTT"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["Ngaynhap"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TenNV"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaDK"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TienDien"].ToString());
            }
        }
    }
}
