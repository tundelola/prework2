/*
 * This program calculate the duration between two dates in Years,
Months and Days. The user enters two dates as input, then the program will shows the
result of the difference in time between these two dates. 
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffOfTwoDates
{
    class Program
    {
        static void Main(string[] args)

        {
            DateTime myValue = DateTime.Now;    
            // Get the first date input from the users
            Console.WriteLine("Please Enter the First Date ");
            string date1 = Console.ReadLine();
            DateTime dt1 = Convert.ToDateTime(date1);

            //Prints the Users first input as Years, Months and Days
            Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", dt1.Year, dt1.Month, dt1.Day);

            // Get the second date input from the users
            Console.WriteLine("Please Enter the Second Date ");
            string date2 = Console.ReadLine();
            DateTime dt2 = Convert.ToDateTime(date2);

            //Prints the Users second input as Years, Months and Days
            Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", dt1.Year, dt1.Month, dt1.Day);


            // get the difference in Days for both dates from input by the users
            TimeSpan diffDays = DateTime.Now.Subtract(dt1);

            // get the difference in months (both beginning  and end months included) from the input by the users
            var diffMonth = (dt1.Month + dt1.Year * 12) - (dt2.Month + dt2.Year * 12); 
           // get the difference in years for both dates from input by the users
            var diffYear = dt1.Year - dt2.Year;
        
            Console.WriteLine( diffYear.ToString());// Prints difference in years of dates input by the users
            Console.WriteLine(diffMonth.ToString()); //Prints difference in Months of dates input by the users
            Console.WriteLine(diffDays.Days.ToString());  //Prints difference in Days of dates input by the users
                        

            Console.ReadLine();// Reads output to the screen
            

            
        }
    }
}
