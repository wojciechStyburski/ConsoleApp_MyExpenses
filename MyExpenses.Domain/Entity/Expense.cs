using MyExpenses.Domain.Common;
using MyExpenses.Domain.Utils;

namespace MyExpenses.Domain.Entity;
public class Expense : BaseEntity
{
    public Helpers.ExpenseType Type { get; private set; }
    public double Value { get; private set; }

    public DateTime Date { get; private set; }

    public Expense(int id, Helpers.ExpenseType expenseType, double value, DateTime date)
    {
        Id = id;
        Type = expenseType;
        Value = value;
        Date = date;
    }
}