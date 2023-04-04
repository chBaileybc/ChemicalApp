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

            Console.WriteLine($"\n{chemicals[chemicalName - 1]}\n");

            //Loop 5 times

            float sumEfficiency = 0;

            for (int chemicalTest = 0; chemicalTest < 5; chemicalTest++)
            {
                //Randomly generate a random amount of germs

                Random randGen = new Random();

                int germCount = randGen.Next(2000, 2500);

                Console.WriteLine($"There are {germCount} germs\n");

                //Display an amount of time waited for testing

                int germTime = randGen.Next(5, 10);

                Console.WriteLine($"You have waited {germTime}s after using {chemicals[chemicalName - 1]} on the germs\n");

                int afterGerm = randGen.Next(1000, 1500);

                Console.WriteLine($"There are {afterGerm} germs remaining\n");

                //Add chemical to amount of germs

                float chemicalEfficiency = (float)(germCount - afterGerm) / germTime;

                sumEfficiency += chemicalEfficiency;
            }

            //Calculate the efficiecy rating of that chemical tested

            float finalEfficiency = sumEfficiency / 5;

            //Display efficiency rating of the chemical

            Console.WriteLine($"The efficiency rating of {chemicals[chemicalName - 1]} is {finalEfficiency}");

            //Display each chemicals efficiency rating over the 5 tests



        }

        static void CheckFlag()
        {
            while (true)
            {
                //Get users choice

                //Display error message
            }
        }
        
        
        static void Main(string[] args)
        {
            OneChemical();

            //Loop(While) OneChemical() until user types "XXX" or "xxx"

            string flagMain = "";

            while (!flagMain.Equals("XXX"))
            {
                flagMain = CheckFlag();
            }

            //Determine the chemicals with the highest rating and lowest rating

            //Display the chemicals with the highest and lowest rating
        }
    }
} 
