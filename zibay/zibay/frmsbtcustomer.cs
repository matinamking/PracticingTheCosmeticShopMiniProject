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
    public partial class frmsbtcustomer : Form
    {
        zibayEntities data = new zibayEntities();
        public frmsbtcustomer()
        {
            InitializeComponent();
        }

        private void btnsbt_Click(object sender, EventArgs e)
        {
            if (txtfamil.Text == "" || txtfhone.Text == "" || txtname.Text == "")
            {
                MessageBox.Show("لطفا تمامی اطلاعات را بدرستی وارد کنید");
            }
            else
            {
                customer username = new customer();
                username.family = txtfamil.Text;
                username.name = txtname.Text;
                username.fhone = txtfhone.Text;
                


                data.customers.Add(username);
                data.SaveChanges();

                MessageBox.Show("ثبت با موفقیت انجام شد");

            }
        }
    }
}
