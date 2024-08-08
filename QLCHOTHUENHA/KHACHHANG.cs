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
    public partial class frmKhachThue : Form
    {
        public frmKhachThue()
        {
            InitializeComponent();
            Load += new EventHandler(Load_Form);
            btnThem.Click += new EventHandler(Them);
            btnSua.Click += new EventHandler(Sua);
            btnLamMoi.Click += new EventHandler(LamMoi);
            btnTim.Click += new EventHandler(Tim);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(DataCell_Click);
        }

        private void DataCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Tim(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LamMoi(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Sua(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Them(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Load_Form(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
