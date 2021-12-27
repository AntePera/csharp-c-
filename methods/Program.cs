using System;

namespace FirstConsoleProject
{
    class MainClass
    {
        public static void Main (string[] args)//program starts here (start function)
        {
            GreetUser();
            int result=Add(3,6);
           // Console.WriteLine(result);
            if(result > 10)
            {
                Console.WriteLine("Result is larger than 10");
            }
            else
            {
                Console.WriteLine("Result is less than or equal to 10");
            }
            Console.ReadKey();
        }
        public static void GreetUser()
        {
            Console.WriteLine("hello world");
        }
        public static int Add(int n,int m)
        {
          return n+m;
        }
    }
}