using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.PersonelGorev
{
    public partial class FrmPersonelFormu : Form
    {
        public FrmPersonelFormu()
        {
            InitializeComponent();
        }
        public string mail;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAktifGorevler frm = new FrmAktifGorevler();
            frm.MdiParent = this;
            frm.mail2 = mail;
            frm.Show();
        }

        private void BtnPasifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPasifGorevler frm = new FrmPasifGorevler();
            frm.mail2 = mail;
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnCagriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCagriListesi frm = new FrmCagriListesi();
            frm.mail2 = mail;
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmPersonelFormu_Load(object sender, EventArgs e)
        {

        }
    }

    }

