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
        private double miles;

        private double feet;
        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
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
    
        private void CalculateFeet()
        {
            Console.Write("value")    
        }
        private void OutputFeet()
        {
            Console.Write("value")

        }
    }
}
