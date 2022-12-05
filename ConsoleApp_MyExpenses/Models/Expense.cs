namespace ConsoleApp_MyExpenses.Models;
public class Expense
{
    public int Id { get; private set; }
    public ExpenseType Type { get; private set; }
    public double Value { get; private set; }

    public Expense(int id, ExpenseType expenseType, double value)
    {
        Id = id;
        Type = expenseType;
        Value = value;
    }
}