/*using System;

namespace FirstConsoleProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] numbers= new int[5];
            string[]names=new string[3]{
                "Tom","Mark","Mike"
            };
            for(int i=0;i<numbers.Length;i++)
            {
               Console.Write(numbers[i]+" ");
            }
            foreach(string name in names)//other way to loop through the array
            {
                Console.Write(name + " ");
            }
        }
    }
}*/
using System;
using System.Collections.Generic;
namespace FirstConsoleProject
{
    class MainClass
    {
        public static void Main(string[] args)
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