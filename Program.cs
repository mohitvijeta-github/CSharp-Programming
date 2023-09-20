using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_
{


    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2023, 09, 18);
            Console.WriteLine(dateTime);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.UtcNow);
            DateTime tommorow = GetTommorow();
            Console.WriteLine(tommorow);


            Console.ReadKey();
        }

        static DateTime GetTommorow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}













          // Random Concept in C#


            //Random random = new Random();

            //int number;
            //for(int i=0; i<= 3; i++) 
            //{
            //    number = random.Next(0,4);
            //    if(number == 1)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else if(number == 2) 
            //    {
            //        Console.WriteLine("Maybe");
            //    }
            //    else if(number == 3)
            //    {
            //        Console.WriteLine("No");
            //    }
                


// Enum concpet 

    //enum Months { Jan, Feb, Mar, Ap, May, Ju, July, Aug, Sep, Oct, Nov, Dec }

            //Months january= Months.Jan;
            //Months a = Months.Jan;
            //Console.WriteLine((int)Months.Feb);
            //Console.WriteLine(january == a);
            //Console.ReadLine();

// Concept of Struct

//struct Game
//{
//    public int Id;
//}
//Game game = new Game();
//game.Id = 1;
//Console.WriteLine(game.Id);

// maths program 
//using System;

//namespace Coding.Exercise
//{

//    public class Exercise
//    {
//        public static double ConvertToRadians(double angle)
//        {
//            return (Math.PI / 180) * angle;
//        }

//        public static void Run(string line)
//        {

//            int angle;

//            if (Int32.TryParse(line, out angle) == false || (angle < 0 || angle > 180))
//            {
//                System.Console.WriteLine("Check the input!");
//                return;
//            }

//            System.Console.WriteLine("Cos = {0}", Math.Cos(ConvertToRadians(angle)));
//            System.Console.WriteLine("Sin = {0}", Math.Sin(ConvertToRadians(angle)));
//            System.Console.WriteLine("Tg = {0}", Math.Tan(ConvertToRadians(angle)));

//        }
//    }
