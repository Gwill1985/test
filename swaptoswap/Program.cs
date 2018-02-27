using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swaptoswap
{
    class Program
    {
        static void Main(string[] args)
        {

            int  num1, num2, temp;

            Console.WriteLine("Enter first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number ");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;
     
            

            Console.WriteLine("Your numbers swapped are : " );
            Console.WriteLine("your first number is :" + num1);
            Console.WriteLine("your second number is :" + num2);


            
            

            Console.ReadLine();

           
            
        }
    }
}
