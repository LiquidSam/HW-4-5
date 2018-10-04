using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the word  ");
            string word = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < word.Length; i++)

                Console.Write(word[word.Length - i - 1]);

        }
    }
}