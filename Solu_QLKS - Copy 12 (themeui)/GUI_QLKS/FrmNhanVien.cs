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
    public partial class FrmNhanVien : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        BindingSource bs = new BindingSource();
        Function func = new Function();
        bool them = false;
        
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            //lbmessage.Text = "";
            txtMaNV.Enabled = false;
            EnableControl(false);
            ButtonControl(true);
            loadDataBinding();
        }

        void loadDataBinding()
        {
            bs.DataSource = busNV.getNhanVien();

            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("text", bs, "MaNV", true);

            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("text", bs, "HotenNV", true);

            cboPhai.DataBindings.Clear();
            cboPhai.DataBindings.Add("text", bs, "Phai", true);

            dtpNgaysinh.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Add("value", bs, "NgaySinh", true);

            txtChucvu.DataBindings.Clear();
            txtChucvu.DataBindings.Add("text", bs, "ChucVu", true);

            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("text", bs, "DiaChi", true);

            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("text", bs, "CMND", true);

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("text", bs, "SDT", true);

            bnNhanVien.BindingSource = bs;
            gcNhanVien.DataSource = bs;
        }
        void loadDataSearching()
        {
            bs.DataSource = busNV.timNhanVien(txtTim.Text);

            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("text", bs, "MaNV", true);

            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("text", bs, "HotenNV", true);

            cboPhai.DataBindings.Clear();
            cboPhai.DataBindings.Add("text", bs, "Phai", true);

            dtpNgaysinh.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Add("value", bs, "NgaySinh", true);

            txtChucvu.DataBindings.Clear();
            txtChucvu.DataBindings.Add("text", bs, "ChucVu", true);

            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("text", bs, "DiaChi", true);

            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("text", bs, "CMND", true);

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("text", bs, "SDT", true);

            bnNhanVien.BindingSource = bs;
            gcNhanVien.DataSource = bs;
        }
        #region Kiem tra du lieu
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
        private bool KTMaNV()
        {
            if (KTRong(txtMaNV, "Mã NV không được trống!!"))
            {
                return false;
            }
            return true;
        }
        private bool KTTenNV()
        {
            if (KTRong(txtHoten, "Tên NV không được trống!!")) 
            {
                return false;
            }
            return true;
        }
        private bool KTChucVu()
        {
            if (KTRong(txtChucvu, "Chức vụ không được trống!!")) 
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

        #region MyRegion
        private void EnableControl(bool b)
        {
            txtMaNV.Enabled = b;
            txtHoten.Enabled = b;
            cboPhai.Enabled = b;
            dtpNgaysinh.Enabled = b;
            txtChucvu.Enabled = b;
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
            //btnCapnhat.Enabled = !b;
            btnHuy.Enabled = !b;
            txtMaNV.Enabled = b;

        }
        #endregion

        private void btn_Them_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            EnableControl(true);
            ButtonControl(false);
            txtMaNV.Enabled = false;
            txtHoten.Focus();
            them = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (KTMaNV() || KTTenNV() || KTDiaChi() || KTSDT() || KTCMND())
            {
                return;
            }
            DTO_NhanVien dtoNV = new DTO_NhanVien(txtMaNV.Text, txtHoten.Text, cboPhai.Text, dtpNgaysinh.Value, txtChucvu.Text, txtDiachi.Text, txtCMND.Text, txtSDT.Text);
            if (them == true)
            {
                if (busNV.luuNhanVien(dtoNV) != 0)
                {
                    lbmessage.Text = "Lưu thành công!";
                    FrmNhanVien_Load(sender, e);
                }
                else
                {
                    lbmessage.Text = "Đã xảy ra lỗi khi lưu!!";
                    FrmNhanVien_Load(sender, e);
                }
                them = false;                           
            }
            else
            {
                if (busNV.suaNhanVien(dtoNV) != 0)
                {
                    lbmessage.Text = "Thay đổi dữ liệu thành công!";
                    FrmNhanVien_Load(sender, e);
                }
                else
                {
                    lbmessage.Text = "Đã xảy ra lỗi khi thay đổi dữ liệu!!";
                    FrmNhanVien_Load(sender, e);
                }
            }
        }      
        private void btnHuy_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            FrmNhanVien_Load(sender, e);
        }       
        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            
            loadDataSearching();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FrmNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_NhanVien dtoNV = new DTO_NhanVien(txtMaNV.Text, txtHoten.Text, cboPhai.Text, dtpNgaysinh.Value, txtChucvu.Text, txtDiachi.Text, txtCMND.Text, txtSDT.Text);

            if (MessageBox.Show("Bạn có chắc chắc xóa nhân viên này ?  \n (Khi xóa sẽ xóa những thông tin liên quan)", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busNV.xoaNhanVien(txtMaNV.Text) != 0)
                {
                    lbmessage.Text = "Xoá thành công !";
                    FrmNhanVien_Load(sender, e);
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
            txtMaNV.Enabled = false;
        }
    }
}
