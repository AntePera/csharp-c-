using System;

namespace firstConsoleProject2
{
    class MainClass3
    {
        public static void Main(string[] args)
        {
            for(int i=1;i<=10;i++ )
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}