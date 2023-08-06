namespace GUI_QLKS
{
    partial class FrmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bnHoaDon = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.txtTim = new System.Windows.Forms.ToolStripTextBox();
            this.btnTim = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.tabHoaDon = new System.Windows.Forms.TabControl();
            this.tabDSHoaDon = new System.Windows.Forms.TabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dpFrom = new System.Windows.Forms.DateTimePicker();
            this.dpTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gcHoaDon = new DevExpress.XtraGrid.GridControl();
            this.dgvHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaDP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienPH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabCTHoaDon = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.bnHoaDon)).BeginInit();
            this.bnHoaDon.SuspendLayout();
            this.tabHoaDon.SuspendLayout();
            this.tabDSHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // bnHoaDon
            // 
            this.bnHoaDon.AddNewItem = null;
            this.bnHoaDon.CountItem = this.bindingNavigatorCountItem;
            this.bnHoaDon.DeleteItem = null;
            this.bnHoaDon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnHoaDon.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnHoaDon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnThem,
            this.btnLuu,
            this.btnXoa,
            this.btnSua,
            this.btnHuy,
            this.txtTim,
            this.btnTim,
            this.btnRefresh,
            this.btnIn});
            this.bnHoaDon.Location = new System.Drawing.Point(0, 0);
            this.bnHoaDon.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnHoaDon.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnHoaDon.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnHoaDon.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnHoaDon.Name = "bnHoaDon";
            this.bnHoaDon.PositionItem = this.bindingNavigatorPositionItem;
            this.bnHoaDon.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bnHoaDon.Size = new System.Drawing.Size(1082, 40);
            this.bnHoaDon.TabIndex = 26;
            this.bnHoaDon.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 37);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Image = global::GUI_QLKS.Properties.Resources.next_left;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(35, 37);
            this.bindingNavigatorMoveFirstItem.Text = "Đầu";
            this.bindingNavigatorMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Image = global::GUI_QLKS.Properties.Resources.next_left1;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(45, 37);
            this.bindingNavigatorMovePreviousItem.Text = "Trước";
            this.bindingNavigatorMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 40);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.Image = global::GUI_QLKS.Properties.Resources.next_right1;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(33, 37);
            this.bindingNavigatorMoveNextItem.Text = "Sau";
            this.bindingNavigatorMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Image = global::GUI_QLKS.Properties.Resources.next_right;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(38, 37);
            this.bindingNavigatorMoveLastItem.Text = "Cuối";
            this.bindingNavigatorMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::GUI_QLKS.Properties.Resources.add__1_;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(44, 37);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::GUI_QLKS.Properties.Resources.check;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(33, 37);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI_QLKS.Properties.Resources.trash;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(35, 37);
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::GUI_QLKS.Properties.Resources.writing;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(34, 37);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::GUI_QLKS.Properties.Resources.forbidden;
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(34, 37);
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtTim
            // 
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(100, 40);
            // 
            // btnTim
            // 
            this.btnTim.Image = global::GUI_QLKS.Properties.Resources.search;
            this.btnTim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(33, 37);
            this.btnTim.Text = "Tìm";
            this.btnTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::GUI_QLKS.Properties.Resources.sync;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(62, 37);
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnIn
            // 
            this.btnIn.Image = global::GUI_QLKS.Properties.Resources.printer;
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(23, 37);
            this.btnIn.Text = "In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tabHoaDon
            // 
            this.tabHoaDon.Controls.Add(this.tabDSHoaDon);
            this.tabHoaDon.Controls.Add(this.tabCTHoaDon);
            this.tabHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHoaDon.Location = new System.Drawing.Point(0, 40);
            this.tabHoaDon.Name = "tabHoaDon";
            this.tabHoaDon.SelectedIndex = 0;
            this.tabHoaDon.Size = new System.Drawing.Size(1082, 708);
            this.tabHoaDon.TabIndex = 27;
            // 
            // tabDSHoaDon
            // 
            this.tabDSHoaDon.Controls.Add(this.splitContainerControl1);
            this.tabDSHoaDon.Location = new System.Drawing.Point(4, 22);
            this.tabDSHoaDon.Name = "tabDSHoaDon";
            this.tabDSHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabDSHoaDon.Size = new System.Drawing.Size(1074, 682);
            this.tabDSHoaDon.TabIndex = 0;
            this.tabDSHoaDon.Text = "Danh sách hoá đơn";
            this.tabDSHoaDon.UseVisualStyleBackColor = true;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(3, 3);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.dpFrom);
            this.splitContainerControl1.Panel1.Controls.Add(this.dpTo);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Controls.Add(this.label3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcHoaDon);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1068, 676);
            this.splitContainerControl1.SplitterPosition = 68;
            this.splitContainerControl1.TabIndex = 19;
            // 
            // dpFrom
            // 
            this.dpFrom.CustomFormat = "dd/MM/yyyy";
            this.dpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFrom.Location = new System.Drawing.Point(365, 18);
            this.dpFrom.Name = "dpFrom";
            this.dpFrom.Size = new System.Drawing.Size(113, 26);
            this.dpFrom.TabIndex = 21;
            this.dpFrom.Value = new System.DateTime(2022, 2, 1, 0, 0, 0, 0);
            this.dpFrom.ValueChanged += new System.EventHandler(this.dpFrom_ValueChanged);
            // 
            // dpTo
            // 
            this.dpTo.CustomFormat = "dd/MM/yyyy";
            this.dpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpTo.Location = new System.Drawing.Point(650, 18);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(113, 26);
            this.dpTo.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Đến ngày : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Từ ngày : ";
            // 
            // gcHoaDon
            // 
            this.gcHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcHoaDon.Location = new System.Drawing.Point(0, 0);
            this.gcHoaDon.MainView = this.dgvHoaDon;
            this.gcHoaDon.Name = "gcHoaDon";
            this.gcHoaDon.Size = new System.Drawing.Size(1068, 598);
            this.gcHoaDon.TabIndex = 23;
            this.gcHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvHoaDon});
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHD,
            this.MaDP,
            this.Ngay,
            this.TienPH,
            this.TienDV,
            this.TongTien,
            this.MaNV});
            this.dgvHoaDon.GridControl = this.gcHoaDon;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.OptionsView.ShowGroupPanel = false;
            // 
            // MaHD
            // 
            this.MaHD.Caption = "Mã hoá đơn";
            this.MaHD.FieldName = "MaHD";
            this.MaHD.Name = "MaHD";
            this.MaHD.Visible = true;
            this.MaHD.VisibleIndex = 0;
            this.MaHD.Width = 86;
            // 
            // MaDP
            // 
            this.MaDP.Caption = "Mã đặt phòng";
            this.MaDP.FieldName = "MaDP";
            this.MaDP.Name = "MaDP";
            this.MaDP.Visible = true;
            this.MaDP.VisibleIndex = 1;
            this.MaDP.Width = 97;
            // 
            // Ngay
            // 
            this.Ngay.Caption = "Ngày";
            this.Ngay.FieldName = "NgayTT";
            this.Ngay.Name = "Ngay";
            this.Ngay.Visible = true;
            this.Ngay.VisibleIndex = 2;
            this.Ngay.Width = 193;
            // 
            // TienPH
            // 
            this.TienPH.Caption = "Tiền phòng";
            this.TienPH.DisplayFormat.FormatString = "#,### vnđ";
            this.TienPH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienPH.FieldName = "TienPhong";
            this.TienPH.Name = "TienPH";
            this.TienPH.Visible = true;
            this.TienPH.VisibleIndex = 3;
            this.TienPH.Width = 220;
            // 
            // TienDV
            // 
            this.TienDV.Caption = "Tiền dịch vụ";
            this.TienDV.DisplayFormat.FormatString = "#,### vnđ";
            this.TienDV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TienDV.FieldName = "TienDichVu";
            this.TienDV.Name = "TienDV";
            this.TienDV.Visible = true;
            this.TienDV.VisibleIndex = 4;
            this.TienDV.Width = 229;
            // 
            // TongTien
            // 
            this.TongTien.Caption = "Tổng tiển ";
            this.TongTien.DisplayFormat.FormatString = "#,### vnđ";
            this.TongTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TongTien.FieldName = "TongTien";
            this.TongTien.Name = "TongTien";
            this.TongTien.Visible = true;
            this.TongTien.VisibleIndex = 5;
            this.TongTien.Width = 218;
            // 
            // MaNV
            // 
            this.MaNV.Caption = "Mã nhân viên";
            this.MaNV.FieldName = "MaNV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 105;
            // 
            // tabCTHoaDon
            // 
            this.tabCTHoaDon.Location = new System.Drawing.Point(4, 22);
            this.tabCTHoaDon.Name = "tabCTHoaDon";
            this.tabCTHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabCTHoaDon.Size = new System.Drawing.Size(1074, 682);
            this.tabCTHoaDon.TabIndex = 1;
            this.tabCTHoaDon.Text = "Chi tiết hoá đơn";
            this.tabCTHoaDon.UseVisualStyleBackColor = true;
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 748);
            this.Controls.Add(this.tabHoaDon);
            this.Controls.Add(this.bnHoaDon);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnHoaDon)).EndInit();
            this.bnHoaDon.ResumeLayout(false);
            this.bnHoaDon.PerformLayout();
            this.tabHoaDon.ResumeLayout(false);
            this.tabDSHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnHoaDon;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.ToolStripTextBox txtTim;
        private System.Windows.Forms.ToolStripButton btnTim;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnIn;
        private System.Windows.Forms.TabControl tabHoaDon;
        private System.Windows.Forms.TabPage tabDSHoaDon;
        private System.Windows.Forms.TabPage tabCTHoaDon;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.DateTimePicker dpFrom;
        private System.Windows.Forms.DateTimePicker dpTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gcHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn MaHD;
        private DevExpress.XtraGrid.Columns.GridColumn MaDP;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn TienPH;
        private DevExpress.XtraGrid.Columns.GridColumn TienDV;
        private DevExpress.XtraGrid.Columns.GridColumn TongTien;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
    }
}