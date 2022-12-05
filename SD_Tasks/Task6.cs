using System.Threading.Channels;

namespace SD_Tasks;

public class Task6
{
    //Zadanie 1 - Napisz program, który stworzy dwie zmienne int i sprawdzi czy są równe czy nie
    public void Compare()
    {
        int a = 5;
        int b = 5;
        string message = a == b 
            ? $"{a} i {b} są równe" 
            : $"{a} i {b} nie są równe";
        Console.WriteLine(message);
    }

    //Zadanie 2 - Napisz program, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta
    public void CheckEvenness()
    {
        Console.Write("Type number to check: ");
        Int32.TryParse(Console.ReadLine(), out var userNumber);
        string message = userNumber % 2 == 0
            ? $"{userNumber} jest liczbą parzystą"
            : $"{userNumber} jest liczbą nieparzystą";
        Console.WriteLine(message);
    }
    //Zadanie 3 - Napisz program, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nie
    public void CheckPositivity()
    {
        Console.Write("Type number to check: ");
        Int32.TryParse(Console.ReadLine(), out var userNumber);
        string message = userNumber > 0
            ? $"{userNumber} jest liczbą dodanią"
            : $"{userNumber} jest liczbą ujemną";
        Console.WriteLine(message);
    }
    //Zadanie 4 - Napisz program, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym
    public void CheckLeapYear()
    {
        Console.Write("Type year to check: ");
        Int32.TryParse(Console.ReadLine(), out var userYear);
        string message = ((userYear % 4 == 0) && (userYear % 100 != 0)) || (userYear % 400 == 0)
            ? $"{userYear} jest rokiem przestępnym"
            : $"{userYear} jest nie rokiem przestępnym";
        Console.WriteLine(message);
    }

    //Zadanie 5 - Napisz program, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentaora, predyztenta
    public void CheckAge()
    {
        Console.Write("Type age to check: ");
        Int32.TryParse(Console.ReadLine(), out var userAge);
        string message = userAge switch
        {
            <= 21 => "Możesz zostać posłem",
            <= 22 => "Możesz zostać premierem",
            <= 30 => "Możesz zostać seatorem",
            <= 35 => "Możesz zostać prezydentem",
            _ => "Możesz zostać każdym"
        };
        Console.WriteLine(message);
    }
    //Zadanie 6 - Napisz program, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu 
    public void CheckHeight()
    {
        Console.Write("Type height to check: ");
        Int32.TryParse(Console.ReadLine(), out var userHeight);
        string message = userHeight switch
        {
            <= 140 => "Jesteś krasnoludem",
            <= 160 => "Jesteś trochę mniejszym krasnoludem",
            <= 180 => "Jesteś normalnego wzrostu",
            <= 200 => "Jesteś wielkoludem",
            _ => "Jesteś gigantem"
        };
        Console.WriteLine(message);
    }
    //Zadanie 7 - Napisz program, który pobierze od użytkownika  liczby i sprawdzi, która jest największa
    public void CheckMaxNumber()
    {
        Console.Write("Type first number: ");
        Int32.TryParse(Console.ReadLine(), out var firstNumber);

        Console.Write("Type second number: ");
        Int32.TryParse(Console.ReadLine(), out var secondNumber);

        Console.Write("Type third number: ");
        Int32.TryParse(Console.ReadLine(), out var thirdNumber);

        int[] numbers = { firstNumber, secondNumber, thirdNumber };
        Array.Sort(numbers);
        Array.Reverse(numbers);
        int maxNumber = numbers[0];

        Console.WriteLine($"{maxNumber} jest największą z podanych liczb");
    }

    /*
     * Zadanie 8 - Napisz program, który sprawdzi czy kandydat może ubiegać się o miejsce wg kryteriów
     * Matematyka > 70
     * Fizyka > 50
     * Chemia > 45
     * Łączny wynik z przedmiotów powyżej 180
     * LUB
     * Wynik z matematyki i 1 przemiotu powyżej 150
    */
    public void CheckResults()
    {
        int mathResult = 80;
        int physicsResult = 71;
        int chemistryResult = 0;
        bool isAccepted = false;


        if (mathResult > 70 && physicsResult > 45 && chemistryResult > 45 && (mathResult + physicsResult + chemistryResult) > 180)
            isAccepted = true;

        if (mathResult + physicsResult > 150)
            isAccepted = true;

        if (mathResult + chemistryResult > 150)
            isAccepted = true;

        string result = isAccepted
            ? "Kandydat dopuszczony do rekrutacji"
            : "Kandydat nie dopuszczony do rekrutacji";

        Console.WriteLine(result);
    }
    /*
     * Zadanie 9 - Napisz program, który odczyta temperaturę i zwróci nazwę jak w poniższych kryteriach
     * < 0 - cholernie piździ
     * 0 - 10 - zimno
     * 10 - 20 - chłodno
     * 20 - 30 - w sam raz
     * 30 - 40 - zaczyna być słabo bo gorąco
     * >= 40 - wyprowadzam się na alaskę
    */
    public void CheckTemperature()
    {
        int temperature = 40;
        string result = temperature switch
        {
            < 0 => "cholernie piździ",
            > 0 when temperature <= 10 => "Zimno",
            > 10 when temperature <= 20 => "Chłodno",
            > 20 when temperature <= 30 => "W sam raz",
            > 30 when temperature < 40 => "Zaczyna być słabo, bo gorąco",
            >= 40 => "Wyprowadzam się na alaskę"
        };

        Console.WriteLine(result);
    }
    //Zadanie 10 - Napisz program, ktory sprawdzi czy z 3 podanych długości można stworzyć trójkąt 
    public void CheckTriangle()
    {
        int a = 40;
        int b = 55;
        int c = 65;

        int[] triangleSide = { a, b, c };
        Array.Sort(triangleSide);
        var longestSide = triangleSide[^1];
        var mediumSide = triangleSide[1];
        var shortestSide = triangleSide[0];

        string result = longestSide < (mediumSide + shortestSide)
            ? "Można zbudować trójkąt"
            : "Nie można zbudować trójkąta";

        Console.WriteLine(result);
    }
    //Zadanie 11 - Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli 
    public void TranslateMark()
    {
        int degree = 3;
        string result = degree switch
        {
            1 => "Niedostateczny",
            2 => "Dopuszczający",
            3 => "Dostateczny",
            4 => "Dobry",
            5 => "Bardzo dobry",
            6 => "Celujący"
        };
        Console.WriteLine(result);
    }
    //Zadanie 12 - Napisz program, ktory pobierze numer dnia tygodnia i wyświetli jego nazwę
    public void DayOfTheWeek()
    {
        Console.Write("Type number of week day: ");
        Int32.TryParse(Console.ReadLine(), out var weekDayNumber);
        string result = weekDayNumber switch
        {
            1 => "Poniedziałek",
            2 => "Wtorek",
            3 => "Środa",
            4 => "Czwartek",
            5 => "Piątek",
            6 => "Sobota",
            7 => "Niedziela"
        };

        Console.WriteLine(result);
    }

    //Zadanie 13 -- 


    
}