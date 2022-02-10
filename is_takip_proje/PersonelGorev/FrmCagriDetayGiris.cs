using DevExpress.XtraEditors;
using is_takip_proje.Entity;
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
    public partial class FrmCagriDetayGiris : Form
    {
        public FrmCagriDetayGiris()
        {
            InitializeComponent();
        }
        public int id;
        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        private void FrmCagriDetayGiris_Load(object sender, EventArgs e)
        {
            TxtCagriID.Enabled = false;
            TxtCagriID.Text = id.ToString();
            string saat, tarih;
            tarih = DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToShortTimeString();
            TxtTarih.Text = tarih;
            TxtSaat.Text = saat;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblCagriDetay tbl = new TblCagriDetay();
            tbl.Cagri = int.Parse(TxtCagriID.Text);
            tbl.Saat = TxtSaat.Text;
            tbl.Tarih = DateTime.Parse(TxtTarih.Text);
            tbl.Aciklama = TxtAciklama.Text;
            db.TblCagriDetay.Add(tbl);
            db.SaveChanges();
            XtraMessageBox.Show("Çağrı Detayı Sisteme Başarılı Bir Şekilde Kaydedildi");
        }
    }
}
