/* Author:Rondal Archer
 * Purpose: Count the number of leap years that are btween two given years that are user decided.
 * 
 * I decided to write this because I was browsing Reddit, Through much side conversation I saw that someone 
 * suggested a prompt to calculate from years 1800 to 2100 so I decided to see if I was capable of completing it. 
 * Afterwards I decided to improve on the functionality and capabilities.
 */ 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYears
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("insert the year you want to start with ");  // prompts for input
            string input1 = Console.ReadLine();                            // takes input
            int num1 = Convert.ToInt32(input1);                            // converts string to int              
            Console.WriteLine("insert the year you want to end with ");    
            string input2 = Console.ReadLine();                             
            int num2 = Convert.ToInt32(input2);                            

            double leap = 0; // inital amount of years
            for (int i = num1 ; i < num2; i++) // locates the leap year between year 0 and 2015 
            {
                if (i % 4 == 0) // if the value of i divided by 4 has a remander of 0 
                {
                    leap++; // increments the  number of leap years
                }

            }
            Console.WriteLine("The number of leap years between " + num1 + " and " + num2 + " is " + leap + " years.");
            // print results of the years betweeen the two years that the user selected.
            // includes initial year choosen
            Console.ReadLine(); //pause

        }
    }
}
