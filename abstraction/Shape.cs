using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec5.abstraction
{
     abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        public abstract decimal Perimeter { get;  }
        public abstract decimal CalcArea();
        
    }


    class Rect : RectBase
    {
        public override decimal Perimeter { 
            get { return (Dim01 + Dim02) * 2; }
        }
     


    }

    abstract class RectBase : Shape
    {
        public override decimal CalcArea()
        {
            return Dim02 * Dim01;
        }

    }

    class Parent
    {
        public virtual int Salary { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("I am Parent");
        }
    }

    class Child : Parent
    {
        public override int Salary {
            get { return base.Salary; }
            set { base.Salary = value +2000; }
        }
        public override void Print()
        {
            base.Print();
        }
    }

    class Square : RectBase
    {

        public Square(int Dim)
        {
            this.Dim01 = this.Dim02 = Dim;
        }
        public override decimal Perimeter {
            get
            {
                return Dim01 * 4;
            }             }
       
    }

    class Circle : Shape
    {
        public Circle(decimal Radius)

        {
            this.Dim01 = this.Dim02 = Radius;
            
        }
        public override decimal Perimeter {

            get { return 2 * 3.14m * this.Dim02; }        
        }

        public override decimal CalcArea()
        {
            return 3.14m * this.Dim01 * this.Dim01;
        }
    }
}
