using System;
using System.Collections.Generic;
namespace FirstConsoleProject
{
    class MainClass2
    {
        public static void Main2(string[] args)
        {
            List<int> numbers = new List <int> ();
            numbers.Add(12);
            numbers.Add(5);
            numbers.Add(6);
            for(int i=0;i<numbers.Count;i++)
            {
                Console.WriteLine(numbers[i]);
            }
            numbers.RemoveAt(2);//remove a certain element of a list
            for(int i=0;i<numbers.Count;i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}