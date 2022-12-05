namespace SD_Tasks;

public class Task3
{
    /*
        Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość przekątnej. 
        (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())
    */

    public double CalculateDiagonal(double width, double length)
    {
        int power = 2;
        var result = Math.Sqrt(Math.Pow(width, power) + Math.Pow(length, power));

        return result;
    }

}