using System;

namespace FirstConsoleProject
{
    class Car
    {
         public string name;
         public int age;
         public float mileage;
         public void PrintBase()
         {
             Console.WriteLine("Name: " + name);
             Console.WriteLine("age: " + age);
             Console.WriteLine("Mileage: " + mileage);
         }
    }
    class AE86:Car
    {
        public int heelNtoes;
        public void Engine()
        {
            Console.WriteLine("Engine: 4A-C I4 SOHC");
            Console.WriteLine("Number of satisfying downshifts: " +heelNtoes);
        }
    }
    class R34:Car
    {
        public float weight;
        public void Engine()
        {
            Console.WriteLine("Engine: RB26DETT");
            Console.WriteLine("Weight:" + weight);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            AE86 Driver=new AE86();
            Driver.name="Takumi";
            Driver.age=19;
            Driver.mileage=244567.67f;
            Driver.heelNtoes=25;
            Driver.PrintBase();
            Driver.Engine();
            R34 Driverr=new R34();
            Driverr.name="Nakazato";
            Driverr.age=29;
            Driverr.mileage=636536.34f;
            Driverr.weight=1920;
            Driverr.PrintBase();
            Driverr.Engine();
            Console.ReadKey();
        }
    }
}