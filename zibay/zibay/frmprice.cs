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
    public partial class frmprice : Form
    {
        zibayEntities data = new zibayEntities();
        public frmprice()
        {
            InitializeComponent();
        }

        private void frmprice_Load(object sender, EventArgs e)
        {
            grdlist.DataSource = data.froshes.ToList();
        }

        private void btnsbt_Click(object sender, EventArgs e)
        {
            frmsbtprice frm_sbtp = new frmsbtprice();
            frm_sbtp.ShowDialog();
            grdlist.DataSource = data.froshes.ToList();
        }

        private void txtserch_TextChanged(object sender, EventArgs e)
        {
            var qury = (from tr in data.froshes where tr.id_costumer.ToString().Contains(txtserch.Text) select tr);
            grdlist.DataSource = qury.ToList();
        }
    }
}
