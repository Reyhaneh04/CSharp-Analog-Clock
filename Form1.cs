using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        int x0, y0;
        int rH, rM, rS;
        double rRatio;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x0 = ovclock.Left + ovclock.Width / 2;
            y0 = ovclock.Top + ovclock.Height / 2;
            rS = ovclock.Width / 2 - 60;
            rM = rS + 10;
            rH = rM + 10;
            lnHour.BorderWidth = 3;
            lnMinute.BorderWidth = 2;
            lnSec.BorderColor = Color.Red;
            // تنظیم ابتدای خطوط به مبدا مختصات
            lnHour.X1 = lnMinute.X1 = lnSec.X1 = x0;
            lnHour.Y1 = lnMinute.Y1 = lnSec.Y1 = y0;
            // تنظیم بلندی خطوط
            lnHour.X2 = rH; lnMinute.X2 = rM; lnSec.X2 = rS;
            lnHour.Y2 = lnMinute.Y2 = lnSec.Y2 = y0;
            rRatio = Math.PI / 180;
            timer1_Tick(sender, e);
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.ToLocalTime();
            int H = dt.Hour % 12, M = dt.Minute, S = dt.Second;
            double dH = ((H - 3) * 30 + M * .5) * rRatio;
            double dM = (M - 15) * 6 * rRatio, dS = (S - 15) * 6 * rRatio;
            lnSec.X2 = (int)(x0 + rS * Math.Cos(dS));
            lnSec.Y2 = (int)(y0 + rS * Math.Sin(dS));
            lnMinute.X2 = (int)(x0 + rM * Math.Cos(dM));
            lnMinute.Y2 = (int)(y0 + rM * Math.Sin(dM));
            lnHour.X2 = (int)(x0 + rH * Math.Cos(dH));
            lnHour.Y2 = (int)(y0 + rH * Math.Sin(dH));
            this.Text = dt.ToString("hh:mm:ss");
        }

        private void ovclock_Click(object sender, EventArgs e)
        {

        }

        private void lnHour_Click(object sender, EventArgs e)
        {

        }

        private void lnSec_Click(object sender, EventArgs e)
        {

        }
    }
}
