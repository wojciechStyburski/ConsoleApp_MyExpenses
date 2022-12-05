namespace ConsoleApp_MyExpenses.Models;

public class MenuAction
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string MenuName { get; set; }

    public MenuAction(int id, string name, string menuName)
    {
        Id = id;
        Name = name;
        MenuName = menuName;
    }
}