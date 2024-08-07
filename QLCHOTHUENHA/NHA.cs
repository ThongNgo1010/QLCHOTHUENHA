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
            if (rdRoi.Checked == false)
                rdRoi.Checked = true;
            txtMaNha.Enabled = true;

            load_DSNha();
        }

        private void Xoa(object sender, EventArgs e)
        {
            Data_Provider.moKetNoi();
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                string maNha = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string sql = string.Format("Delete from NHA where MaNha ='{0}'", maNha);
                Data_Provider.updateData(sql);
                load_DSNha();
            }
            Data_Provider.dongKetNoi();
        }

        private void Sua(object sender, EventArgs e)
        {
            Data_Provider.moKetNoi();
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đổi thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(txtTenChuNha.Text) && ktraSo(txtGiaChoThue.Text))
                {
                    string sql = string.Format("update NHA set MaNha=@mn, TenChuNha=@tcn, GiaThue=@gt, DaCHoThue=@dct where MaNha = '{0}'", txtMaNha.Text);
                    bool dct = rdRoi.Checked == true ? true : false;
                    object[] value = { txtMaNha.Text, txtTenChuNha.Text, float.Parse(txtGiaChoThue.Text), dct };
                    string[] name = { "@mn", "@tcn", "@gt", "@dct" };

                    Data_Provider.updateData(sql, value, name);
                    load_DSNha();
                }
                else
                    MessageBox.Show("Không hợp lệ!");
            }
            Data_Provider.dongKetNoi();
        }

        private void Them(object sender, EventArgs e)
        {
            Data_Provider.moKetNoi();
            string sql1 = string.Format("select count (*) from NHA where MaNha='{0}'", txtMaNha.Text);
            if (Data_Provider.checkData(sql1) == 0 && !string.IsNullOrEmpty(txtTenChuNha.Text) && ktraSo(txtGiaChoThue.Text))
            {
                string sql = "insert into NHA(MaNha, TenChuNha, GiaThue, DaCHoThue)" +
                    "values(@mn, @tcn, @gt, @dct)";
                bool dct = rdRoi.Checked == true ? true : false;
                object[] value = { txtMaNha.Text, txtTenChuNha.Text, float.Parse(txtGiaChoThue.Text), dct };
                string[] name = { "@mn", "@tcn", "@gt", "@dct" };

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
            dataGridView1.DataSource = Data_Provider.getTable(sql);
        }
        #endregion //load danh sách Nhà
        private void Load_nha(object sender, EventArgs e)
        {
            Data_Provider.moKetNoi();
            load_DSNha();
            Data_Provider.dongKetNoi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            txtMaNha.Enabled = false;

            txtMaNha.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenChuNha.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtGiaChoThue.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            string dct = dataGridView1.Rows[i].Cells[3].Value.ToString();
            if(dct == "True")
            {
                rdRoi.Checked = true;
            }    
            else
                rdChua.Checked = true;
        }
    }
}
