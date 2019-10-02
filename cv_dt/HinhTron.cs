using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv_dt
{
    class HinhTron
    {
        const double pi = 3.14;
        private double r;
        public double chuvi;
        public double dientich;
        public double bankinh
        {
            get { return r; }
            set { r = value; }
        }
        public HinhTron() { }
        public HinhTron(double r)
        {
            this.r = r;
        }
        public void Cv()
        {
            chuvi = r * 2 * pi;
        }
        public void Dt()
        {
            dientich = r * r * pi;
        }
    }
}
