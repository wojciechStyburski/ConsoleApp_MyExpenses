namespace ConsoleApp_MyExpenses.Models;
public class MenuAction
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string MenuName { get; private set; }

    public MenuAction(int id, string name, string menuName)
    {
        Id = id;
        Name = name;
        MenuName = menuName;
    }
}