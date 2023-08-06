namespace GUI_QLKS
{
    partial class FrmNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtChucvu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbmessage = new System.Windows.Forms.Label();
            this.cboPhai = new System.Windows.Forms.ComboBox();
            this.bnNhanVien = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.dgvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.bnNhanVien)).BeginInit();
            this.bnNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NV : ";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(213, 76);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(77, 30);
            this.txtMaNV.TabIndex = 2;
            // 
            // txtChucvu
            // 
            this.txtChucvu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucvu.Location = new System.Drawing.Point(213, 115);
            this.txtChucvu.Margin = new System.Windows.Forms.Padding(4);
            this.txtChucvu.Name = "txtChucvu";
            this.txtChucvu.Size = new System.Drawing.Size(132, 30);
            this.txtChucvu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chức vụ : ";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(484, 119);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(188, 30);
            this.txtDiachi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Địa chỉ : ";
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(484, 76);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(220, 30);
            this.txtHoten.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Họ tên : ";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(1099, 119);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(141, 30);
            this.txtSDT.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1029, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "SĐT : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(757, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phái : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(987, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ngày sinh : ";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(1101, 70);
            this.dtpNgaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(139, 30);
            this.dtpNgaysinh.TabIndex = 14;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(827, 119);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(160, 30);
            this.txtCMND.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(740, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "CMND : ";
            // 
            // lbmessage
            // 
            this.lbmessage.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmessage.ForeColor = System.Drawing.Color.Red;
            this.lbmessage.Location = new System.Drawing.Point(113, 166);
            this.lbmessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmessage.Name = "lbmessage";
            this.lbmessage.Size = new System.Drawing.Size(339, 25);
            this.lbmessage.TabIndex = 19;
            this.lbmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboPhai
            // 
            this.cboPhai.FormattingEnabled = true;
            this.cboPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboPhai.Location = new System.Drawing.Point(828, 76);
            this.cboPhai.Margin = new System.Windows.Forms.Padding(4);
            this.cboPhai.Name = "cboPhai";
            this.cboPhai.Size = new System.Drawing.Size(111, 24);
            this.cboPhai.TabIndex = 21;
            // 
            // bnNhanVien
            // 
            this.bnNhanVien.AddNewItem = null;
            this.bnNhanVien.CountItem = this.bindingNavigatorCountItem;
            this.bnNhanVien.DeleteItem = null;
            this.bnNhanVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnNhanVien.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnNhanVien.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnNhanVien.Location = new System.Drawing.Point(0, 0);
            this.bnNhanVien.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnNhanVien.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnNhanVien.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnNhanVien.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnNhanVien.Name = "bnNhanVien";
            this.bnNhanVien.PositionItem = this.bindingNavigatorPositionItem;
            this.bnNhanVien.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bnNhanVien.Size = new System.Drawing.Size(1359, 50);
            this.bnNhanVien.TabIndex = 24;
            this.bnNhanVien.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
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
            this.btnLuu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI_QLKS.Properties.Resources.trash;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(43, 47);
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::GUI_QLKS.Properties.Resources.writing;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(42, 47);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::GUI_QLKS.Properties.Resources.forbidden;
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(44, 47);
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTim
            // 
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(132, 50);
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
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
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // gcNhanVien
            // 
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcNhanVien.Location = new System.Drawing.Point(2, 28);
            this.gcNhanVien.MainView = this.dgvNhanVien;
            this.gcNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1355, 473);
            this.gcNhanVien.TabIndex = 25;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvNhanVien});
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.dgvNhanVien.DetailHeight = 437;
            this.dgvNhanVien.GridControl = this.gcNhanVien;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã NV";
            this.gridColumn1.FieldName = "MaNV";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên NV";
            this.gridColumn2.FieldName = "HotenNV";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giới tính";
            this.gridColumn3.FieldName = "Phai";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ngày sinh";
            this.gridColumn4.FieldName = "NgaySinh";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Chức vụ";
            this.gridColumn5.FieldName = "ChucVu";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Địa chỉ";
            this.gridColumn6.FieldName = "DiaChi";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "CMND";
            this.gridColumn7.FieldName = "CMND";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 94;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "SĐT";
            this.gridColumn8.FieldName = "SDT";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 94;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gcNhanVien);
            this.groupControl1.Location = new System.Drawing.Point(0, 194);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1359, 503);
            this.groupControl1.TabIndex = 26;
            this.groupControl1.Text = "Danh sách nhân viên";
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 697);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.bnNhanVien);
            this.Controls.Add(this.cboPhai);
            this.Controls.Add(this.lbmessage);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtChucvu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnNhanVien)).EndInit();
            this.bnNhanVien.ResumeLayout(false);
            this.bnNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtChucvu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbmessage;
        private System.Windows.Forms.ComboBox cboPhai;
        private System.Windows.Forms.BindingNavigator bnNhanVien;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}