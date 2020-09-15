using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atik_toplama_oyun
{

    public class Atik
    {
        protected Atik _domates;
        protected Atik _salatalik;
        protected Atik _camsise;
        protected Atik _bardak;
        protected Atik _gazete;
        protected Atik _dergi;
        protected Atik _salcakutusu;
        protected Atik _kolakutusu;
        protected string AtikAdi;
    }

    class OrganikAtik : Atik, IAtik, IDolabilen, IAtikKutusu
    {
        Form1 f1=(Form1)System.Windows.Forms.Application.OpenForms["Form1"];
        public int Hacim { get; set; }

        public Image Image
        {
            get { return f1.images[f1.r.Next(0, f1.images.Length)]; }
        }

        public int Kapasite { get; set; } = 700;

        public double DolulukOrani { get; set; }

        public int BosaltmaPuani { get; set; } = 0;

        public int DoluHacim { get; set; }

        public bool Bosalt()
        {
            DolulukOrani = (Convert.ToDouble(f1.progressBar1.Value) / Convert.ToDouble(f1.progressBar1.Maximum));
            if (DolulukOrani >= 0.75)
            {
                f1.Puan += BosaltmaPuani;
                f1.textBox4.Text = f1.Puan.ToString();
                f1.progressBar1.Value = 0;
                f1.Sayi += 3;
                return true;
            }
            return false;
        }

        public bool Ekle(Atik atik)
        {

            if (f1.progressBar1.Maximum - DoluHacim > f1.progressBar1.Step)
            {
                f1.listBox1.Items.Add(AtikAdi);
                f1.Puan += Hacim;
                f1.textBox4.Text = f1.Puan.ToString();
                f1.progressBar1.PerformStep();
                f1.pictureBox1.Image = Image;
                return true;
            }
            return false;
        }

        public void OAtikEkle()
        {
            f1.progressBar1.Maximum = Kapasite;
            DoluHacim = f1.progressBar1.Value;

            if (f1.images[0] == f1.pictureBox1.Image)
            {
                AtikAdi = "Domates(150)";
                Hacim = 150;
                f1.progressBar1.Step = Hacim;
                DoluHacim = f1.progressBar1.Value;
                Ekle(_domates);

            }
            else if (f1.images[1] == f1.pictureBox1.Image)
            {
                AtikAdi = "Salatalık(120)";
                Hacim = 120;
                f1.progressBar1.Step = Hacim;
                DoluHacim = f1.progressBar1.Value;
                Ekle(_salatalik);
            }
        }

    }

    class CamAtik : Atik, IAtik, IDolabilen, IAtikKutusu
    {
        Form1 f1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
        public int Hacim { get; set; }

        public Image Image
        {
            get { return f1.images[f1.r.Next(0, f1.images.Length)]; }
        }

        public int Kapasite { get; set; } = 2200;

        public double DolulukOrani { get; set; }

        public int BosaltmaPuani { get; set; } = 600;

        public int DoluHacim { get; set; }

        public bool Bosalt()
        {
            DolulukOrani = (Convert.ToDouble(f1.progressBar2.Value) / Convert.ToDouble(f1.progressBar2.Maximum));
            if (DolulukOrani >= 0.75)
            {
                f1.Puan += BosaltmaPuani;
                f1.textBox4.Text = f1.Puan.ToString();
                f1.progressBar2.Value = 0;
                f1.Sayi += 3;
                return true;
            }
            return false;
        }

        public bool Ekle(Atik atik)
        {

            if (f1.progressBar2.Maximum - DoluHacim > f1.progressBar2.Step)
            {
                f1.listBox2.Items.Add(AtikAdi);
                f1.Puan += Hacim;
                f1.textBox4.Text = f1.Puan.ToString();
                f1.progressBar2.PerformStep();
                f1.pictureBox1.Image = Image;
                return true;
            }
            return false;
        }

        public void CAtikEkle()
        {
            f1.progressBar2.Maximum = Kapasite;
            DoluHacim = f1.progressBar2.Value;

            if (f1.images[4] == f1.pictureBox1.Image)
            {
                AtikAdi = "Cam Şişe(600)";
                Hacim = 600;
                f1.progressBar2.Step = Hacim;
                DoluHacim = f1.progressBar2.Value;
                Ekle(_camsise);

            }
            else if (f1.images[7] == f1.pictureBox1.Image)
            {
                AtikAdi = "Bardak(250)";
                Hacim = 250;
                f1.progressBar2.Step = Hacim;
                DoluHacim = f1.progressBar2.Value;
                Ekle(_bardak);
            }
        }

    }


    class KagitAtik : Atik, IAtik, IDolabilen, IAtikKutusu
    {
        Form1 f1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
        public int Hacim { get; set; }

        public Image Image
        {
            get { return f1.images[f1.r.Next(0, f1.images.Length)]; }
        }

        public int Kapasite { get; set; } = 1200;

        public double DolulukOrani { get; set; }

        public int BosaltmaPuani { get; set; } = 1000;

        public int DoluHacim { get; set; }

        public bool Bosalt()
        {
            DolulukOrani = (Convert.ToDouble(f1.progressBar4.Value) / Convert.ToDouble(f1.progressBar4.Maximum));
            if (DolulukOrani >= 0.75)
            {              
                f1.Puan += BosaltmaPuani;
                f1.textBox4.Text = f1.Puan.ToString();
                f1.progressBar4.Value = 0;
                f1.Sayi += 3;
                return true;
            }
            return false;
        }

        public bool Ekle(Atik atik)
        {

            if (f1.progressBar4.Maximum - DoluHacim > f1.progressBar4.Step)
            {
                f1.listBox4.Items.Add(AtikAdi);
                f1.Puan += Hacim;
                f1.textBox4.Text = f1.Puan.ToString();
                f1.progressBar4.PerformStep();
                f1.pictureBox1.Image = Image;
                return true;
            }
            return false;
        }

        public void KAtikEkle()
        {
            f1.progressBar4.Maximum = Kapasite;
            DoluHacim = f1.progressBar4.Value;

            if (f1.images[2] == f1.pictureBox1.Image)
            {
                AtikAdi = "Dergi(200)";
                Hacim = 200;
                f1.progressBar4.Step = Hacim;
                DoluHacim = f1.progressBar4.Value;
                Ekle(_dergi);

            }
            else if (f1.images[3] == f1.pictureBox1.Image)
            {
                AtikAdi = "Gazete(250)";
                Hacim = 250;
                f1.progressBar4.Step = Hacim;
                DoluHacim = f1.progressBar4.Value;
                Ekle(_gazete);
            }
        }

    }

    class MetalAtik : Atik, IAtik, IDolabilen, IAtikKutusu
    {
        Form1 f1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
        public int Hacim { get; set; }

        public Image Image
        {
            get { return f1.images[f1.r.Next(0, f1.images.Length)]; }
        }

        public int Kapasite { get; set; } = 2300;

        public double DolulukOrani { get; set; }

        public int BosaltmaPuani { get; set; } = 800;

        public int DoluHacim { get; set; }

        public bool Bosalt()
        {
            DolulukOrani = (Convert.ToDouble(f1.progressBar3.Value) / Convert.ToDouble(f1.progressBar3.Maximum));
            if (DolulukOrani >= 0.75)
            {   
                f1.Puan += BosaltmaPuani;
                f1.textBox4.Text = f1.Puan.ToString();
                f1.progressBar3.Value = 0;
                f1.Sayi += 3;
                return true;
            }
            return false;
        }

        public bool Ekle(Atik atik)
        {

            if (f1.progressBar3.Maximum - DoluHacim > f1.progressBar3.Step)
            {
                f1.listBox3.Items.Add(AtikAdi);
                f1.Puan += Hacim;
                f1.textBox4.Text = f1.Puan.ToString();
                f1.progressBar3.PerformStep();
                f1.pictureBox1.Image = Image;
                return true;
            }
            return false;
        }

        public void MAtikEkle()
        {
            f1.progressBar3.Maximum = Kapasite;
            DoluHacim = f1.progressBar3.Value;

            if (f1.images[5] == f1.pictureBox1.Image)
            {
                AtikAdi = "Kola Kutusu(350)";
                Hacim = 350;
                f1.progressBar3.Step = Hacim;
                DoluHacim = f1.progressBar3.Value;
                Ekle(_kolakutusu);

            }
            else if (f1.images[6] == f1.pictureBox1.Image)
            {
                AtikAdi = "Salça Kutusu(550)";
                Hacim = 550;
                f1.progressBar3.Step = Hacim;
                DoluHacim = f1.progressBar3.Value;
                Ekle(_salcakutusu);
            }
        }

    }



}

