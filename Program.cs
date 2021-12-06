using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanarysFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
      ___           ___           ___           ___           ___                       ___     
     /\__\         /\  \         /\  \         /\  \         /\  \                     /\__\    
    /:/  /        /::\  \        \:\  \       /::\  \       /::\  \         ___       /:/ _/_   
   /:/  /        /:/\:\  \        \:\  \     /:/\:\  \     /:/\:\__\       /|  |     /:/ /\  \  
  /:/  /  ___   /:/ /::\  \   _____\:\  \   /:/ /::\  \   /:/ /:/  /      |:|  |    /:/ /::\  \ 
 /:/__/  /\__\ /:/_/:/\:\__\ /::::::::\__\ /:/_/:/\:\__\ /:/_/:/__/___    |:|  |   /:/_/:/\:\__\
 \:\  \ /:/  / \:\/:/  \/__/ \:\~~\~~\/__/ \:\/:/  \/__/ \:\/:::::/  /  __|:|__|   \:\/:/ /:/  /
  \:\  /:/  /   \::/__/       \:\  \        \::/__/       \::/~~/~~~~  /::::\  \    \::/ /:/  / 
   \:\/:/  /     \:\  \        \:\  \        \:\  \        \:\~~\      ~~~~\:\  \    \/_/:/  /  
    \::/  /       \:\__\        \:\__\        \:\__\        \:\__\          \:\__\     /:/  /   
     \/__/         \/__/         \/__/         \/__/         \/__/           \/__/     \/__/    
                                                
                                [ Developer : Blesslin Jerish R ]
                                     [ Stack : c# & .net ]
                              ");
            Console.WriteLine("Enter a number to find the factorial : ");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= num; i++) {
                fact = fact * i;
            }
            Console.WriteLine($"The Factorial of the number is {fact}");
            Console.ReadLine();
        }
    }
}
