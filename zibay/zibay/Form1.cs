using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zibay
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnkala_Click(object sender, EventArgs e)
        {
            frmkala frm_kala = new frmkala();
            frm_kala.ShowDialog();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            frmcustomer frm_customer = new frmcustomer();
            frm_customer.ShowDialog();
        }

        private void btnfactor_Click(object sender, EventArgs e)
        {
            frmfactor frm_factor = new frmfactor();
            frm_factor.ShowDialog();
        }

        private void btnsbtkharid_Click(object sender, EventArgs e)
        {
            frmprice frm_price = new frmprice();
            frm_price.ShowDialog();
        }
    }
}
