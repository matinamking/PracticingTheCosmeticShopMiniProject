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
    public partial class frmsbtprice : Form
    {
        
        zibayEntities data = new zibayEntities();
        public frmsbtprice()
        {
            InitializeComponent();
        }

        private void frmsbtprice_Load(object sender, EventArgs e)
        {
            grdlistcustomer.DataSource = data.customers.ToList();
            grdlistkala.DataSource = data.kalas.ToList();
        }

        private void btnsbt_Click(object sender, EventArgs e)
        {
            if (txtdate.Text == "" || txtidcustomer.Text == "" || txtidkala.Text == "")
            {
                MessageBox.Show("لطفا تمامی اطلاعات را بدرستی وارد کنید");
            }
            else
            {
                frosh username = new frosh();
                username.date_frokhte = txtdate.Text;
                username.id_costumer =Convert.ToInt32( txtidcustomer.Text);
                username.id_kala = Convert.ToInt32(txtidkala.Text);


                data.froshes.Add(username);
                data.SaveChanges();

                MessageBox.Show("ثبت با موفقیت انجام شد");

            }
        }
    }
}
