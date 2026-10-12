using System;
using System.Collections.Generic;
using System.Text;

namespace praktos4
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Perimeter()
        {
            return a + b + c;
        }
        public void SetParams(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void SetParams()
        {
            a = a * 2;
            b = b * 2;
            c = c * 2;
        }
        public string Show()
        {
            string text = "Сторона A = " + a + "\n";
            text = text + "Сторона B = " + b + "\n";
            text = text + "Сторона C = " + c + "\n";
            text = text + "Периметр = " + Perimeter();

            return text;
        }
    }
}