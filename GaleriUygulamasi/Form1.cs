using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG Resimler (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG Resimler(*.png)|*.png|Tüm Dosyalar(*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.FilterIndex=3;
            ofd.Title = "Resimleri Seç";
            ofd.Multiselect = true;
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (ofd.ShowDialog()==DialogResult.OK)
            {
                string[] dosyaKonumlari = ofd.FileNames;
                foreach (var dosyaKonum in dosyaKonumlari)
                {
                    PictureBoxEkle(dosyaKonum);
                }
            }

        }

        private void PictureBoxEkle(string dosyaKonum) 
        {
            Panel pnl = new Panel();
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.Width = 75;
            pnl.Height = 75;

            PictureBox pb = new PictureBox();

            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.ImageLocation = dosyaKonum;
            pb.Dock = DockStyle.Fill;

            pb.Click += Pb_Click;//pb her tıklanıdıgında bıze verı versın dıye yapıldı.

            pnl.Controls.Add(pb);
            flowLayoutPanel1.Controls.Add(pnl);
            
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pbBox =  (PictureBox)sender;

            Form frm = new Form();
            frm.Text = "Resim Önizleme";
            frm.Width = 150;
            frm.Height = 150;

            PictureBox pbNew = new PictureBox();
            pbNew.ImageLocation = pbBox.ImageLocation;
            pbNew.SizeMode = pbBox.SizeMode;
            pbNew.Dock = DockStyle.Fill;
            frm.Controls.Add(pbNew);
            frm.Show();
        }

        private void MenuKaydet_Click(object sender, EventArgs e)
        {
            List<string> kaydedilecekdosyaKonumlari = new List<string>();
            foreach (Panel pnl in flowLayoutPanel1.Controls)
            {
                PictureBox pbox = (PictureBox)pnl.Controls[0];
                kaydedilecekdosyaKonumlari.Add(pbox.ImageLocation);
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Galeri Kaydet";
            sfd.Filter = "Galeri Dosyaları(*.glr)|*.glr";
            sfd.FilterIndex = 1;
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                System.IO.File.WriteAllLines(sfd.FileName, kaydedilecekdosyaKonumlari);
                MessageBox.Show("Galeriye kaydedilmiştir. ");
            }


        }

        private void MenuAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Galeri Kaydet";
            ofd.Filter = "Galeri Dosyaları(*.glr)|*.glr";
            ofd.FilterIndex = 1;
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                string[] dosyalar = System.IO.File.ReadAllLines(ofd.FileName);
                foreach (string dosyaKonum in dosyalar)
                {
                    PictureBoxEkle(dosyaKonum);
                }
            }
        }

        private void MenuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
