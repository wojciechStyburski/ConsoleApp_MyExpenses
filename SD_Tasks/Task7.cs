using System;

namespace SD_Tasks;

public class Task7
{
    //Zadanie 1 - Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.
    private bool isPrime(int a)
    {
        for (int i = 2; i <= Math.Sqrt(a); i++)
        {
            if (a % i == 0)
                return false;
        }

        return true;
    }
    public void CheckPrimeNumbers()
    {
        int primeCounter = 0;
        for(int i = 2; i < 100; ++i)
        {
            if (isPrime(i))
            {
                primeCounter++;
            }
                
        }

        Console.WriteLine(primeCounter);
    }
    //Zadanie 2 - Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.
    public void SearchEvenNumbers()
    {
        int i = 1;
        int end = 1000;
        do
        {
            if (i % 2 == 0)
                Console.WriteLine($"Parzysta: {i}");
            i++;

        } while (i <= end);
    }
    //Zadanie 3 - Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie
    /*
     * Ciąg Fibonacciego jest ciągiem rekurencyjnym. Każdy wyraz, oprócz dwóch pierwszych jest sumą dwóch poprzednich wyrazów.
     * Pierwszy i drugi element ciągu jest równy 1, a każdy następny otrzymujemy dodając do siebie dwa poprzednie.
     */
    private int FibonacciSequence(int n)
    {
        return (n <= 2) ? 1 : FibonacciSequence(n - 1) + FibonacciSequence(n - 2);
    }

    public void FibonacciSequenceHandler()
    {
        int number = 10;
        Console.WriteLine($"{number} wyraz ciągu Fibonacciego to : {FibonacciSequence(10)}");
    }
    //Zadanie 4 - Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby
    public void CreatePyramidOfNumbers()
    {
        Console.Write("Type number: ");
        Int32.TryParse(Console.ReadLine(), out var levels);
        for (int i = 1; i <= levels; ++i)
        {
            Console.WriteLine(i);
        }
    }
    //Zadanie 5 - Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.
    public void NumberPower()
    {
        for (int i = 1; i <= 20; ++i)
        {
            double power = Math.Pow(i, 3);
            Console.WriteLine($"3-potęga liczby {i} wynosi: {power}");
        }
    }
    //Zadanie 6 - Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków
    public void ReverseLetters()
    {
        string pattern = "Abcdefg";
        char[] charArray = pattern.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine($"Odwórcony ciąg znaków dla wyrażenia {pattern} to: {new string(charArray)}");
    }
}
