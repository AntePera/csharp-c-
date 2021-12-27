using System;

namespace FirstConsoleProject
{
    class Animal
    {   
        public static int count =0;
        public string name;
        public int age;
        public float happines;
       public void Print()
       {
           Console.WriteLine("Name " + name);
           Console.WriteLine("age " + age);
           Console.WriteLine("happines " + happines);
       }
       public Animal()//default constructor
       {
           name="Spotify";
           age=7;
           happines=0.5f;
           count++;
       }
       public Animal(string _name, int _age, float _happines)
       {
           name = _name;
           age = _age;
           happines= _happines;
           count++;

       }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {   
            Animal dog=new Animal();
            dog.Print();
            Animal cat=new Animal("Maya",3,0.1f);
            cat.Print();
            Console.WriteLine();
            Console.WriteLine("Nr of animals: " + Animal.count);
            Console.ReadKey();
        }
        
    }
}
