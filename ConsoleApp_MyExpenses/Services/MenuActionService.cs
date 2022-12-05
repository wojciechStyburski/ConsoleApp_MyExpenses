namespace ConsoleApp_MyExpenses.Services;

public class MenuActionService
{
    private List<MenuAction> _actions { get; set; }
    public MenuActionService()
    {
        _actions = new List<MenuAction>();
    }

    public void AddNewAction(int id, string name, string menuName)
    {
        var newMenuAction = new MenuAction(id, name, menuName);
        _actions.Add(newMenuAction);
    }

    public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        => _actions.Where(x => x.MenuName == menuName).ToList();
}