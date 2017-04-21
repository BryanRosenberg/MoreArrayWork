using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreArrayWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] daysOfTheWeek = new string[7];
            //daysOfTheWeek[0] = "Sunday";
            //daysOfTheWeek[1] = "Monday";
            //daysOfTheWeek[2] = "Tuesday";
            //daysOfTheWeek[3] = "Wednesday";
            //daysOfTheWeek[4] = "Thursday";
            //daysOfTheWeek[5] = "Friday";
            //daysOfTheWeek[6] = "Saturday";

            //string[] monthsOfTheYear = new string[]
            //{
            //    "January",
            //    "February",
            //    "March",
            //    "April",
            //    "May",
            //    "June",
            //    "July",
            //    "August",
            //    "September",
            //    "October",
            //    "November",
            //    "December"
            //};

            //Console.WriteLine(monthsOfTheYear.Length);

            //foreach (string month in monthsOfTheYear)
            //{
            //    Console.WriteLine(month);
            //}

            Random random = new Random();

            //int[] yahtzeeRoll = new int[5];

            //yahtzeeRoll[0] = random.Next(6) + 1;
            //yahtzeeRoll[1] = random.Next(6) + 1;
            //yahtzeeRoll[2] = random.Next(6) + 1;
            //yahtzeeRoll[3] = random.Next(6) + 1;
            //yahtzeeRoll[4] = random.Next(6) + 1;

            //int[] yahtzeeRoll = new int[]
            //{
            //    random.Next(6) + 1,
            //    random.Next(6) + 1,
            //    random.Next(6) + 1,
            //    random.Next(6) + 1,
            //    random.Next(6) + 1,
            //};

            //foreach (int dieRoll in yahtzeeRoll)
            //{
            //    Console.WriteLine(dieRoll);
            //}

            //int[] yahtzeeRoll = new int[5];

            //for (int i = 0; i < yahtzeeRoll.Length; i += 1)
            //{
            //    yahtzeeRoll[i] = random.Next(6) + 1;
            //}

            //string[] peopleInThisClass = new string[]
            //{
            //    "Hari","Bryan","Ruth","Margaret","Pat","Rikela","Curtis"
            //};

            //foreach (string people in peopleInThisClass)
            //{
            //    Console.WriteLine(people);
            //}

            double maxValue = double.NegativeInfinity;

            double[] numbers = new double[]
            {
                3.14, 6.28, 99.95, 1001.17
            };

            foreach (double number in numbers)
            {
                if (maxValue < number)
                {
                    maxValue = number;
                }
            }

            Console.WriteLine("The max value is " + maxValue);
        }
    }
}
