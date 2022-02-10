using DevExpress.XtraEditors;
using is_takip_proje.Entity;
using is_takip_proje.Formlar;
using is_takip_proje.PersonelGorev;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPersonelFormu frm = new FrmPersonelFormu();
            frm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        DbisTakipEntities db = new DbisTakipEntities();

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var adminvalue = db.TblAdmin.Where(x => x.Kullanici == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
            if (adminvalue!=null)
            {
                XtraMessageBox.Show("Hoşgeldiniz");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş ");
            }
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            var personel = db.TblPersonel.Where(x => x.Mail == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
            if (personel != null)
            {
                FrmPersonelFormu fr = new FrmPersonelFormu();
                fr.mail = TxtKullanici.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş ");
            }
        }
    }
}
