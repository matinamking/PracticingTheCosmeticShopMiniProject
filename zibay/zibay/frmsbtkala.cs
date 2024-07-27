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
    public partial class frmsbtkala : Form
    {
        zibayEntities data = new zibayEntities();
        public frmsbtkala()
        {
            InitializeComponent();
        }

        private void btnsbt_Click(object sender, EventArgs e)
        {
            if (txtcodkala.Text == "" || txtdatee.Text == "" || txtmark.Text == "" || txtmony.Text == ""||txtnamekala.Text=="")
            {
                MessageBox.Show("لطفا تمامی اطلاعات را بدرستی وارد کنید");
            }
            else
            {
                kala username = new kala();
                username.name_kala = txtnamekala.Text;
                username.date_e = txtdatee.Text;
                username.mony = txtmony.Text;
                username.mark = txtmark.Text;
                username.code_kala =Convert.ToInt32( txtcodkala.Text);
                

                data.kalas.Add(username);
                data.SaveChanges();

                MessageBox.Show("ثبت با موفقیت انجام شد");

            }
        }
    }
}
