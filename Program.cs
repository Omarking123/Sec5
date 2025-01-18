
using Sec5.abstraction;
using Sec5.Sealed;
using Sec5.Static;

namespace Sec5
{
    internal class Program
    {
        #region video 3
        //static void ClcPayment(PaymentProcessor processor)
        //{
        //    processor.ProccessPayment(100);
        //} 
        #endregion
        static void Main(string[] args)
        {
            #region First Video 
            //Shape shape;

            /////
            //Rect rect = new Rect() { Dim01 = 10, Dim02 = 20 };
            //decimal rectarea = rect.CalcArea();
            //decimal rectPeri = rect.Perimeter;

            //Console.WriteLine(rectPeri);
            //Console.WriteLine(rectarea);


            //Square square = new Square(20);
            //decimal squarePeri = square.Perimeter;
            //decimal squareArea = square.CalcArea();
            //Console.WriteLine(squarePeri);
            //Console.WriteLine(squareArea);


            //Circle circle = new Circle(10);
            //decimal circlePeri = circle.Perimeter;
            //decimal circleArea = circle.CalcArea();
            //Console.WriteLine(circlePeri);
            //Console.WriteLine(circleArea); 
            #endregion

            #region Video 2
            Utility1 U01 = new Utility1(1, 2);
            //Utility1 U02 = new Utility1(5,10);

            Console.WriteLine(Utility1.CmToInch(254));
            Console.WriteLine(Utility1.CmToInch(254));

            Console.WriteLine(Utility1.CalcCircleArea(10)); 
            #endregion
        }
    }
}
