using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLKS;
using DTO_QLKS;

namespace GUI_QLKS
{
    public partial class FrmDichVu : Form
    {
        BUS_DichVu busDV = new BUS_DichVu();
        BindingSource bs = new BindingSource();
        bool them = false;
        
        public FrmDichVu()
        {
            InitializeComponent();
        }

        #region MyRegion
        private void EnableControl(bool b)
        {
            txtMaDV.Enabled = b;
            cboLoaiDV.Enabled = b;
            txtTenDV.Enabled = b;
            txtDonGia.Enabled = b;
        }
        private void ButtonControl(bool b)
        {
            btnThem.Enabled = b;
            btnLuu.Enabled = !b;
            btnXoa.Enabled = b;
            btnSua.Enabled = b;
            btnHuy.Enabled = !b;

        }
        private void ButtonControl1(bool b)
        {
            btnThem.Enabled = b;
            btnLuu.Enabled = b;
            btnXoa.Enabled = b;
            btnSua.Enabled = b;
            btnHuy.Enabled = !b;
            txtMaDV.Enabled = b;

        }
        #endregion

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            txtMaDV.Enabled = false;
            EnableControl(false);
            ButtonControl(true);
            loadDataBinding();
        }
        void loadDataBinding()
        {
            bs.DataSource = busDV.getDichVu();

            txtMaDV.DataBindings.Clear();
            txtMaDV.DataBindings.Add("text", bs, "MaDV", true);

            cboLoaiDV.DataBindings.Clear();
            cboLoaiDV.DataBindings.Add("text", bs, "LoaiDV", true);

            txtTenDV.DataBindings.Clear();
            txtTenDV.DataBindings.Add("text", bs, "TenDV", true);

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("text", bs, "Dongia", true);

            bnDichVu.BindingSource = bs;
            gcDichVu.DataSource = bs;
        }
        #region kiểm tra dữ liệu
        private bool KTRong(Control ct, string message)
        {
            if (ct.Text.Trim() == "")
            {
                ct.Focus();
                MessageBox.Show(message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        private bool KTMaDV()
        {
            if (KTRong(txtMaDV, "Mã dịch vụ không được trống!!"))
            {
                return false;
            }
            return true;
        }
        private bool KTLoaiDV()
        {
            if (KTRong(cboLoaiDV, "Loại dịch vụ không được trống!!"))
            {
                return false;
            }
            return true;
        }
        private bool KTTenDV()
        {
            if (KTRong(txtTenDV, "Tên dịch vụ không được trống!!"))
            {
                return false;
            }
            return true;
        }
        private bool KTDonGia()
        {
            if (KTRong(txtDonGia, "Đơn giá không được trống!!"))
            {
                return false;
            }
            return true;
        }
        #endregion
        private void btnThem_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            EnableControl(true);
            ButtonControl(false);
            txtMaDV.Enabled = false;
            cboLoaiDV.Focus();
            them = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KTMaDV() || KTLoaiDV() || KTTenDV() || KTDonGia()) 
            {
                return;
            }
            DTO_DichVu dtoDV = new DTO_DichVu(txtMaDV.Text, cboLoaiDV.Text, txtTenDV.Text, float.Parse(txtDonGia.Text));
            if (them == true)
            {
                if (busDV.luuDichVu(dtoDV) != 0)
                {
                    lbmessage.Text = "Lưu thành công!";
                    FrmDichVu_Load(sender, e);
                }
                else
                {
                    lbmessage.Text = "Đã xảy ra lỗi khi lưu!!";
                    FrmDichVu_Load(sender, e);
                }
                them = false;
            }
            else
            {
                if (busDV.luuDichVu(dtoDV) != 0)
                {
                    lbmessage.Text = "Thay đổi dữ liệu thành công!";
                    FrmDichVu_Load(sender, e);
                }
                else
                {
                    lbmessage.Text = "Đã xảy ra lỗi khi thay đổi dữ liệu!!";
                    FrmDichVu_Load(sender, e);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_DichVu dtoDV = new DTO_DichVu(txtMaDV.Text, cboLoaiDV.Text, txtTenDV.Text, float.Parse(txtDonGia.Text));         

            if (MessageBox.Show("Bạn có chắc chắc xóa nhân viên này ?  \n (Khi xóa sẽ xóa những thông tin liên quan)", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busDV.xoaDichVu(txtMaDV.Text) != 0)
                {
                    lbmessage.Text = "Xoá thành công !";
                    FrmDichVu_Load(sender, e);
                }
                else
                {
                    lbmessage.Text = "Đã xảy ra lỗi khi xoá.\n Vui lòng thử lại.";
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableControl(true);
            ButtonControl(false);
            txtMaDV.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            FrmDichVu_Load(sender, e);
        }
    }
}
