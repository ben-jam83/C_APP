using System;

namespace ConsoleAppProject.App01
{ 
    /// <summary>
    /// This app will convert feet to miles
    /// </summary>
    /// <author>
    /// Ben
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double metres;

        /// <summary>
        /// 
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet ");
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles ");
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMetres()
        {
            OutputHeading("Converting Miles to Metres ");
            InputMiles();
            CalculateMetres();
            OutputMetres();
        }

        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n--------------------");
            Console.WriteLine(" Distance converter   ");
            Console.WriteLine("       By Ben         ");
            Console.WriteLine("--------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }
        /// <summary>
        /// Prompt the user to enter the miles 
        /// Input the miles as a double number
        /// </summary>
       
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }



        private void InputMetres()
        {
            Console.Write("Please enter the number of metres > ");
            string value = Console.ReadLine();
            metres = Convert.ToDouble(value);
        }

        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }



        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;    
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet! ");

        }
        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet is " + miles + " miles! ");

        }
        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " metres! ");

        }
    }
}
