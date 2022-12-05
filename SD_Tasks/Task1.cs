namespace SD_Tasks;

public class Task1
{
    /*
     * Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane, które chcesz przetrzymywać to:
        a. Imię,
        b. Nazwisko
        c. Wiek
        d. Płeć (‘m’ albo ‘k’)
        e. PESEL
        f. Numer pracownika (np. 2509324094)
     */
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public char Gender { get; set; }
    public string Pesel { get; set; }
    public long EmployeeNumber { get; set; }
}