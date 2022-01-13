using System;
namespace Operations
{
    public abstract class Calculations
    {
        abstract public void Sum(double a,double b);
        abstract public void Substract(double a,double b);
        abstract public void Multiply(double a,double b);
        abstract public void Division(double a,double b);
        abstract public void Modulus(double a,double b);
        abstract public void Power(double a,double b );
    }
    class Operation:Calculations
    {    
        public override void Sum ( double a, double b )
        {
            double c;
            c=a+b;
            Console.Write("Addition : "+c+"\n");
        }
        public override void Substract ( double a, double b )
        {
            double c;
            c=a-b;
            Console.Write("Substraction : "+c+"\n");
        }
        public override void Multiply ( double a, double b )
        {
            double c;
            c=a*b;
            Console.Write("Multiplication : "+c+"\n");
        }
        public override void Division ( double a, double b )
        {
            double c;
            c=a/b;
            Console.Write("Division : "+c+"\n");
        }  

        public override void Modulus( double a, double b ) 
        {
            double c;
            c=a%b;
            Console.Write("Modulus: "+c+"\n");
        }
        public override void Power(double a, double b)
        {
            double c;
            c=Math.Pow(a,b);
            Console.Write("Power:"+c+"\n");
        }
    }
    
}