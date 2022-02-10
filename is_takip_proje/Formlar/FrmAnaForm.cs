using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;
namespace is_takip_proje.Formlar
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblGorevler
                                       select new
                                       {
                                           x.Aciklama,
                                           Personel = x.TblPersonel.Ad + " " + x.TblPersonel.Soyad,
                                           x.Durum


                                       }).Where(p => p.Durum == "1").ToList();
            gridView1.Columns["Durum"].Visible = false;



            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            gridControl2.DataSource = (from x in db.TblGorevDetaylar
                                       select new
                                       {

                                           Görev = x.TblGorevler.Aciklama,
                                           x.Aciklama,
                                           x.Tarih

                                       }).Where(p => p.Tarih == bugun).ToList();


            gridControl3.DataSource = (from x in db.TblCagrilar
                                       select new
                                       {
                                           x.TblFirmalar.Ad,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum
                                       }).Where(p => p.Durum == true).ToList();
            gridView3.Columns["Durum"].Visible = false;



            gridControl4.DataSource = (from x in db.TblFirmalar
                                       select new
                                       {
                                           x.Ad,
                                           x.Telefon,
                                           x.Mail

                                       }).ToList();



            int aktif_cagrilar = db.TblCagrilar.Where(p=>p.Durum==true).Count();
            int pasif_cagrilar = db.TblCagrilar.Where(p => p.Durum == false).Count();

            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Çağrılar",aktif_cagrilar);
            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Çağrılar",pasif_cagrilar);
        }
    }
}
