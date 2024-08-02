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
    public partial class frmNha : Form
    {
        public frmNha()
        {
            InitializeComponent();
            Load += new EventHandler(Load_nha);
            btnThem.Click += new EventHandler(Them);
            btnSua.Click += new EventHandler(Sua);
            btnXoa.Click += new EventHandler(Xoa);
            btnLamMoi.Click += new EventHandler(Lam_Moi);
        }

        private void Lam_Moi(object sender, EventArgs e)
        {
            txtMaNha.ResetText();
            txtTenChuNha.ResetText();
            txtGiaChoThue.ResetText();
            load_DSNha();
        }

        private void Xoa(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Sua(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Them(object sender, EventArgs e)
        {
            Data_Provider.moKetNoi();
            string sql1 = string.Format("select count (*) from NHA where MaNha='{0}'", txtMaNha.Text);
            if (Data_Provider.checkData(sql1) == 0 && !string.IsNullOrEmpty(txtTenChuNha.Text) && ktraSo(txtGiaChoThue.Text))
            {
                string sql = "insert into NHA(MaNha, TenChuNha, GiaThue, DaCHoThue " +
                    "value(@mn, @tcn, @gt, @dct)";
                bool dct = rdRoi.Checked = true ? true : false;
                object[] value = { txtMaNha.Text, txtTenChuNha.Text, txtGiaChoThue.Text, dct };
                string[] name = { "@mn", "@tcn", "@gct", "dct" };

                Data_Provider.updateData(sql, value, name);
                load_DSNha();
            }
            else
                MessageBox.Show("Không hợp lệ!");
            Data_Provider.dongKetNoi();
        }

        #region
        public bool ktraSo(string value)
        {
            bool ktra;
            float result;
            ktra = float.TryParse(value, out result);
            return ktra;
        }
        public void load_DSNha()
        {
            string sql = "select * from NHA";
            dataGridView1.DataSource = Data_Provider.getData(sql);
        }
        #endregion //load danh sách Nhà
        private void Load_nha(object sender, EventArgs e)
        {
            Data_Provider.moKetNoi();
            load_DSNha();
            Data_Provider.dongKetNoi();
        }
    }
}
