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
namespace GUI_QLKS
{
    public partial class FrmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        BUS_HoaDon busHD = new BUS_HoaDon();
        BindingSource bs = new BindingSource();
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        void loadHD()
        {
            gcHoaDon.DataSource = busHD. getHoaDon(dpFrom.Value, dpTo.Value);
            bnHoaDon.BindingSource = bs;
        }
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void dpFrom_ValueChanged(object sender, EventArgs e)
        {
            loadHD();
        }
    }
}