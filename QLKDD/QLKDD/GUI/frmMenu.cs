using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKDD.GUI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            cumtoizeDesing();
        }

        public void cumtoizeDesing()
        {
            panelKHsubmenu.Visible = false;
            panelTDsubmenu.Visible = false;
        }
        public void hidesubmenu()
        {
            if (panelKHsubmenu.Visible == true)
                panelKHsubmenu.Visible = false;
            if (panelTDsubmenu.Visible == true)
                panelTDsubmenu.Visible = false;
        }
        public void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchildForm.Controls.Add(childForm);
            panelchildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnfrmKH_Click(object sender, EventArgs e)
        {
            showsubmenu(panelKHsubmenu);
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKhachHang());
            hidesubmenu();
        }

        private void btnbaotri_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBaoTri());
            hidesubmenu();
        }

        private void btnfrmtiendien_Click(object sender, EventArgs e)
        {
            showsubmenu(panelTDsubmenu);
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            //..
            //code
            //..
            hidesubmenu();
        }

        private void btntieuthu_Click(object sender, EventArgs e)
        {
            //..
            //code
            //..
            hidesubmenu();
        }

        private void btnfrmNV_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }

        private void btnfrmTK_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNguoiDung());
        }

        private void btnfrmHD_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHopDong());
        }
    }
}
