using MyExpenses.App.Common;
using MyExpenses.Domain.Entity;

namespace MyExpenses.App.Concrete;

public class ExpenseService : BaseService<Expense>
{
    public void AddNewExpense(Expense expense) => AddItem(expense);
    public void RemoveExpense(int id)
    {
        var expense = GetItemById(id);
        if(expense != null)
            RemoveItem(expense);
    }
    public Expense GetExpenseById(int id) => GetItemById(id);

    public List<Expense> GetAllExpenses() => GetAllItems();
}