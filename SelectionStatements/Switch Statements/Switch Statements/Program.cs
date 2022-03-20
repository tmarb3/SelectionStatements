using System;

namespace Switch_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            var response = Console.ReadLine(); 

            switch (response)
            {
                case "Math":
                    Console.WriteLine("I teach Math");
                    break;

                case "English":
                    Console.WriteLine("I did not like English class.");
                    break;
                case "science":
                    Console.WriteLine("I like Science too");
                    break ;
                case "History":
                    Console.WriteLine("I fell asleep in history");
                    break;
             
                default:
                    Console.WriteLine("I have not heard of that");
                    break ;


               
             
            }
            
        }
    }
}
