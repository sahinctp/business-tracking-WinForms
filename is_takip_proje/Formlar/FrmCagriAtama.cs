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

namespace is_takip_proje.Formlar
{
    public partial class FrmCagriAtama : Form
    {
        public FrmCagriAtama()
        {
            InitializeComponent();
        }
        public int id;
        DbisTakipEntities db = new DbisTakipEntities();
        private void FrmCagriAtama_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TblPersonel
                            select new
                            {
                                x.ID,
                                AdSoyad = x.Ad + " " + x.Soyad
                            }


                              ).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = degerler;




            TxtCagriID.Text = id.ToString();
            var gelenveri = db.TblCagrilar.Find(id);
            TxtAciklama.Text = gelenveri.Aciklama;
            TxtTarih.Text = gelenveri.Tarih.ToString();
            TxtKonu.Text = gelenveri.Konu;

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            var gelenveri = db.TblCagrilar.Find(id);
            gelenveri.Konu = TxtKonu.Text;
            gelenveri.Tarih = Convert.ToDateTime(TxtTarih.Text);
            gelenveri.Aciklama = TxtAciklama.Text;
            gelenveri.CagriPersonel = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
        }
    }
}
