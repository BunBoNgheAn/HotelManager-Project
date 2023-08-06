
namespace GUI_QLKS
{
    partial class FrmPhong
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
            this.bnPhong = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.txtSoNg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcPhong = new DevExpress.XtraGrid.GridControl();
            this.dgvPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bnPhong)).BeginInit();
            this.bnPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // bnPhong
            // 
            this.bnPhong.AddNewItem = null;
            this.bnPhong.CountItem = this.bindingNavigatorCountItem;
            this.bnPhong.DeleteItem = null;
            this.bnPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnPhong.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnPhong.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnPhong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnPhong.Location = new System.Drawing.Point(0, 0);
            this.bnPhong.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnPhong.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnPhong.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnPhong.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnPhong.Name = "bnPhong";
            this.bnPhong.PositionItem = this.bindingNavigatorPositionItem;
            this.bnPhong.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bnPhong.Size = new System.Drawing.Size(1016, 50);
            this.bnPhong.TabIndex = 24;
            this.bnPhong.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 47);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Image = global::GUI_QLKS.Properties.Resources.next_left;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(45, 47);
            this.bindingNavigatorMoveFirstItem.Text = "Đầu";
            this.bindingNavigatorMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Image = global::GUI_QLKS.Properties.Resources.next_left1;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(56, 47);
            this.bindingNavigatorMovePreviousItem.Text = "Trước";
            this.bindingNavigatorMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.Image = global::GUI_QLKS.Properties.Resources.next_right1;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(42, 47);
            this.bindingNavigatorMoveNextItem.Text = "Sau";
            this.bindingNavigatorMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Image = global::GUI_QLKS.Properties.Resources.next_right;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(49, 47);
            this.bindingNavigatorMoveLastItem.Text = "Cuối";
            this.bindingNavigatorMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::GUI_QLKS.Properties.Resources.add__1_;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(57, 47);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::GUI_QLKS.Properties.Resources.check;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(42, 47);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI_QLKS.Properties.Resources.trash;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(43, 47);
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::GUI_QLKS.Properties.Resources.writing;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(42, 47);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::GUI_QLKS.Properties.Resources.forbidden;
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(44, 47);
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtTim
            // 
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(116, 50);
            // 
            // btnTim
            // 
            this.btnTim.Image = global::GUI_QLKS.Properties.Resources.search;
            this.btnTim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(42, 47);
            this.btnTim.Text = "Tìm";
            this.btnTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::GUI_QLKS.Properties.Resources.sync;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 47);
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnIn
            // 
            this.btnIn.Image = global::GUI_QLKS.Properties.Resources.printer;
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(29, 47);
            this.btnIn.Text = "In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtSoNg
            // 
            this.txtSoNg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNg.Location = new System.Drawing.Point(513, 98);
            this.txtSoNg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoNg.Name = "txtSoNg";
            this.txtSoNg.Size = new System.Drawing.Size(77, 30);
            this.txtSoNg.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 24);
            this.label7.TabIndex = 64;
            this.label7.Text = "Số người tối đa : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(619, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 61;
            this.label6.Text = "Tình trạng : ";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiPhong.Location = new System.Drawing.Point(231, 100);
            this.txtLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(118, 30);
            this.txtLoaiPhong.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 59;
            this.label3.Text = "Loại phòng : ";
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaPhong.Location = new System.Drawing.Point(450, 62);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(140, 30);
            this.txtGiaPhong.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "Giá : ";
            // 
            // txtMaPH
            // 
            this.txtMaPH.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPH.Location = new System.Drawing.Point(231, 64);
            this.txtMaPH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPH.Name = "txtMaPH";
            this.txtMaPH.Size = new System.Drawing.Size(68, 30);
            this.txtMaPH.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "Mã PH : ";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gcPhong);
            this.groupControl1.Location = new System.Drawing.Point(0, 158);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1016, 390);
            this.groupControl1.TabIndex = 67;
            this.groupControl1.Text = "Danh sách phòng";
            // 
            // gcPhong
            // 
            this.gcPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPhong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcPhong.Location = new System.Drawing.Point(2, 28);
            this.gcPhong.MainView = this.dgvPhong;
            this.gcPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcPhong.Name = "gcPhong";
            this.gcPhong.Size = new System.Drawing.Size(1012, 360);
            this.gcPhong.TabIndex = 0;
            this.gcPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvPhong});
            // 
            // dgvPhong
            // 
            this.dgvPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.dgvPhong.GridControl = this.gcPhong;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã phòng";
            this.gridColumn1.FieldName = "MaPH";
            this.gridColumn1.MinWidth = 24;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Loại phòng";
            this.gridColumn2.FieldName = "LoaiPhong";
            this.gridColumn2.MinWidth = 24;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số người ";
            this.gridColumn3.FieldName = "SoNgToiDa";
            this.gridColumn3.MinWidth = 24;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Giá ";
            this.gridColumn4.DisplayFormat.FormatString = "#,### vnđ";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "GiaPhong";
            this.gridColumn4.MinWidth = 24;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tình trạng";
            this.gridColumn5.FieldName = "TinhTrang";
            this.gridColumn5.MinWidth = 24;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.Location = new System.Drawing.Point(724, 62);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(121, 30);
            this.txtTinhTrang.TabIndex = 68;
            // 
            // FrmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 548);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtSoNg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGiaPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaPH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnPhong);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPhong";
            this.Text = "FrmPhong";
            this.Load += new System.EventHandler(this.FrmPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnPhong)).EndInit();
            this.bnPhong.ResumeLayout(false);
            this.bnPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnPhong;
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
        private System.Windows.Forms.TextBox txtSoNg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPH;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvPhong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.TextBox txtTinhTrang;
    }
}