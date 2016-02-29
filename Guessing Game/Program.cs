using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = (new Random(123)).Next(200);
            Console.Write("Tell me your number: ");
            string yourNumber = Console.ReadLine();
            int liczbaGracza = int.Parse(yourNumber);
            int counter = 1;
            while (liczbaGracza != secretNumber)
            {
                if (liczbaGracza > secretNumber)
                {
                    Console.Write("Your number is larger thank a Secret Number.Try again: ");
                   
                }
                else
                {
                    Console.WriteLine("Your number is smaller than a Secret Number. Try again: ");
                 
                }
                yourNumber = Console.ReadLine();
                liczbaGracza = int.Parse(yourNumber);
                counter++;
            }
           
            Console.WriteLine("You tried for:  " + counter + " times");
            Console.WriteLine("Bravo! The secret number is " + secretNumber + "!");
            Console.ReadLine(); 
       }
                
           
        
    }
}
