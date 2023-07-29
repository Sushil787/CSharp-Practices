
using System;
using CustomException;
namespace ExceptionHandlingSpace

{

public class Program
{
    public static void divide()
    {
        try
        {

            int numerator = 10;
            int denominator = 2;
            int result = numerator / denominator; // This will cause a DivideByZeroException
            double age  = Convert.ToDouble(Console.ReadLine());
            if(age<12){
                throw new AgeUnderTwelveException("Age is under Twelve");
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            // You can log the exception, display a user-friendly error message, or take other appropriate actions.
        }
        catch (Exception ex) // Generic catch block to catch any other unhandled exceptions
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
        finally
        {
            // This block will be executed regardless of whether an exception occurred or not.
            Console.WriteLine("Finally block executed.");
        }

        Console.WriteLine("Program continues after exception handling.");
    }
}
    
}