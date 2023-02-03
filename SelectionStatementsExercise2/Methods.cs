using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatementsExercise2
{
    internal class Methods
    {
        public static void subjects() 
        {
           Console.WriteLine("what is your favorite subject?");
           var Useranwser = Console.ReadLine();
           
           switch (Useranwser) 
           {
                case "math":
                    Console.WriteLine("oh sweet you like the numbers!");
                    break;
                case "english":
                    Console.WriteLine("rockstar with the grammar!");
                    break;
                case "history":
                    Console.WriteLine("we going back in time with it!");
                    break;
                case "science":
                    Console.WriteLine("big Bang theory!");
                    break;
                default:
                    Console.WriteLine("uh oh that wasn't it the flow chart!");
                    break;

           }


        }
    }
}
