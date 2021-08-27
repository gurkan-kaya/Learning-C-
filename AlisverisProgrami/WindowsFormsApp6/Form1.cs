/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3. Ödev
**				ÖĞRENCİ ADI............: Gürkan KAYA
**				ÖĞRENCİ NUMARASI.......: G181210102
**              DERSİN ALINDIĞI GRUP...: 2D
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public LedTV tv = new LedTV("Televizyon", "samsung", "ledtv", "4k", 4000, 0, 167, 2440);
        public CepTel ct = new CepTel("Telefon", "ıphone", "x", "5g", 2500 , 0, 128, 4, 3600);
        public Laptop lpt = new Laptop("Bilgisayar","acer","nitro5","ssd",5000,0,16,1080,1512,8,3580);
        public Buzdolabi bzd = new Buzdolabi("Buzdolabı","arçelik","270560EL","no frost",3500,0,560,"A++");
        Urun urn = new Urun();
        public Form1()
        {          
            InitializeComponent();
            Random rnd = new Random();
          
            //Rastgele stok adedi atamaları
            label13.Text = tv.HamFiyat.ToString();
            tv.StokAdedi = rnd.Next(1, 100);
            label14.Text = tv.StokAdedi.ToString();
      
            label20.Text = ct.HamFiyat.ToString();
            ct.StokAdedi = rnd.Next(1, 100);
            label19.Text = ct.StokAdedi.ToString();

            label17.Text = lpt.HamFiyat.ToString();
            lpt.StokAdedi = rnd.Next(1, 100);
            label18.Text = lpt.StokAdedi.ToString();
 
            label15.Text = bzd.HamFiyat.ToString();
            bzd.StokAdedi = rnd.Next(1, 100);
            label16.Text = bzd.StokAdedi.ToString();

            //Stok adetlerinin numericUpDown'lara maximum değer olarak atanması
            numericUpDown1.Maximum = int.Parse(label14.Text);
            numericUpDown2.Maximum = int.Parse(label18.Text);
            numericUpDown3.Maximum = int.Parse(label16.Text);
            numericUpDown4.Maximum = int.Parse(label19.Text);
                  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Bu if koşulu ödev dökümanındaki "Sepete ekle butonuna tıklayınca eğer sepet doluysa
             önce sepet temizlenip ürünler sepete öyle eklenmelidir" cümlesine istinaden yazıldı. */
            if ((label14.Text != tv.StokAdedi.ToString()) || (label16.Text != bzd.StokAdedi.ToString()) ||
                (label18.Text != lpt.StokAdedi.ToString()) || (label19.Text != ct.StokAdedi.ToString()))
            {     
                  MessageBox.Show("Yeni hesaplama için önce sepeti temizle butonuna basınız", "Uyarı");
            }
            else
            { 
            Sepet spt = new Sepet();
            spt.SepeteUrunEkle(urn);
            spt.KdvUygula();
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label14.Text = tv.StokAdedi.ToString();
            label19.Text = ct.StokAdedi.ToString();
            label18.Text = lpt.StokAdedi.ToString();
            label16.Text = bzd.StokAdedi.ToString();
            label25.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
        }
        
    }


    public class Urun
    {
        public string Ad;
        public string Marka;
        public string Model;
        public string Ozellik;
        public int StokAdedi;
        public int HamFiyat;
        public int SecilenAdet;
    }

    public class Buzdolabi : Urun
    {

        int IcHacim;
        string EnerjiSinifi;
        public Buzdolabi(string a, string ma, string mo, string oz, int hf, int sa, int ih, string es)
        {
            Ad = a;
            Marka = ma;
            Model = mo;
            Ozellik = oz;
            HamFiyat = hf;
            SecilenAdet = sa;
            IcHacim = ih;
            EnerjiSinifi = es;
        }
    }

    public class LedTV : Urun
    {
        int EkranBoyutu;
        int EkranCozunurlugu;
        public LedTV(string a, string ma, string mo, string oz, int hf, int sa, int eb, int ec)
        {
            Ad = a;
            Marka = ma;
            Model = mo;
            Ozellik = oz;
            HamFiyat = hf;
            SecilenAdet = sa;
            EkranBoyutu = eb;
            EkranCozunurlugu = ec;
        }

    }

    public class CepTel : Urun
    {
        int DahiliHafiza;
        int RamKapasitesi;
        int PilGucu;
        public CepTel(string a, string ma, string mo, string oz, int hf, int sa, int dh, int rk, int pg)
        {
            Ad = a;
            Marka = ma;
            Model = mo;
            Ozellik = oz;
            HamFiyat = hf;
            SecilenAdet = sa;
            DahiliHafiza = dh;
            RamKapasitesi = rk;
            PilGucu = pg;
        }

    }

    public class Laptop : Urun
    {
        int EkranBoyutu;
        int EkranCozunurluk;
        int DahiliHafiza;
        int RamKapasitesi;
        int PilGucu;
        public Laptop(string a, string ma, string mo, string oz, int hf, int sa, int eb, int ec, int dh, int rk, int pg)
        {
            Ad = a;
            Marka = ma;
            Model = mo;
            Ozellik = oz;
            HamFiyat = hf;
            SecilenAdet = sa;
            EkranBoyutu = eb;
            EkranCozunurluk = ec;
            DahiliHafiza = dh;
            RamKapasitesi = rk;
            PilGucu = pg;
        }
    }

    public class Sepet
    {
        Form1 frm = (Form1)Application.OpenForms["Form1"]; //Form'daki konrollere(labellar vb.) erişebilmek için kullanıldı.

        public void SepeteUrunEkle(Urun urun)
        {  
            //SepeteUrunEkle her çağrıldığında önce temizleniyor sonra ürünler sepete ekleniyor.
            frm.label14.Text = frm.tv.StokAdedi.ToString();
            frm.label19.Text = frm.ct.StokAdedi.ToString();
            frm.label18.Text = frm.lpt.StokAdedi.ToString();
            frm.label16.Text = frm.bzd.StokAdedi.ToString();
            frm.listBox1.Items.Clear();
            frm.listBox2.Items.Clear();
            frm.listBox3.Items.Clear();

            //Ürünler sepete eklendikten sonra stok adedi yeni değerine güncelleniyor.
            frm.label14.Text = (int.Parse(frm.label14.Text) - frm.numericUpDown1.Value).ToString();
            frm.label19.Text = (int.Parse(frm.label19.Text) - frm.numericUpDown4.Value).ToString();
            frm.label18.Text = (int.Parse(frm.label18.Text) - frm.numericUpDown2.Value).ToString();
            frm.label16.Text = (int.Parse(frm.label16.Text) - frm.numericUpDown3.Value).ToString();

            frm.tv.SecilenAdet = Convert.ToInt32(frm.numericUpDown1.Value);
            frm.ct.SecilenAdet = Convert.ToInt32(frm.numericUpDown4.Value);
            frm.lpt.SecilenAdet = Convert.ToInt32(frm.numericUpDown2.Value);
            frm.bzd.SecilenAdet = Convert.ToInt32(frm.numericUpDown3.Value);

            //Forma Ürün Adları ve Seçilen Adet değerleri yazdırılıyor.
            if (frm.numericUpDown1.Value != 0)
            {
                frm.listBox1.Items.Add(frm.numericUpDown1.Value);
                frm.listBox2.Items.Add(frm.tv.Ad);
            }
            if (frm.numericUpDown2.Value != 0)
            {
                frm.listBox1.Items.Add(frm.numericUpDown2.Value);
                frm.listBox2.Items.Add(frm.lpt.Ad);
            }
            if (frm.numericUpDown3.Value != 0)
            {
                frm.listBox1.Items.Add(frm.numericUpDown3.Value);
                frm.listBox2.Items.Add(frm.bzd.Ad);
            }
            if (frm.numericUpDown4.Value != 0)
            {
                frm.listBox1.Items.Add(frm.numericUpDown4.Value);
                frm.listBox2.Items.Add(frm.ct.Ad);
            }
            int sa = urun.SecilenAdet;  
        }


        public void KdvUygula()
        {
            //Ürünlerin seçilen adetlere göre KDV'li fiyatları belirleniyor.
            double kdvlitv = int.Parse(frm.label13.Text) * 1.18 * frm.tv.SecilenAdet;
            double kdvlict = int.Parse(frm.label20.Text) * 1.20 * frm.ct.SecilenAdet;
            double kdvlilpt = int.Parse(frm.label17.Text) * 1.15 * frm.lpt.SecilenAdet;
            double kdvlibzd = int.Parse(frm.label15.Text) * 1.05 * frm.bzd.SecilenAdet;

            //KDV'li fiyatlar ve Toplam Fiyat değerleri forma yazdırılıyor           
            if (kdvlitv != 0)
                frm.listBox3.Items.Add(kdvlitv);
            if (kdvlilpt != 0)
                frm.listBox3.Items.Add(kdvlilpt);
            if (kdvlibzd != 0)
                frm.listBox3.Items.Add(kdvlibzd);
            if (kdvlict != 0)
                frm.listBox3.Items.Add(kdvlict);

            frm.label25.Text = (kdvlitv + kdvlilpt + kdvlibzd + kdvlict).ToString();
        }

    }

}
