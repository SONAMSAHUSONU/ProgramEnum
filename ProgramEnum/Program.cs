using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEnum
    //
{
    /* public class Employee
     {//Enum are name constations, enum are also know as the enumariator.enum has fixed set of constant.
      //using enum keyword we can difined enum.   enum are type safe, enum are imprubed type safety.
      //enum are dreived from Enum Class.
         public enum month
         {
             Jan, Fab, March, April
         }
         public static void Main()
         {
             foreach(string  item in Enum.GetNames(typeof(month)))//typof operator is used to get the type at complie time, it is always oprend type or parameter, typeof operatore does not allow to overload. 
             {
                 //GetName
                 Console.WriteLine(item);
             }
             Console.WriteLine("---------------------------");
             foreach (int item in Enum.GetValues(typeof(month)))//typof operator is used to get the type at complie time, it is always oprend type or parameter, typeof operatore does not allow to overload. 
             {
                 //GetName
                 Console.WriteLine(item);
             }
             Console.ReadLine();
         }
     }*/
    public class Employee
    {
        static void Main()
        {
            Gender mygender = Gender.Female;
            //Console.WriteLine(mygender);
            switch(mygender)
            {
                case Gender.Female:
                    Console.WriteLine("Female");
                    break;
                case Gender.Male:
                    Console.WriteLine("Male");
                    break;
                case Gender.Other:
                    Console.WriteLine("Other");
                    break;

            }
                
            Console.ReadLine();

        }
    }
    public enum Gender
    {
        Male, Female, Other
    }
    //we can not make constructor,method and we can't inheritence 
    //enum are drived from enum class 

}
