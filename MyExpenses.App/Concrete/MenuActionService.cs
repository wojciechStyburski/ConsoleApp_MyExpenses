using MyExpenses.App.Common;
using MyExpenses.Domain.Entity;

namespace MyExpenses.App.Concrete;

public class MenuActionService : BaseService<MenuAction>
{
    public MenuActionService()
    {
        Initialize();
    }

    public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        => Items.Where(x => x.MenuName == menuName).ToList();

    private void Initialize()
    {
        AddItem(new MenuAction(1, "Add expense", "Main"));
        AddItem(new MenuAction(2, "Delete expense", "Main"));
        AddItem(new MenuAction(3, "Show expense details", "Main"));
        AddItem(new MenuAction(4, "Show all expenses", "Main"));
        AddItem(new MenuAction(5, "Summary expenses by type", "Main"));
        AddItem(new MenuAction(6, "Summary expenses by day", "Main"));

        AddItem(new MenuAction(1, "Food", "ExpenseTypes"));
        AddItem(new MenuAction(2, "Clothes", "ExpenseTypes"));
        AddItem(new MenuAction(3, "Fuel", "ExpenseTypes"));
        AddItem(new MenuAction(4, "Bills", "ExpenseTypes"));
        AddItem(new MenuAction(5, "Relax", "ExpenseTypes"));
        AddItem(new MenuAction(6, "Electronics", "ExpenseTypes"));
        AddItem(new MenuAction(7, "Other", "ExpenseTypes"));

        AddItem(new MenuAction(1, "Today", "ExpenseDate"));
        AddItem(new MenuAction(2, "Other", "ExpenseDate"));
    }
}