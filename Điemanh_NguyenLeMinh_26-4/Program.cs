using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Điemanh_NguyenLeMinh_26_4
{
    class PTB2_235
    {
        private double a_235, b_235, c_235;

        public PTB2_235(){}

        public PTB2_235(double a_235, double b_235, double c_235){ }

        public double Geta_235()
        {
            return a_235;
        }

        public void Seta_235(double a235)
        {
            a_235 = a235;
        }

        public double Getb_235()
        {
            return b_235;
        }

        public void Setb_235(double b235)
        {
            b_235 = b235;
        }

        public double Getc_235()
        {
            return c_235;
        }

        public void Setc_235(double c235)
        {
            c_235 = c235;
        }

        public static double delta(double a235, double b235, double c235)
        {
            double d = Math.Pow(b235, 2) - (4 * a235 * c235);
            return d;
        }

        public static void nghiem(double a235, double b235, double c235)
        {
            double x1_235, x2_235;
            x1_235 = (b235 - Math.Sqrt(delta(a235,b235,c235))) / (2 * a235);
            x2_235 = (b235 + Math.Sqrt(delta(a235, b235, c235))) / (2 * a235);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            PTB2_235 b2_235 = new PTB2_235();
            b2_235.Seta_235(2);
            b2_235.Setb_235(3);
            b2_235.Setc_235(4);
            Console.WriteLine("Nghiem pt bac 2 la: " + PTB2_235.delta(b2_235.Geta_235(), b2_235.Getb_235(), b2_235.Getc_235());
        }
    }
}
