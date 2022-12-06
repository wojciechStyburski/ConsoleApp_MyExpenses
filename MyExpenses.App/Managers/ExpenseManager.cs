using MyExpenses.App.Concrete;
using MyExpenses.App.Utlis;
using MyExpenses.Domain.Entity;
using MyExpenses.Domain.Utils;
using static MyExpenses.Domain.Utils.Helpers;

namespace MyExpenses.App.Managers;

public class ExpenseManager
{
    private readonly MenuActionService _menuActionService;
    private readonly ExpenseService _expenseService;
    private const string EXPENSE_TYPE_MENU_NAME = "ExpenseTypes";
    private const string EXPENSE_DATE_MENU_NAME = "ExpenseDate";

    public ExpenseManager(MenuActionService menuActionService)
    {
        _expenseService = new ExpenseService();
        _menuActionService = menuActionService;
    }

    private int GetExpenseIdFromUser()
    {
        Console.Write($"{Environment.NewLine}Type expense id: ");
        int.TryParse(Console.ReadLine(), out var expenseId);

        return expenseId;
    }

    private DateTime GetExpenseDateFromUser(int expenseDateChoice)
    {
        DateTime expenseDate = default;
        if (expenseDateChoice == 2)
        {
            Console.Write($"{Environment.NewLine}Type expense date: ");
            DateTime.TryParse(Console.ReadLine(), out expenseDate);
        }
        else
        {
            expenseDate = DateTime.Now;
        }
        return expenseDate.Date;
    }

    private void ShowMenuOptions(List<MenuAction> actions)
    {
        foreach (var action in actions)
        {
            Console.WriteLine($"{action.Id} --> {action.Name}");
        }
    }

    public void AddNewExpense()
    {
        var expenseTypes = _menuActionService.GetMenuActionsByMenuName(EXPENSE_TYPE_MENU_NAME);
        Console.WriteLine($"{Environment.NewLine}Please, select expense type");
        ShowMenuOptions(expenseTypes);
        Console.Write("Your choice: ");
        int.TryParse(Console.ReadKey().KeyChar.ToString(), out var expenseTypeId);

        var expenseDates = _menuActionService.GetMenuActionsByMenuName(EXPENSE_DATE_MENU_NAME);
        Console.WriteLine($"{Environment.NewLine}Please, select expense date");
        ShowMenuOptions(expenseDates);
        Console.Write("Your choice: ");
        int.TryParse(Console.ReadKey().KeyChar.ToString(), out var expenseDateChoice);
        var expenseDate = GetExpenseDateFromUser(expenseDateChoice);

        var expenseId = _expenseService.GetLastId() + 1;

        Console.Write($"{Environment.NewLine}Type value for new expense: ");
        double.TryParse(Console.ReadLine(), out var expenseValue);

        _expenseService.AddNewExpense(new Expense(expenseId, (Helpers.ExpenseType) expenseTypeId, expenseValue, expenseDate));

        Console.Write($"New expense with id {expenseId} added to app!");
    }

    public void RemoveExpense()
    {
        var expenseId = GetExpenseIdFromUser();
        _expenseService.RemoveExpense(expenseId);
        Console.Write("Expense removed from the app!");
    }

    public void ShowExpenseDetails()
    {
        var expenseId = GetExpenseIdFromUser();
        var expenseDetails = _expenseService.GetExpenseById(expenseId);
        var expense = new List<Expense>() { expenseDetails };
        Console.Write($"{Environment.NewLine}{expense.ToStringTable(new[] { "Id", "Category", "Value", "Date"}, a => a.Id, a => a.Type, a => a.Value, a => a.Date.ToShortDateString())}");
    }

    public void ShowAllExpenses()
    {
        var expenses = _expenseService.GetAllExpenses();
        Console.Write($"{Environment.NewLine}{expenses.ToStringTable(new[] { "Id", "Category", "Value", "Date" }, a => a.Id, a => a.Type, a => a.Value, a => a.Date.ToShortDateString())}");
    }

    public void ShowSummaryByType()
    {
        var expenses = _expenseService.GetAllExpenses();
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

    public void ShowSummaryByDay()
    {
        var expenses = _expenseService.GetAllExpenses();
        var expenseSummary = expenses
            .GroupBy(x => x.Date.Date)
            .Select(x => new
            {
                ExpenseDate = x.Key.Date,
                Count = x.Count(),
                Value = x.Sum(y => y.Value)
            }).ToList();

        Console.Write($"{Environment.NewLine}{expenseSummary.ToStringTable(new[] { "Date", "Count", "Total value" }, a => a.ExpenseDate.ToShortDateString(), a => a.Count, a => a.Value)}");
    }
}