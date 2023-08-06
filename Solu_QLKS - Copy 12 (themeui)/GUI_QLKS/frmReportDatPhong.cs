using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLKS
{
    public partial class frmReportDatPhong : Form
    {
        rpHDDP hddatphong = new rpHDDP();
        public frmReportDatPhong()
        {
            InitializeComponent();
        }

        private void frmReportDatPhong_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = hddatphong;
        }
    }
}
