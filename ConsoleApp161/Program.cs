using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp161
{
    class Program
    {
        static void Main(string[] args)
        {
            var buffer = new StringBuilder("Hello , how are you?");

            

            Console.WriteLine($"buffer = {buffer}" + $"\nLength = {buffer.Length}" + $"\nCapacity = {buffer.Capacity}");
            
            

            buffer.EnsureCapacity(75);
            Console.WriteLine($"\nNew capacity = {buffer.Capacity}");

            
            buffer.Length = 10;
            Console.Write($"New length = {buffer.Length} \n\nbuffer = ");
            Console.ReadLine();
           

            for (int i = 0; i < buffer.Length; ++i)
            {
                Console.Write(buffer[i]);
                Console.ReadLine();
                
                
            }

            Console.WriteLine();
           
        }

        
    }
}
