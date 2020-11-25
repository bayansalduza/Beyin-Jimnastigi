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
    class BTRain
    {
        public void mhovleav(Color b,params Label[] a)
        {
            foreach (Label lb in a)
                lb.ForeColor = b;
        }
        public bool karsi(Bitmap bm1,Bitmap bm2)
        {
            for (int i = 0; i < bm1.Width; i++)
            {
                for (int j = 0; j < bm1.Height; j++)
                {
                    Color cl1 = bm1.GetPixel(i, j);
                    Color cl2 = bm2.GetPixel(i, j);
                    if (cl1 != cl2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public void blft(bool a,params Control[] b)
        {
            foreach(Control ctr in b)
            {
                ctr.Visible = a;
            }
        }
    }
}
