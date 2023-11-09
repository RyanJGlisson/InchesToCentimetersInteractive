using System;

class Program {
  public static void Main (string[] args) {
     //Establish
        const double centInInch = 2.54;
        double inches;
        double centimeters;

      //Get input from user
        Console.Write("Enter length in inches: ");
        string input = Console.ReadLine();

      if (double.TryParse(input, out inches)) {
          // Calculate centimeters
          centimeters = inches * centInInch;

        
          // Display the result
          Console.WriteLine(inches + " inches is " + centimeters + " centimeters");
      } else {
          // Display an error message for invalid input
          Console.WriteLine("Invalid input. Please enter a valid number for inches.");
        }
    }
  }
