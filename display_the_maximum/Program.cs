using System;

// Write a program which takes two numbers from the 
// console and displays the maximum of the two.

public class DisplayTheMax
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a random number: ");
        var temp = Console.ReadLine();
        int Input1 = Convert.ToInt32(temp);

        Console.WriteLine("Enter a random Secondary Number: ");
        temp = Console.ReadLine();
        int Input2 = Convert.ToInt32(temp);

        var toPrint = (Input1 > Input2) ? "First number was bigger" : " \n Second number next to biggest";
        Console.WriteLine(toPrint);

        
        
    }
}