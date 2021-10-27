using System;

namespace ClassLibrary2
{
    public class Cone
    {

       public  double h; public double r; public double l;

       
        public Cone(double a, double b, double c)
        {
            this.h = a; this.r=b; 
            this.l = c;
        }

        
        const double pi = 3.141592653;
       

        public double SGround()
        {
            double S = pi * r * r;
            return S;
        }

        public double SFull( )
        {
            double S = pi * r * (r + l);
            return S;
        }


       
    }
}
