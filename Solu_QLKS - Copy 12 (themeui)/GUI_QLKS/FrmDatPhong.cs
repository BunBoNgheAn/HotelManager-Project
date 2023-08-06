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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace GUI_QLKS
{
    public partial class FrmDatPhong : DevExpress.XtraEditors.XtraForm
    {
        #region khai báo       
        List<DTO_SuDungDichVu_List> lstSDDV = new List<DTO_SuDungDichVu_List>();
        BindingSource bs = new BindingSource();
        BUS_Phong busPH = new BUS_Phong();
        BUS_DichVu busDV = new BUS_DichVu();
        BUS_SuDungDichVu busSD = new BUS_SuDungDichVu();
        BUS_DatPhong busDP = new BUS_DatPhong();
        BUS_KhachHang busKH = new BUS_KhachHang();
        GridHitInfo downHitInfo = null;
        FrmHoaDon frmHD = (FrmHoaDon)Application.OpenForms["FrmHoaDon"];
        bool them = false;
        string maph = null;
        string loaiphong;
        #endregion
        public FrmDatPhong()
        {
            InitializeComponent();
        }
        #region MyRegion
        private void EnableControl(bool b)
        {
            cboMaKH.Enabled = b;
            txtMaDP.Enabled = b;
            cboMaPH.Enabled = false;
            dpNgayVao.Enabled = b;
            dpNgayRa.Enabled = b;

        }
        private void ButtonControl(bool b)
        {
            btnThem.Enabled = b;
            btnLuu.Enabled = !b;
            btnXoa.Enabled = b;
            btnSua.Enabled = b;
            btnHuy.Enabled = !b;

        }      
        #endregion

        #region Loadform
        void loadPhong()
        {            
            gcPhong.DataSource = busPH.getPhongTrong();
            dgvPhong.ExpandAllGroups();
        }
        void loadDichVu()
        {
            gcDichVu.DataSource = busDV.getDichVu();
            dgvDichVu.ExpandAllGroups();
        }
        void loadDP()
        {
            gcDatPhong.DataSource = busDP.getCTDP(dpFrom.Value,dpTo.Value);                        
            bnDatPhong.BindingSource = bs;
        }
        void loadListSDDV()
        {
            List<DTO_SuDungDichVu_List> lst1 = new List<DTO_SuDungDichVu_List>();
            foreach (var item in lstSDDV)
            {
                lst1.Add(item);
            }
            gcSDDV.DataSource = lst1;
        }
        void loadSDDV()
        {
            gcSDDV.DataSource = busSD.getSDDV(txtMaDP.Text);
        }
        void tinhtong()
        {
            float tienph = float.Parse(dgvDKDatPhong.Columns["GiaPhong"].SummaryItem.SummaryValue.ToString());
            float tiendv = float.Parse(dgvSDDV.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString());
            lbTongTien.Text = (tienph + tiendv).ToString("#,### VNĐ");
        }
        public void loadCboTenKH()
        {
            cboMaKH.DisplayMember = "HotenKH";
            cboMaKH.ValueMember = "MaKH";
            cboMaKH.DataSource = busKH.getKHnotinDP();
        }
        #endregion

        private void FrmDatPhong_Load(object sender, EventArgs e)
        {
            EnableControl(false);
            ButtonControl(true);
            loadPhong();
            loadDichVu();
            DataTable ph = busPH.getPhongTrong();
            gcDKDatPhong.DataSource = ph.Clone();
            loadListSDDV();
            loadCboTenKH();
            loadDP();
            btnXuatHoaDon.Enabled = false;
        }
        #region Chức năng
        private void btnThem_Click(object sender, EventArgs e)
        {
            tabDatPhong.SelectedTab = pageDKDP;
            EnableControl(true);
            ButtonControl(false);
            txtMaDP.Text = busDP.taomadp();          
            them = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xoá !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (busDP.xoaDatPhong(dgvDatPhong.GetFocusedRowCellValue("MaDP").ToString()) != 0 && busSD.xoaSDDV(dgvDatPhong.GetFocusedRowCellValue("MaPH").ToString()) != 0)
                {
                    MessageBox.Show("Xoá thành công !");
                    FrmDatPhong_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xoá.\n Vui lòng thử lại.");
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DTO_DatPhong dtoDP = new DTO_DatPhong(txtMaDP.Text, cboMaKH.SelectedValue.ToString(), cboMaPH.Text, dpNgayVao.Value, dpNgayRa.Value);
            DTO_SuDungDichVu dtoSD = new DTO_SuDungDichVu(dgvSDDV.GetFocusedRowCellValue("MaDP").ToString(), dgvSDDV.GetFocusedRowCellValue("MaDV").ToString(), 
                DateTime.Parse(dgvSDDV.GetFocusedRowCellValue("Ngay").ToString()), int.Parse(dgvSDDV.GetFocusedRowCellValue("SoLuong").ToString()), 
                float.Parse(dgvSDDV.GetFocusedRowCellValue("DonGia").ToString()), double.Parse(dgvSDDV.GetFocusedRowCellValue("ThanhTien").ToString()));
            if (them == true)
            {
                if (dgvDatPhong != null && busDP.luuDatPhong(dtoDP) != 0)
                {
                    if (busSD.luuSDDV(dtoSD) != 0)
                    {
                        MessageBox.Show("Lưu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi lưu sử dụng dịch vụ!!");                     
                    }
                    //FrmDatPhong_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu thông tin đặt phòng!!");
                    //FrmDatPhong_Load(sender, e);
                }
                them = false;
            }
            else
            {
                if (dgvDatPhong != null && busDP.suaDatPhong(dtoDP) != 0)
                {
                    if (busSD.suaSDDV(dtoSD) != 0)
                    {
                        MessageBox.Show("Thay đổi dữ liệu thành công!");
                        //FrmDatPhong_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi thay đổi dịch vụ!!");
                        //FrmDatPhong_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi thay đổi thông tin đặt phòng!!");
                    FrmDatPhong_Load(sender, e);
                }
            }          
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            EnableControl(true);
            ButtonControl(false);          
            txtMaDP.Enabled = true;                 
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            bs.CancelEdit();
            FrmDatPhong_Load(sender, e);
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            FrmKhachHang frmKH = new FrmKhachHang();
            frmKH.ShowDialog();
        }
        private void dpFrom_ValueChanged(object sender, EventArgs e)
        {
            loadDP();
        }
        private void gcDatPhong_DoubleClick(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            tabDatPhong.SelectedTab = pageDKDP;
            cboMaPH.Text = dgvDatPhong.GetFocusedRowCellValue("MaPH").ToString();
            cboMaKH.Text = dgvDatPhong.GetFocusedRowCellValue("HotenKH").ToString();
            //cboMaKH.Text = loadCboTenKH() ;
            txtMaDP.Text = dgvDatPhong.GetFocusedRowCellValue("MaDP").ToString();
            dpNgayVao.Text = dgvDatPhong.GetFocusedRowCellValue("NgayVao").ToString();
            dpNgayRa.Text = dgvDatPhong.GetFocusedRowCellValue("NgayRa").ToString();
            gcDKDatPhong.DataSource = busDP.getDPtheoMaDP(dgvDatPhong.GetFocusedRowCellValue("MaDP").ToString());
            loadSDDV();
            tinhtong();
            btnXuatHoaDon.Enabled = true;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FrmDatPhong_Load(sender, e);
        }
        #endregion

        #region Sự kiện dgvDatPhong
        private void dgvDatPhong_MouseDown(object sender, MouseEventArgs e)
        {
                if (dgvDKDatPhong.GetFocusedRowCellValue("MaPH").ToString() != null)
                {
                    maph = dgvDKDatPhong.GetFocusedRowCellValue("MaPH").ToString();
                    loaiphong = dgvDKDatPhong.GetFocusedRowCellValue("LoaiPhong").ToString();
                }
                GridView view = sender as GridView;
                downHitInfo = null;
                GridHitInfo hitInfor = view.CalcHitInfo(new Point(e.X, e.Y));
                if (Control.ModifierKeys != Keys.None) return;
                if (e.Button == MouseButtons.Left && hitInfor.RowHandle >= 0)
                {
                    downHitInfo = hitInfor;
                }                   
        }

        private void dgvDatPhong_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragsize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragsize.Width / 2, downHitInfo.HitPoint.Y - dragsize.Height / 2), dragsize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfo.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        private void dgvPhong_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;
            GridHitInfo hitInfor = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfor.RowHandle >= 0)
            {
                downHitInfo = hitInfor;
            }
        }

        private void dgvPhong_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragsize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragsize.Width / 2, downHitInfo.HitPoint.Y - dragsize.Height / 2), dragsize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfo.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }
        private void gcPhong_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            DataTable tbl = grid.DataSource as DataTable;
            DataRow row = e.Data.GetData(typeof(DataRow)) as DataRow;
            if (row != null && tbl != null && row.Table != tbl)
            {
                tbl.ImportRow(row);
                row.Delete();
            }
            cboMaPH.Text = dgvDKDatPhong.GetFocusedRowCellValue("MaPH").ToString();
            tinhtong();
        }

        private void gcPhong_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataRow)))
            {
                e.Effect = DragDropEffects.Move;
                return;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        #endregion

        #region Sự kiện dgvSDDV
        private void gcDichVu_DoubleClick(object sender, EventArgs e)
        {
            DTO_SuDungDichVu_List sddv = new DTO_SuDungDichVu_List();
            if (dgvDKDatPhong.GetFocusedRowCellValue("MaPH") == null)
            {
                MessageBox.Show("Hãy chọn phòng trước khi thêm dịch vụ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvDichVu.GetFocusedRowCellValue("MaDV") != null) 
            {

                sddv.MaDP = (txtMaDP.Text);
                sddv.MaDV = (dgvDichVu.GetFocusedRowCellValue("MaDV").ToString());
                sddv.TenDV = (dgvDichVu.GetFocusedRowCellValue("TenDV").ToString());
                sddv.Ngay = DateTime.Now;
                sddv.SoLuong = 1;
                sddv.DonGia = float.Parse(dgvDichVu.GetFocusedRowCellValue("DonGia").ToString());
                sddv.ThanhTien = sddv.DonGia * sddv.SoLuong;

                foreach (var item in lstSDDV)
                {
                    if (item.MaDV == sddv.MaDV && item.MaDP == sddv.MaDP)
                    {
                        item.SoLuong += 1;
                        item.ThanhTien = item.DonGia * item.SoLuong;
                        loadSDDV();
                        return;
                    }
                }
                lstSDDV.Add(sddv);
            }         
            loadListSDDV();
            tinhtong();
        }
        

        private void dgvSDDV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SoLuong")
            {
                int sl = int.Parse(e.Value.ToString());
                if (sl != 0)
                {
                    float dongia = float.Parse(dgvSDDV.GetRowCellValue(dgvSDDV.FocusedRowHandle, "DonGia").ToString());
                    dgvSDDV.SetRowCellValue(dgvSDDV.FocusedRowHandle, "ThanhTien", sl * dongia);
                }
                else
                {
                    dgvSDDV.SetRowCellValue(dgvSDDV.FocusedRowHandle, "ThanhTien", 0);
                }
                dgvSDDV.UpdateTotalSummary();
                tinhtong();
            }
        }
        #endregion
       
        private void pageDSDP_Click(object sender, EventArgs e)
        {
            //loadDP();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //CrystalReportViewer hd = new CrystalReportViewer();
            
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
