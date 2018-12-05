using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Pick a numer:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another numer:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing by two... ");
            Console.WriteLine(num1 + " devided by " + num2 + " equals " + num1 / num2);
            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            //Console.WriteLine(ex.Message);
            Console.WriteLine("Please enter a whole number");
            return;
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't devide by zero");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }

    }
}
