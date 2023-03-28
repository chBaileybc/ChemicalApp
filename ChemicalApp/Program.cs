using System;
using System.Collections.Generic;

namespace ChemicalApp
{
    class Program
    {

        //Global variables

        static List<string> chemicals = new List<string>() 
        { "Propane", "Cyanide", "Bleach", "Hot water","Alcohol"};

        //methods and/or functions

        static void OneChemical()
        {
            //Enter and store chemical name

            Console.WriteLine("Enter the number for the chemical you want to test:\n\n" +
                "1.Propane\n" +
                "2.Cyanide\n" +
                "3.Bleach\n" +
                "4.Hot water\n" + 
                "5.Alcohol\n");

            int chemicalName = Convert.ToInt32(Console.ReadLine());

            //Display chemical

            Console.WriteLine($"\n{chemicals[chemicalName-1]}\n");

            

            //Randomly generate a random amount of germs

            Random randGen = new Random();

            int chemicalNameValue = randGen.Next(2000, 3000);

            int sumGermGenerated = 0;

            int germCount = randGen.Next(2000, 7500);

            Console.WriteLine($"There are {germCount} germs for testing\n");

            //Display an amount of time waited for testing

            int germTime = randGen.Next(20,30);

            Console.WriteLine($"You have waited {germTime}s after using {chemicals[chemicalName-1]} on the germs\n");

            //Calculate the efficiecy rating of that chemical tested

            float efficiencyRating = germCount - chemicalNameValue / germTime;

            Console.WriteLine($"The efficiency rating for {chemicals[chemicalName-1]} is {efficiencyRating}\n");

            //Sample the live amount of germs left after testing



            //Display each chemicals efficiency rating over the 5 tests

            //Loop 5 times
            for (int chemicalTest = 0; chemicalTest < 5; chemicalTest++)
            {
                

                
            }

        }
        static void Main(string[] args)
        {
            OneChemical();
        }
    }
}
