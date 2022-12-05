using ConsoleApp_MyExpenses.Services;

const string FILE_NAME = @"c:\temp\ImportExpenses.xlsx";

static MenuActionService Initialize(MenuActionService menuActionService)
{
    menuActionService.AddNewAction(1, "Add expense", "Main");
    menuActionService.AddNewAction(2, "Delete expense", "Main");
    menuActionService.AddNewAction(3, "Show expense details", "Main");
    menuActionService.AddNewAction(4, "Show all expenses", "Main");
    menuActionService.AddNewAction(5, "Summary expenses by type", "Main");

    menuActionService.AddNewAction(1, "Food", "ExpenseTypes");
    menuActionService.AddNewAction(2, "Clothes", "ExpenseTypes");
    menuActionService.AddNewAction(3, "Fuel", "ExpenseTypes");
    menuActionService.AddNewAction(4, "Bills", "ExpenseTypes");
    menuActionService.AddNewAction(5, "Relax", "ExpenseTypes");
    menuActionService.AddNewAction(6, "Electronics", "ExpenseTypes");
    menuActionService.AddNewAction(7, "Other", "ExpenseTypes");

    return menuActionService;
}

var menuActionService = new MenuActionService();
menuActionService = Initialize(menuActionService);

var expenseService = new ExpenseService();

Console.WriteLine("Welcome to MyExpenses app!");
while (true)
{
    Console.WriteLine("Please let me know what you want to do");
    var mainMenu = menuActionService.GetMenuActionsByMenuName("Main");
    
    foreach (var menu in mainMenu)
    {
        Console.WriteLine($"{menu.Id} --> {menu.Name}");
    }

    Console.Write("Your choice: ");
    var operation = Console.ReadKey();
    switch (operation.KeyChar)
    {
        case '1':
            expenseService.AddNewExpenseView(menuActionService);
            break;
        case '2':
            expenseService.RemoveExpenseView();
            break;
        case '3':
            expenseService.ShowExpenseDetailsView();
            break;
        case '4':
            expenseService.ShowAllExpensesView();
            break;
        case '5':
            expenseService.ShowSummaryByTypeView();
            break;
        default:
            Console.Write(" => [Selected action not allowed, try again!]");
            break;
    }

    Console.WriteLine($"{Environment.NewLine}====================================================");
}


