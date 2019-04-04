//Lara Corkery 
//Practice Questions 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra_PracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question One 
            /*  Console.WriteLine("This Application Will Determine If The Letter You Input Is Either A Vowel Or A Consonant");
              Console.WriteLine("Please Enter A Letter ");
              string letter = Console.ReadLine().ToLower();

              if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
                  Console.WriteLine("{0} is a vowel", letter);

              else
                  Console.WriteLine("{0} is a Consonant", letter);

              Console.WriteLine("Application Completed, Press [ENTER] To Continue..... ");
              Console.ReadLine(); */


            // Question Two 
            /* Console.WriteLine("This Application Will Calculate Your BMI (Body Mass Index) ");
             Console.Write("Please Enter Your Weight in Kg's: ");
             float weight = float.Parse(Console.ReadLine());
             Console.Write("Now Please Enter Your Height in CM's: ");
             float height = float.Parse(Console.ReadLine());

             Console.WriteLine("Your BMI is: " + (weight / (height * height)));

             Console.WriteLine("Application Is Completed, Press [ENTER] To Continue .....");
             Console.ReadLine(); */


            //Question Three
            /*Console.WriteLine("This Application Will Calculate The Sum Of 20 Numbers");
            float total = 0;

            for (int i=1; i<=20; i++)
            {
                Console.Write($"Please Enter Number {i}: ");
                total = total + float.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The Sum Of Numbers You Entered Equals To: {total} ");
            Console.WriteLine("Application Completed, Press [ENTER] To Continue: ");
            Console.ReadLine(); */

            //Question Four
            Console.WriteLine("This Application Will Calculate the Factorial of 10");
            int total = 1;
            int i = 1;
            while(i<=10)
            {
                total *= i;
                i++;
            }
            Console.WriteLine($"The Factorial Of 10 Is: {total} ");
            Console.WriteLine("Application Complete, Press [ENTER] To Continue.....");
            Console.ReadLine(); 

        }
        
    }
}
