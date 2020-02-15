using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TTN_QLTV
{
    public partial class frmDangNhap : Form
    {

        string Strcon = @"Data Source=NGABUI\SQLEXPRESS01;Initial Catalog=QLTV_LOAN;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
        }

        private void btthoat_Click(object sender, EventArgs e)
        {

        }

        private void ckhienthi_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
