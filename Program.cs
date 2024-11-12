using System;
using System.Collections.Generic;

namespace dotnet_IndexOutOfRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> characters = new List<char>();
                characters.InsertRange(0, new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });

                int index = 6;
                
                if (index >= 0 && index < characters.Count)
                {
                    int value = characters[index]; 
                    Console.WriteLine($"Value at index {index}: {value}"); 
                }
                else
                {
                    Console.WriteLine("Index is out of range.");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
