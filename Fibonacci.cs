using System;
public class Program
{
    public static void Main()
    {
        int firstNumber = 0, 
        SecondNumber = 1,
        nextNumber,
        numberOfElements;
        Console.Write("Number of elements: "); 
        numberOfElements = int.Parse(Console.ReadLine());
        if(numberOfElements < 2)
        {
            Console.Write("Print number greater than two");
        }
        else
        {
            Console.Write(firstNumber + " " + SecondNumber + " ");
            for(int i = 2; i < numberOfElements; i++)
            {
                nextNumber = firstNumber + SecondNumber;
                Console.Write(nextNumber + " ");
                firstNumber = SecondNumber;
                SecondNumber = nextNumber;
            }
        }

        Console.ReadKey();
    }
}