using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atik_toplama_oyun
{

    public partial class Form1 : Form 
    {
        public Random r = new Random();

        public int Sayi { get; set; }
        public int Puan { get; set; }
        public Image[] images = { Image.FromFile("domates1.png"), Image.FromFile("salatalik1.png"), Image.FromFile("dergi1.png"),
                            Image.FromFile("gazete1.png"), Image.FromFile("camsise1.png"), Image.FromFile("kola1.png"),
                            Image.FromFile("kova1.png"), Image.FromFile("bardak1.png") };

        public Form1()
        {
            InitializeComponent();
            buttonEnabledFalse();
        }

        void buttonEnabledFalse()
        {
            button3.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
            button10.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button7.Enabled = false;
            button9.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sayi = 60;
            Puan = 0;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            textBox4.Text = Puan.ToString();

            button1.Enabled = false;
            button3.Enabled = true;
            button6.Enabled = true;
            button8.Enabled = true;
            button10.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button7.Enabled = true;
            button9.Enabled = true;

            timer1.Enabled = true;

            pictureBox1.Image = images[r.Next(0, images.Length)];
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //Sayaç işlemleri için koşul bloğu.
            if (Sayi >= 0)
            {
                timer1.Interval = 1000;
                int sayac = Sayi--;
                textBox3.Text = sayac.ToString();
                if (sayac == 0)
                {
                    buttonEnabledFalse();
                    button1.Enabled = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrganikAtik oa = new OrganikAtik();
            oa.OAtikEkle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrganikAtik oa = new OrganikAtik();
            oa.Bosalt();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CamAtik ca = new CamAtik();
            ca.CAtikEkle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CamAtik ca = new CamAtik();
            ca.Bosalt();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            KagitAtik ka = new KagitAtik();
            ka.KAtikEkle();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            KagitAtik ka = new KagitAtik();
            ka.Bosalt();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MetalAtik ma = new MetalAtik();
            ma.MAtikEkle();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MetalAtik ma = new MetalAtik();
            ma.Bosalt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
