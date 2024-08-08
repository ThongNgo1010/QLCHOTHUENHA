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
            //thanhTien = soThangThue * giaThue
            string sql = @"select B.SoHD, A.TenChuNha, C.TenKhach, B.NgayBatDau, B.NgayKetThuc, DATEDIFF(month,B.NgayBatDau,B.NgayKetThuc)*A.GiaThue as ThanhTien" +
                " from NHA as A, HOPDONG as B, KHACHTHUENHA as C" +
                " where A.MaNha=B.MaNha and C.MaKhach=B.MaKhach";
                
            Data_Provider.moKetNoi();
            dataGridView1.DataSource = Data_Provider.getTable(sql);
            label1.Text = "Gía hợp đồng cao nhất: " + string.Format("{0:0,0vnđ}", hopDongMax());
            Data_Provider.dongKetNoi();
        }

        public float hopDongMax()
        {
            float max = 0.0f;
            float giaHD = 0.0f; 
            DataTable dt = (DataTable)dataGridView1.DataSource;
            foreach (DataRow row in dt.Rows)
            {
                giaHD = float.Parse(row[5].ToString());
                if (giaHD > max)
                {
                    max = giaHD;
                }
            }
            return max;
        }
    }
}
