using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Formlar;

namespace is_takip_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDepartmanlar frm = new FrmDepartmanlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersoneller frm2 = new FrmPersoneller();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void BtnPersonelİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPersonelİstatistik frm3 = new FrmPersonelİstatistik();
            frm3.MdiParent = this;
            frm3.Show();
        }
        FrmGorevListesi frm4; 
        private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4==null || frm4.IsDisposed)
            {
                frm4 = new FrmGorevListesi();
                frm4.MdiParent = this;
                frm4.Show();
            }
         
        }

        private void BtnGorevTanımla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGorev frm5 = new FrmGorev();
            frm5.Show();
      
        }

        private void BtnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGorevDetay frm6 = new FrmGorevDetay();
            frm6.Show();
        }
       FrmAnaForm frm7;
        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {
                frm7 = new FrmAnaForm();
                frm7.MdiParent = this;
                frm7.Show();
            }
        }
        FrmAktifCagrilar frm8;
        private void BrnAktifCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm8 == null || frm8.IsDisposed)
            {
                frm8 = new FrmAktifCagrilar();
                frm8.MdiParent = this;
                frm8.Show();
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        
        }
    }
}
