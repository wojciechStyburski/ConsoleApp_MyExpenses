using System.Runtime.CompilerServices;

namespace SD_Tasks;

public class Task5
{
    /*
        Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko,
        numer telefonu, adres email, wzrost, waga (np. 85,7)i spróbuj przekonwertować odpowiedź 
        do odpowiedniego typu danych używając metody: typDanych.Parse(odpowiedźOdUżytkownika). 
     */
    public void GetDataFromUser()
    {
        Console.WriteLine("Type first name: ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Type last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Type phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("Type email address: ");
        string emailAddress = Console.ReadLine();

        Console.WriteLine("Type age: ");
        int age = 0;
        int.TryParse(Console.ReadLine(), out age);

        Console.WriteLine("Type weight: ");
        double weight = 0;
        double.TryParse(Console.ReadLine(), out weight);
    }
}