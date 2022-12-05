namespace SD_Tasks;

public class Task2
{
    /*
     * Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane.
    */
    public char Letter1 { get; set; } = 'a';
    public char Letter2 { get; set; } = 'b';
    public char Letter3 { get; set; } = 'c';
    public void PrintLetters()
    {
        Console.WriteLine($"Letter3: {Letter3}, Letter2: {Letter2}, Letter1: {Letter1}");
    }

}