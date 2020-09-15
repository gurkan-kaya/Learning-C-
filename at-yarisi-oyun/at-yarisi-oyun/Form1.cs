using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarisi_oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int atGenisliği,bitisuzakligi,konumBirinciAt;
        Random rastgeleAtHizi = new Random();
        int[] konumlar = new int[4];
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }
            else
                timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            konumlar[0] = pictureBox1.Left;
            konumlar[1] = pictureBox2.Left;
            konumlar[2] = pictureBox3.Left;
            konumlar[3] = pictureBox4.Left;

            int birinciAtNo = atNoDondur();
            label2.Text = birinciAtNo + " numaralı at önde";
            konumBirinciAt = konumlar[birinciAtNo-1];

            if (konumBirinciAt>bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show(birinciAtNo + " numaralı at yarışı kazandı");
            }

            pictureBox1.Left += rastgeleAtHizi.Next(1, 20);
            pictureBox2.Left += rastgeleAtHizi.Next(1, 20);
            pictureBox3.Left += rastgeleAtHizi.Next(1, 20);
            pictureBox4.Left += rastgeleAtHizi.Next(1, 20);

        }


        private int atNoDondur()
        {
            Array.Sort(konumlar);

            if (pictureBox1.Left == konumlar[3]) return 1;
            else if (pictureBox2.Left == konumlar[3]) return 2;
            else if (pictureBox3.Left == konumlar[3]) return 3;
            else if (pictureBox4.Left == konumlar[3]) return 4;
            else return 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atGenisliği = pictureBox1.Width;
            pictureBox2.Width = atGenisliği;
            pictureBox3.Width = atGenisliği;
            pictureBox4.Width = atGenisliği;
            timer1.Interval = 100;

            bitisuzakligi = label3.Left - atGenisliği;
        }


    }
}
