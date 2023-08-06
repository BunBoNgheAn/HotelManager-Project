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

namespace GUI_QLKS
{
    public partial class FrmLogin : Form
    {
        int solan = 3;
        BUS_Login busLog = new BUS_Login();
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Nhập User!");
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Nhập Pass!");
            }
            else
            {
                if (busLog.login(txtUser.Text, txtPass.Text) == true)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    
                    FrmMain main = new FrmMain();
                    main.ShowDialog();
                    this.Close();
                }
                else if (solan == 0)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!!\nBạn còn " + solan.ToString() + " lần đăng nhập lại!");
                    --solan;
                }
            }
        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = BtnShow.Checked ? '\0' : '*';
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }
    }
}
