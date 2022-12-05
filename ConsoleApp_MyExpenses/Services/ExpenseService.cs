using ConsoleApp_MyExpenses.Models;
using ConsoleApp_MyExpenses.Utlis;

namespace ConsoleApp_MyExpenses.Services;

public class ExpenseService
{
    private List<Expense> _expenses { get; set; }

    public ExpenseService()
    {
        _expenses = new();
    }

    private void AddExpense(int expenseId, int expenseTypeId, double expenseValue)
    {
        var newExpense = new Expense(expenseId, (ExpenseType)expenseTypeId, expenseValue);
        _expenses.Add(newExpense);
    }

    private void RemoveExpense(Expense expense)
        => _expenses.Remove(expense);

    private Expense GetExpenseById(int expenseId)
        => _expenses.FirstOrDefault(x => x.Id == expenseId);

    private List<Expense> GetAllExpenses()
        => _expenses;

    private int GetExpenseIdFromUser()
    {
        Console.Write($"{Environment.NewLine}Type expense id to: ");
        int.TryParse(Console.ReadLine(), out var expenseId);

        return expenseId;
    }

    public void AddNewExpenseView(MenuActionService menuActionService)
    {
        var expenseTypes = menuActionService.GetMenuActionsByMenuName("ExpenseTypes");
        Console.WriteLine($"{Environment.NewLine}Please, select expense type");

        foreach (var expenseType in expenseTypes)
        {
            Console.WriteLine($"{expenseType.Id} --> {expenseType.Name}");
        }

        Console.Write("Your choice: ");
        int.TryParse(Console.ReadKey().KeyChar.ToString(), out var expenseTypeId);

        Console.Write($"{Environment.NewLine}Type id for new expense: ");
        int.TryParse(Console.ReadLine(), out var expenseId);

        Console.Write("Type value for new expense: ");
        double.TryParse(Console.ReadLine(), out var expenseValue);

        AddExpense(expenseId, expenseTypeId, expenseValue);

        Console.Write("New expense added to app!");
    }

    public void RemoveExpenseView()
    {
        var expenseId = GetExpenseIdFromUser();
        var expenseToRemove = GetExpenseById(expenseId);
        RemoveExpense(expenseToRemove);
        Console.Write("Expense removed from the app!");
    }

    public void ShowExpenseDetailsView()
    {
        var expenseId = GetExpenseIdFromUser();
        var expenseToShow = GetExpenseById(expenseId);
        var expense = new List<Expense>() { expenseToShow };
        Console.Write($"{Environment.NewLine}{expense.ToStringTable(new[] { "Id", "Category", "Value" }, a => a.Id, a => a.Type, a => a.Value)}");
    }

    public void ShowAllExpensesView()
    {
        var expenses = GetAllExpenses();
        Console.Write($"{Environment.NewLine}{expenses.ToStringTable(new[] { "Id", "Category", "Value" }, a => a.Id, a => a.Type, a => a.Value)}");
    }

    public void ShowSummaryByTypeView()
    {
        var expenses = GetAllExpenses();
        var expenseSummary = expenses
            .GroupBy(t => t.Type)
            .Select(x => new
            {
                ExpenseType = x.Key,
                Count = x.Count(),
                Value = x.Sum(y => y.Value)
            }).ToList();

        Console.Write($"{Environment.NewLine}{expenseSummary.ToStringTable(new[] { "Type", "Count", "Total value" }, a => a.ExpenseType, a => a.Count, a => a.Value)}");
    }
}