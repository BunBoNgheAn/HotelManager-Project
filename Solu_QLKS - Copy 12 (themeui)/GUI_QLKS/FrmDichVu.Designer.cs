namespace GUI_QLKS
{
    partial class FrmDichVu
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
            this.lbmessage = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bnDichVu = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cboLoaiDV = new System.Windows.Forms.ComboBox();
            this.gcDichVu = new DevExpress.XtraGrid.GridControl();
            this.dgvDichVu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.bnDichVu)).BeginInit();
            this.bnDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbmessage
            // 
            this.lbmessage.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmessage.ForeColor = System.Drawing.Color.Red;
            this.lbmessage.Location = new System.Drawing.Point(23, 129);
            this.lbmessage.Name = "lbmessage";
            this.lbmessage.Size = new System.Drawing.Size(254, 20);
            this.lbmessage.TabIndex = 39;
            this.lbmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(682, 65);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(118, 26);
            this.txtDonGia.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Đơn giá : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Loại DV : ";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Location = new System.Drawing.Point(489, 61);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(101, 26);
            this.txtTenDV.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên DV :";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.Location = new System.Drawing.Point(110, 65);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(76, 26);
            this.txtMaDV.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã DV : ";
            // 
            // bnDichVu
            // 
            this.bnDichVu.AddNewItem = null;
            this.bnDichVu.CountItem = this.bindingNavigatorCountItem;
            this.bnDichVu.DeleteItem = null;
            this.bnDichVu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnDichVu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnDichVu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnDichVu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnHuy});
            this.bnDichVu.Location = new System.Drawing.Point(0, 0);
            this.bnDichVu.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnDichVu.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnDichVu.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnDichVu.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnDichVu.Name = "bnDichVu";
            this.bnDichVu.PositionItem = this.bindingNavigatorPositionItem;
            this.bnDichVu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bnDichVu.Size = new System.Drawing.Size(837, 44);
            this.bnDichVu.TabIndex = 22;
            this.bnDichVu.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 41);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Image = global::GUI_QLKS.Properties.Resources.next_left;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(35, 41);
            this.bindingNavigatorMoveFirstItem.Text = "Đầu";
            this.bindingNavigatorMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Image = global::GUI_QLKS.Properties.Resources.next_left1;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(45, 41);
            this.bindingNavigatorMovePreviousItem.Text = "Trước";
            this.bindingNavigatorMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 44);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.Image = global::GUI_QLKS.Properties.Resources.next_right1;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(33, 41);
            this.bindingNavigatorMoveNextItem.Text = "Sau";
            this.bindingNavigatorMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Image = global::GUI_QLKS.Properties.Resources.next_right;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(38, 41);
            this.bindingNavigatorMoveLastItem.Text = "Cuối";
            this.bindingNavigatorMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::GUI_QLKS.Properties.Resources.add__1_;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(44, 41);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::GUI_QLKS.Properties.Resources.check;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(33, 41);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI_QLKS.Properties.Resources.trash;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(35, 41);
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::GUI_QLKS.Properties.Resources.writing;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(34, 41);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::GUI_QLKS.Properties.Resources.forbidden;
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(34, 41);
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cboLoaiDV
            // 
            this.cboLoaiDV.FormattingEnabled = true;
            this.cboLoaiDV.Items.AddRange(new object[] {
            "Nước",
            "Đồ ăn",
            "Khác"});
            this.cboLoaiDV.Location = new System.Drawing.Point(303, 66);
            this.cboLoaiDV.Name = "cboLoaiDV";
            this.cboLoaiDV.Size = new System.Drawing.Size(74, 21);
            this.cboLoaiDV.TabIndex = 40;
            // 
            // gcDichVu
            // 
            this.gcDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDichVu.Location = new System.Drawing.Point(2, 23);
            this.gcDichVu.MainView = this.dgvDichVu;
            this.gcDichVu.Name = "gcDichVu";
            this.gcDichVu.Size = new System.Drawing.Size(833, 401);
            this.gcDichVu.TabIndex = 41;
            this.gcDichVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDichVu});
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.dgvDichVu.GridControl = this.gcDichVu;
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã DV";
            this.gridColumn1.FieldName = "MaDV";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên DV";
            this.gridColumn2.FieldName = "TenDV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Loại DV";
            this.gridColumn3.FieldName = "LoaiDV";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đơn giá";
            this.gridColumn4.FieldName = "DonGia";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gcDichVu);
            this.groupControl1.Location = new System.Drawing.Point(0, 129);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(837, 426);
            this.groupControl1.TabIndex = 42;
            this.groupControl1.Text = "Danh sách dịch vụ";
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 555);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cboLoaiDV);
            this.Controls.Add(this.lbmessage);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnDichVu);
            this.Name = "FrmDichVu";
            this.Text = "FrmDichVu";
            this.Load += new System.EventHandler(this.FrmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnDichVu)).EndInit();
            this.bnDichVu.ResumeLayout(false);
            this.bnDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmessage;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bnDichVu;
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
        private System.Windows.Forms.ComboBox cboLoaiDV;
        private DevExpress.XtraGrid.GridControl gcDichVu;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}