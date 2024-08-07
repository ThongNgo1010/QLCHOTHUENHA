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
    public partial class frmHopDong : Form
    {
        public frmHopDong()
        {
            InitializeComponent();
            Load += new EventHandler(Load_HopDong);
        }

        private void Load_HopDong(object sender, EventArgs e)
        {
            string sql = "select A.MaNha, A.TenChuNha, A.GiaThue, A.DaCHoThue" +
                "from NHA as A, HOPDONG as B, KHACHTHUENHA as C" +
                "where A.MaNha=B.MaNha, C.MaKhach=B.MaKhach";
        }
    }
}
