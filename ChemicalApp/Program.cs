using System;
using System.Collections.Generic;

namespace ChemicalApp
{
    class Program
    {

        //Global variables

        

        //methods and/or functions



        static void OneChemical()
        {
            List<string> checmialChoice = new List<string>() 
            { 
                "Propane","Cyanide","Bleach","Hot water","Alcohol"
            };


            //Enter and store chemical name

            Console.WriteLine("Type a chemical from the either of the examples below:\n" +
                "1.Propane\n" +
                "2.Cyanide\n" +
                "3.Bleach\n" +
                "4.Hot water\n" +
                "5.Alcohol\n");

            string chemicalName = Console.ReadLine();

            //Display chemical

            Console.WriteLine($"{chemicalName}\n");

            //Randomly generate a random amount of germs

            Random randGen = new Random();

            int germCount = randGen.Next(1, 7500);

            Console.WriteLine($"There are {germCount} germs for testing");

            //Display an amount of time waited for testing

            int germTime = randGen.Next(1,30);

            Console.WriteLine($"You have waited {germTime}s after using {chemicalName}\n");

            //Add chemical to amount of germs



            //Sample the live amount of germs left after testing

            //Calculate the efficiecy rating of that chemical tested

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
