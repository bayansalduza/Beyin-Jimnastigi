using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Image> il = new List<Image>();
        Bitmap bm1;
        Bitmap bm2;
        int dogru = 0;
        int yanlis = 0;
        int sn = 72;
        int index;
        bool ctr1 = true;
        BTRain bt = new BTRain();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            il.Add(Properties.Resources.Adsız_cutout);
            il.Add(Properties.Resources.Adsız4_cutout);
            il.Add(Properties.Resources.Adsız2_cutout);
            il.Add(Properties.Resources.Adsız3_cutout);
            bt.blft(false, label3, label4, label5, label6, pictureBox2);
            Random r = new Random();
            index = r.Next(il.Count());
            timer1.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            bt.blft(false, label1, label2, pictureBox1);
            bt.blft(true, label3, label4, label5, label6, pictureBox2);
            timer1.Enabled = true;
            Random r = new Random();
            index = r.Next(il.Count());
            pictureBox2.Image = il[index];
            bm1 = new Bitmap(pictureBox1.Image);
            ctr1 = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sn--;
            label6.Text = sn.ToString();
            if (sn == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Doğru= " + dogru.ToString() + ", Yanlış" + yanlis.ToString());
            }
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            bt.mhovleav(Color.Bisque, label5, label2);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            bt.mhovleav(Color.Gold, label5, label2);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            bt.mhovleav(Color.Bisque, label4);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            bt.mhovleav(Color.Gold, label4);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            index = r.Next(il.Count());
            if (ctr1 == false)
            {
                bm2 = new Bitmap(pictureBox2.Image);
                ctr1 = true;
            }
            else
            {
                bm1 = new Bitmap(pictureBox2.Image);
                ctr1 = false;
            }
            if (bt.karsi(bm1, bm2))
            {
                dogru++;
                pictureBox3.Image = Properties.Resources.tick_33829;
                pictureBox3.Visible = true;
                timer2.Enabled = true;
            }
            else
            {
                yanlis++;
                pictureBox3.Image = Properties.Resources._525px_X_mark_svg;
                pictureBox3.Visible = true;
                timer2.Enabled = true;
            }
            pictureBox2.Image = il[index];
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            timer2.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

            Random r = new Random();
            index = r.Next(il.Count());
            if (ctr1 == false)
            {
                bm2 = new Bitmap(pictureBox2.Image);
                ctr1 = true;
            }
            else
            {
                bm1 = new Bitmap(pictureBox2.Image);
                ctr1 = false;
            }
            if (!bt.karsi(bm1, bm2))
            {
                dogru++;
                pictureBox3.Image = Properties.Resources.tick_33829;
                pictureBox3.Visible = true;
                timer2.Enabled = true;
            }
            else
            {
                yanlis++;
                pictureBox3.Image = Properties.Resources._525px_X_mark_svg;
                pictureBox3.Visible = true;
                timer2.Enabled = true;
            }
            pictureBox1.Image = il[index];
        }
    }
}
