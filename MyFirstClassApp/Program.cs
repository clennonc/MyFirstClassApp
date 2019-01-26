using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Humancs Human1 = new Humancs();

            Console.WriteLine("Please Enter your First name.");
            Human1.FirstName = Console.ReadLine();
            Console.WriteLine($"Please enter yout lastname {Human1.FirstName}.");
            Human1.Lastname = Console.ReadLine();
            Console.WriteLine($"{Human1.Fullname} Please enter your age.");
            Human1.Age =int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter you Height.");
            Human1.Height = double.Parse(Console.ReadLine());
            Console.WriteLine("What color is your Hair?");
            Human1.Haircolor = Console.ReadLine();
            Console.WriteLine("Please enter your Weight.");
            Human1.Weight = double.Parse(Console.ReadLine());


            Console.WriteLine($"Welcome to our program {Human1.Fullname} I see that you are {Human1.Age} years old " +
                $"and you are {Human1.Height} inches tall but you only Weigh {Human1.Weight} pounds. {Environment.NewLine} Ohh You have beautiful {Human1.Haircolor} Hair.");



            Console.ReadLine();


     
        }
    }
}
