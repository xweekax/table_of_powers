using System;

namespace table_of_powers
{
    class Program
    {
        static void Main(string[] args)
        {
            int square = 0;
            int cube = 0;
            string cont = null;
            
            while (cont != "n")    //loop through the question and math/display until the variable cont is not set to n
            {
                Console.Write("Please enter a number: ");
                string number_entry = Console.ReadLine();
                int number = int.Parse(number_entry);

                if (number <= 0)   //prevent the input of 0 or negative numbers
                {
                    Console.WriteLine("This is an invalid entry");
                    Console.WriteLine(" ");
                    cont = "y";
                }
                else if (number >= 1290)  //prevent an entry that would exceed the range of a 32-bit integer
                {
                        Console.WriteLine("The cubed value exceeds max value");
                        cont = "y";
                 
                }
                else
                {
                    for (int i = 1; i <= number; i++)   //begin the math and display of the input and math
                    {
                        square = i * i;
                        cube = i * i * i;

                        Console.WriteLine("Number \t\t\t Squared \t\t Cubed");
                        Console.WriteLine($"{i} \t\t\t {square} \t\t\t {cube}");
                        
                    }
                    Console.WriteLine("Would you like to continue? (y/n)");
                    cont = Console.ReadLine();
                }
            }





        }
    }
}
