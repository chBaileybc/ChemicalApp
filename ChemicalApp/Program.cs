using System;
using System.Collections.Generic;

namespace ChemicalApp
{
    class Program
    {

        //Global variables

        static string HighChemical = "";
        static float HighChemicalRating = -1;

        static string LowChemical = "";
        static int LowChemicalRating = 1000;

        static List<string> chemicals = new List<string>()
        { "Propane", "Cyanide", "Bleach", "Hot water","Alcohol"};

        //methods and/or functions

        static int CheckInt(string question, int min, int max)
        {
            while (true)
            {
                try
                {

                    Console.WriteLine(question);
                    int userInt = Convert.ToInt32(Console.ReadLine());

                    if ((userInt < 1) || (userInt > 5))
                    {
                        //Display an error message letting the user know that the number they entered is too high/low
                        Console.WriteLine("\nError: Enter a number 1-5 in order to test a chemical");

                    }
                    else
                    {
                        return userInt;
                    }
                }

                catch (System.FormatException)
                {
                    //Display an error message letting the user know that what they entered is not a number
                    Console.WriteLine("\nError: Enter a number 1-5 in order to test a chemical\n");

                }
            }
        }





        static string CheckFlag()
        {
            while (true)
            {
                //Get users choice

                Console.WriteLine("\nPress <ENTER> to continue testing chemicals or type 'XXX' then <ENTER> to quit\n");

                string userInput = Console.ReadLine();

                //Convert user input to uppercase

                userInput = userInput.ToUpper();

                if (userInput.Equals("XXX") || userInput.Equals(""))
                {
                    return userInput;
                }

                //Display error message if entered letters wrong

                Console.WriteLine("\nError: Please read the information carefully");
                

            }
        }

        static void OneChemical()
        {
            //Enter and store chemical name



            int chemicalName = CheckInt("\n   Enter the number for the chemical you want to test:\n\n" +
                              "   <><><><><><><><><><><><><><><><><><><><><>\n" +
                              "   <>  1.Propane                           <>\n" +
                              "   <>  2.Cyanide                           <>\n" +
                              "   <>  3.Bleach                            <>\n" +
                              "   <>  4.Hot water                         <>\n" +
                              "   <>  5.Alcohol                           <>\n" +
                              "   <><><><><><><><><><><><><><><><><><><><><>\n", 1, 5);

            //Display chemical

            Console.WriteLine($"\n{chemicals[chemicalName - 1]}\n");

            //Loop 5 times

            float sumEfficiency = 0;

            for (int chemicalTest = 0; chemicalTest < 5; chemicalTest++)
            {
                //Randomly generate a random amount of germs

                Random randGen = new Random();

                int germCount = randGen.Next(2000, 2500);

                Console.WriteLine($"There are {germCount} germs to be tested");

                //Display an amount of time waited for testing

                int germTime = randGen.Next(5, 10);

                Console.WriteLine($"You have waited {germTime}s after using {chemicals[chemicalName - 1]} on the germs");

                int afterGerm = randGen.Next(1000, 1500);

                Console.WriteLine($"There are {afterGerm} germs remaining\n");

                //Add chemical to amount of germs

                float chemicalEfficiency = (float)(germCount - afterGerm) / germTime;

                sumEfficiency += chemicalEfficiency;

            }

            //Calculate the efficiecy rating of that chemical tested

            float finalEfficiency = sumEfficiency / 5;

            //Display efficiency rating of the chemical

            Console.WriteLine($"\nThe efficiency rating of {chemicals[chemicalName - 1]} is {finalEfficiency}");

            //Determine the chemicals with the lowest and highest efficiency rating

            if (finalEfficiency > HighChemicalRating)
            {
                HighChemicalRating = finalEfficiency;
                HighChemical = chemicals[chemicalName - 1];
            }
            if (finalEfficiency < LowChemicalRating)
            {
                LowChemicalRating = (int)finalEfficiency;
                LowChemical = chemicals[chemicalName - 1];
            }
        }
        
        //When run or/ main process
        static void Main(string[] args)
        {

            string flagMain = "";

            //Title of ChemicalApp

            Console.WriteLine("\n" +
            @"  _______  __                    __               __       _____                " + "\n" +
            @" /    ___\|  |__   ____   _____ |__| ____ _____  |  |     /  _  \ ______ ______  "+ "\n" +
            @"/    \  \/|  |  \_/ __ \ /     \|  |/ ___\\__  \ |  |    /  /_\  \\____ \\____ \ "+ "\n" +
            @"\     \___|   Y  \  ___/|  Y Y  \  \  \___ / __ \|  |__ /    |    \  |_> >  |_> >"+ "\n" +
            @" \______  /___|  /\___  >__|_|  /__|\___  >____  /____/ \____|__  /   __/|   __/ "+ "\n" +
            @"        \/     \/     \/      \/        \/     \/               \/|__|   |__|    "+ "\n");
            Console.WriteLine("<~-------------------------------------------------------------------------------------~>\n");

            //Description of ChemicalApp/Purpose

            Console.WriteLine("Introduction:\n" +
                "Chemical App will let you choose between 5 different chemicals.\n" + 
                "It calculates the efficiency rating of the chemical tested over 5 individual tests.\n" +
                "It will then display a summary of the 5 tests and its efficiency rating\n" +
                "lastly, it will display the highest and lowest efficiency ratings ove three chemicals tested ");
            Console.WriteLine("\n<~-------------------------------------------------------------------------------------~>\n");

            Console.WriteLine("Press <Enter> to continue...");
            Console.ReadLine();
            Console.Clear();

            //Loop(While) OneChemical() until user types "XXX" or "xxx"
            while (!flagMain.Equals("XXX"))
            {
                OneChemical();

                flagMain = CheckFlag();

                
            }

            //Display the chemicals with the highest and lowest rating
            Console.WriteLine($"\nThe chemical with the highest rating is {HighChemical} with a rating of {HighChemicalRating}\n");

            Console.WriteLine($"\nThe chemical with the lowest rating is {LowChemical} with a rating of {LowChemicalRating}\n");

        }
    }
} 