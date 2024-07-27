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
    public partial class frmkala : Form
    {
        zibayEntities data = new zibayEntities();
        public frmkala()
        {
            InitializeComponent();
        }

        private void btnsbtkala_Click(object sender, EventArgs e)
        {
            frmsbtkala frm_sbtk = new frmsbtkala();
            frm_sbtk.ShowDialog();
            grdlist.DataSource = data.kalas.ToList();
        }

        private void frmkala_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = data.kalas.ToList();
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            var qury = (from tr in data.kalas where tr.name_kala.Contains(txtserch.Text) select tr);
            grdlist.DataSource = qury.ToList();
        }
    }
}
