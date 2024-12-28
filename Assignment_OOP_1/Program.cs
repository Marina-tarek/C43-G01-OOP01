using System.ComponentModel;
using System.Reflection;
using common;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product product= new Product();//create refrence refer to instance of product
            //product.Id = 1;
            //product.Count = 40;

            #region  1 - Create an Enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this Enum.
            //WeekDays weekDays = new WeekDays();

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(Enum.GetValues(WeekDays)); 
            //}
            #endregion

            #region 2 - Create an Enum called "Seas on" with the four seasons(Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user
            ////and displays the corresponding month range for that season. 
            ///Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
  
            //Console.WriteLine("range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)");
            //bool IsParsed;
            //object Season;
            //do
            //{
            //    Console.Write("please enter Season name (must start Capital letter): ");
            //    IsParsed=Enum.TryParse(typeof(Season), Console.ReadLine(), out Season);
            //}
            //while (!IsParsed ||Season is null);

            //Console.WriteLine(Season);
            #endregion

            #region 3 - Assign the following Permissions(Read, write, Delete, Execute)
            //in a form of Enum.Create Variable from previous Enum to Add and Remove Permission from variable,
            //check if specific Permission existed inside variable

            #endregion

            #region 4.Create an Enum called "Colors" with the basic colors(Red, Green, Blue) as its members.Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            #endregion
        }
    }
}
