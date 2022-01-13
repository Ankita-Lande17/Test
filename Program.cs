using System;
using Operations;
using Test;
namespace basiclearning
{
    class Program
    {
        static void Main(string[] args)
        {
           Operation op=new Operation();
           Console.WriteLine("First Number : ");
           double a1=Convert.ToDouble(Console.ReadLine());
           Console.Write("Second Number : ");
           double b1=Convert.ToDouble(Console.ReadLine());
           Console.Write(" 1.ADD \n 2 SUBSTRACTION \n 3 MULTIPLICATION \n 4 DIVISION\n 5 MODULUS\n 6 POWER\n");
           Console.Write("Enter choice:\n");
           int number=Convert.ToInt32(Console.ReadLine());
           switch(number)
           {
               case 1:
               {
                   op.Sum ( a1, b1 );
                   break;
               }
               case 2:
               {
                   op.Substract ( a1, b1 );
                   break;
               }
               case 3:
               {
                   op.Multiply ( a1, b1 );
                   break;
               }
               case 4:
               {
                   op.Division ( a1, b1 );
                   break;
               }
               case 5:
               {
                   op.Modulus ( a1, b1 );
                   break;
               }
               case 6:
               {
                   op.Power( a1, b1 );
                   break;
               }
               default:
               {
                   Console.Write("Select Appropriate Option");
                   break;
               }
           }
          /* Car car = new Car();
           car.changeGear(2);
           car.speedUp(5);
           car.applyBrakes(2);
          
           Console.WriteLine("Car present state :");
           car.printStates();
          
       
           Bike bike = new Bike();
           bike.changeGear(1);
           bike.speedUp(3);
           bike.applyBrakes(2);
           Console.WriteLine("Bike present state :");
           bike.printStates();*/
        }
    }
}