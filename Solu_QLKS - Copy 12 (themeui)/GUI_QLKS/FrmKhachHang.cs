using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS_QLKS;
using DTO_QLKS;

namespace GUI_QLKS
{
    public partial class FrmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        FrmDatPhong frmDP = (FrmDatPhong)Application.OpenForms["frmDatPhong"];
        BUS_KhachHang busKH = new BUS_KhachHang();
        BindingSource bs = new BindingSource();
        Function func = new Function();
        bool them = false;
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        #region MyRegion
        private void EnableControl(bool b)
        {
            txtMaKH.Enabled = b;
            txtHoten.Enabled = b;
            cboPhai.Enabled = b;
            dtpNgaysinh.Enabled = b;
            txtDiachi.Enabled = b;
            txtCMND.Enabled = b;
            txtSDT.Enabled = b;
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
            txtMaKH.Enabled = b;

        }
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
        private bool KTMaKH()
        {
            if (KTRong(txtMaKH, "Mã KH không được trống!!")) 
            {
                return false;
            }
            return true;
        }
        private bool KTTenKH()
        {
            if (KTRong(txtHoten, "Họ tên KH không được trống!!"))
            {
                return false;
            }
            return true;
        }
        private bool KTDiaChi()
        {
            if (KTRong(txtDiachi, "Địa chỉ không được trống!!"))
            {
                return false;
            }
            return true;
        }
        private bool KTCMND()
        {
            if (KTRong(txtCMND, "CMND không được trống!!"))
            {
                return false;
            }
            return true;
        }
        private bool KTSDT()
        {
            if (!KTRong(txtSDT, "Số điện thoại không được để trống"))
            {
                return false;
            }
            if (!func.Check(Function.ValidateType.PHONENUMBER, txtSDT.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region LoadForm
        void loadDataBinding()
        {
            dgvKhachHang.BeginUpdate();
            bs.DataSource = busKH.getKhachHang();

            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("text", bs, "MaKH", true);

            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("text", bs, "HotenKH", true);

            cboPhai.DataBindings.Clear();
            cboPhai.DataBindings.Add("text", bs, "Phai", true);

            dtpNgaysinh.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Add("value", bs, "NgaySinh", true);

            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("text", bs, "DiaChi", true);

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("text", bs, "SDT", true);

            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("text", bs, "CMND", true);

            bnKhachHang.BindingSource = bs;
            gcKhachHang.DataSource = bs;
            dgvKhachHang.EndUpdate();
        }
        void loadDataSearching()
        {
            bs.DataSource = busKH.timKhachHang(txtTim.Text);

            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("text", bs, "MaKH", true);

            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("text", bs, "HotenKH", true);

            cboPhai.DataBindings.Clear();
            cboPhai.DataBindings.Add("text", bs, "Phai", true);

            dtpNgaysinh.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Add("value", bs, "NgaySinh", true);

            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("text", bs, "DiaChi", true);

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("text", bs, "SDT", true);

            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("text", bs, "CMND", true);

            bnKhachHang.BindingSource = bs;
            gcKhachHang.DataSource = bs;
        }      
        #endregion
        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            EnableControl(false);
            ButtonControl(true);
            
            loadDataBinding();
        }
        #region chức năng
        private void btnThem_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            EnableControl(true);
            ButtonControl(false);
            txtMaKH.Enabled = false;
            txtHoten.Focus();
            them = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KTMaKH() || KTTenKH() || KTDiaChi() || KTSDT() || KTCMND()) 
            {
                return;
            }
            DTO_KhachHang dtoKH = new DTO_KhachHang(txtMaKH.Text, txtHoten.Text, cboPhai.Text, dtpNgaysinh.Value, txtDiachi.Text, txtCMND.Text, txtSDT.Text);
            if (them == true)
            {
                if (busKH.luuKhachHang(dtoKH) != 0)
                {
                    lbmessage.Text = "Lưu thành công!";
                    FrmKhachHang_Load(sender, e);
                }
                else
                {
                    lbmessage.Text = "Đã xảy ra lỗi khi lưu!!";
                    FrmKhachHang_Load(sender, e);
                }
                them = false;
            }
            else
            {
                if (busKH.suaKhachHang(dtoKH) != 0)
                {
                    lbmessage.Text = "Thay đổi dữ liệu thành công!";
                    FrmKhachHang_Load(sender, e);
                }
                else
                {
                    lbmessage.Text = "Đã xảy ra lỗi khi thay đổi dữ liệu!!";
                    FrmKhachHang_Load(sender, e);
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_KhachHang dtoKH = new DTO_KhachHang(txtMaKH.Text, txtHoten.Text, cboPhai.Text, dtpNgaysinh.Value, txtDiachi.Text, txtCMND.Text, txtSDT.Text);
            try
            {
                if (MessageBox.Show("Bạn có chắc chắc xóa nhân viên này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (busKH.xoaKhachHang(txtMaKH.Text) != 0)
                    {
                        lbmessage.Text = "Xoá thành công !";
                        FrmKhachHang_Load(sender, e);
                    }
                    else
                    {
                        lbmessage.Text = "Đã xảy ra lỗi khi xoá.\n Vui lòng thử lại.";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không thể xoá khách đã đặt phòng!!");
            }
        }
        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            loadDataSearching();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableControl(true);
            ButtonControl(false);
            txtMaKH.Enabled = false;
        }   
        private void btnHuy_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            FrmKhachHang_Load(sender, e);
        }
        #endregion

        private void dgvKhachHang_DoubleClick(object sender, EventArgs e)
        {            
            if (dgvKhachHang.GetFocusedRowCellValue("MaKH").ToString() != null)
            {
                string kh = dgvKhachHang.GetFocusedRowCellValue("HotenKH").ToString();
                frmDP.cboMaKH.Text = kh;
            }
            this.Close();
        }
    }
}