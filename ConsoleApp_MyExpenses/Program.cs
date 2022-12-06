const string FILE_NAME = @"c:\temp\ImportExpenses.xlsx";

var menuActionService = new MenuActionService();
var expenseManager = new ExpenseManager(menuActionService);

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
            expenseManager.AddNewExpense();
            break;
        case '2':
            expenseManager.RemoveExpense();
            break;
        case '3':
            expenseManager.ShowExpenseDetails();
            break;
        case '4':
            expenseManager.ShowAllExpenses();
            break;
        case '5':
            expenseManager.ShowSummaryByType();
            break;
        case '6':
            expenseManager.ShowSummaryByDay();
            break;
        default:
            Console.Write(" => [Selected action not allowed, try again!]");
            break;
    }

    Console.WriteLine($"{Environment.NewLine}====================================================");
}


