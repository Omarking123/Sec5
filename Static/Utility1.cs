using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec5.Static
{
    internal class Utility1
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Utility1(int X , int Y)
        {
            this.X = X;
            this.Y = Y;
            pi = 3.14;
        }


        static Utility1()
        {
            pi = 3.14;
        }

        private const double pi = 3.14;

        public override string ToString()
        {
            return $"{X},{Y}";
        }



        public static double CmToInch(double Cm)
        {


            return Cm / 254;

        }
        private static readonly double pi = default;
        public static double PI
        {
            get { return pi; }
            

        }


        public static double CalcCircleArea(double Radius)
        {
            
            return PI  *Radius *Radius;
        }
    }
    
    
 }
