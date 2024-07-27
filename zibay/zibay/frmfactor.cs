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

    public partial class frmfactor : Form
    {
        zibayEntities data = new zibayEntities();
        public frmfactor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q = from b in data.customers
                    join a in data.froshes
                    on b.ID equals a.id_costumer
                    select new { b.name, b.family, b.fhone, a.id_kala, a.date_frokhte };
            grdlist.DataSource = q.ToList();
        }
    }
}
