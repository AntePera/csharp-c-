using System;

namespace firstConsoleProject
 {
     class MainClass
     {

         public static void Main(string[] args)//method called main
         {
            Random num_gen=new Random();
            int n1,n2;
            int n3;
            n3=0;
            n1=num_gen.Next(1,11); //goes 1-10 
            n2=num_gen.Next(1,11);
            int guessnum;
            Console.WriteLine("What is " + n1 + " times " + n2 + "?" );
            while(n3==0)
            {
                Console.WriteLine("Guess da number brudda " );
                guessnum= Convert.ToInt32(Console.ReadLine());
                if(guessnum==(n1*n2))
                {
                    Console.WriteLine("ggwp man you better not cheat");
                    break;
                }
                else
                {
                    int response_index=num_gen.Next();
                    switch(response_index)
                    {
                        case 1:
                        {
                            Console.WriteLine("hahah you suck try again");
                           break;
                        }
                        case 2:
                        {
                            Console.WriteLine("you can do it");
                           break;
                        }
                        default:
                            Console.WriteLine("lmao");
                            break;
                    }
                }
            }
         }
     }
 }