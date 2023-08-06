using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLKS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            hideSubMenu();
        }
        void OpenForm(Type typeForm)
        {
            foreach (Form form in MdiChildren)
            {
                if (form.GetType() == typeForm)
                {
                    form.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }
        private void hideSubMenu()
        {
            panel_thongtin.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_thongtin);
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmDatPhong());
            hideSubMenu();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmNhanVien());
            hideSubMenu();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmPhong());
            hideSubMenu();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmDichVu());
            hideSubMenu();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmKhachHang());
            hideSubMenu();

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmHoaDon());           
        }
    }
}
