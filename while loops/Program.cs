using System;
 
namespace FirstConsoleProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random numGen=new Random();
            int nrofattempts=0;
            int attempt=0;
           while(attempt !=6)
           {
               attempt=numGen.Next(1,7);
               Console.WriteLine("You rolled "  + attempt +".");
               nrofattempts++;
           }
           Console.WriteLine("It took you " + nrofattempts + " attempts");
           Console.ReadKey();
        }
    }
}