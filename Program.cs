using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] arg0)
        {
            // Automatically populate an array of 25 elements
            int[] countdown = new int[26];
            int pop_array = 1;
            // Iterate through the array using a For Loop
            for (int i = 1; i < 26; i++)
            {
                countdown[i] = pop_array;
                Console.Write(i + " ");
            }
            Console.Write("\n");
            for (int i = 1; i < 26; i++)
            Console.WriteLine("Element Value = " + i.ToString());
        }
    }
}
