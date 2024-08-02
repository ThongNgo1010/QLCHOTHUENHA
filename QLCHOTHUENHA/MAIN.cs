using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHOTHUENHA
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNha_Click(object sender, EventArgs e)
        {
            frmNha f1 = new frmNha();
            f1.Show();
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            frmHopDong f2 = new frmHopDong();
            f2.Show();
        }
    }
}
