using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLKS;
using BUS_QLKS;

namespace GUI_QLKS
{
    public partial class FrmPhong : DevExpress.XtraEditors.XtraForm
    {
        BUS_Phong busPH = new BUS_Phong();
        BindingSource bs = new BindingSource();
        bool them = false;

        public FrmPhong()
        {
            InitializeComponent();
        }
        #region MyRegion
        private void EnableControl(bool b)
        {
            txtMaPH.Enabled = b;
            txtLoaiPhong.Enabled = b;
            txtSoNg.Enabled = b;
            txtGiaPhong.Enabled = b;
            txtTinhTrang.Enabled = b;
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
            txtMaPH.Enabled = b;
        }
        #endregion
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
        private bool KTMaPH()
        {
            if (KTRong(txtMaPH, "Mã phòng không được trống!!"))
            {
                return false;
            }
            return true;
        }
        private bool KTLoaiPH()
        {
            if (KTRong(txtLoaiPhong, "Loại phòng không được trống!!"))
            {
                return false;
            }
            return true;
        }
        private bool KTMaxNguoi()
        {
            if (KTRong(txtSoNg, "Số người không được trống!!"))
            {
                return false;
            }
            return true;
        }
        private bool KTDonPhong()
        {
            if (KTRong(txtGiaPhong, "Đơn giá không được trống!!"))
            {
                return false;
            }
            return true;
        }
        #endregion
        void loadDataBinding()
        {
            bs.DataSource = busPH.getPhong();

            txtMaPH.DataBindings.Clear();
            txtMaPH.DataBindings.Add("text", bs, "MaPH", true);

            txtLoaiPhong.DataBindings.Clear();
            txtLoaiPhong.DataBindings.Add("text", bs, "LoaiPhong", true);

            txtSoNg.DataBindings.Clear();
            txtSoNg.DataBindings.Add("text", bs, "SoNgToiDa", true);

            txtGiaPhong.DataBindings.Clear();
            txtGiaPhong.DataBindings.Add("text", bs, "GiaPhong", true);

            txtTinhTrang.DataBindings.Clear();
            txtTinhTrang.DataBindings.Add("text", bs, "TinhTrang", true);

            bnPhong.BindingSource = bs;
            gcPhong.DataSource = bs;
        }
        private void FrmPhong_Load(object sender, EventArgs e)
        {
            txtMaPH.Enabled = false;
            EnableControl(false);
            ButtonControl(true);
            loadDataBinding();
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            bs.AddNew();
            EnableControl(true);
            ButtonControl(false);
            txtMaPH.Enabled = false;
            txtLoaiPhong.Focus();
            them = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_Phong dtoPH = new DTO_Phong(txtMaPH.Text, txtLoaiPhong.Text, int.Parse(txtSoNg.Text), float.Parse(txtGiaPhong.Text), txtTinhTrang.Text);
            if (MessageBox.Show("Bạn có chắc chắc xóa nhân viên này ?  \n (Khi xóa sẽ xóa những thông tin liên quan)", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busPH.xoaPhong(txtMaPH.Text) != 0)
                {
                    MessageBox.Show("Xoá thành công !");
                    FrmPhong_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xoá.\n Vui lòng thử lại.");
                }
            }
        }
    }
}