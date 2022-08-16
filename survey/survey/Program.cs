using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace survey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter Your Age");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(x);

            Console.WriteLine("Your age is " + x);

            Console.WriteLine("Your age is {0}.", x);

            Console.WriteLine($"Your Age is {x}");

            Console.WriteLine(@"Your Age is {x}");



            string ans;
            Console.WriteLine("What color is a Red Ball? Is it:");
            Console.WriteLine("\nA)Blue\nB)Red\nC)Green");
            ans = Console.ReadLine();
            if (ans.ToUpper() == "B")
                Console.WriteLine("That is correct");
            else Console.WriteLine("That is incorrect");

            string a = "0";
            Console.WriteLine("\nWhat is the answer to this equation? \n(5+27-500) * 0 / 20?");
            a = Console.ReadLine();
            if (a == "0")
                Console.WriteLine("That is correct");
            else Console.WriteLine("That is False");

            int b = 7;
            Console.WriteLine("\nIf A person had 27 apples, and one of their friends took 30 but then gave 7 back, How many apples would they have?");
            b = int.Parse(Console.ReadLine());
            if (b == 7)
                Console.WriteLine("That is correct");
            else Console.WriteLine("That is incorrect");




            int t = 0;
            if (ans.ToUpper() == "B")
                t = t + 1;
            else t = t + 0;


            if (a == "0")
                t = t + 1;
            else t = t + 0;

            if (b == 7)
                t = t + 1;
            else t = t + 0;

            Console.WriteLine($"You got {t}/3 right!");









    
            

            



            Console.ReadKey();

            
        }
    }
}
