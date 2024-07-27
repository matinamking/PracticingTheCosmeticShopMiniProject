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
    public partial class frmcustomer : Form
    {
        zibayEntities data = new zibayEntities();
        public frmcustomer()
        {
            InitializeComponent();
        }

        private void frmcustomer_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = data.customers.ToList();
        }

        private void btnsbtcustomer_Click(object sender, EventArgs e)
        {
            frmsbtcustomer frm_sbtc =new frmsbtcustomer();
            frm_sbtc.ShowDialog();
            grdlist.DataSource = data.customers.ToList();
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            var qury = (from tr in data.customers where tr.name.Contains(txtserch.Text) select tr);
            grdlist.DataSource = qury.ToList();
        }
    }
}
