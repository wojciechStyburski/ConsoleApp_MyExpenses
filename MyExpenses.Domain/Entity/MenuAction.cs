using MyExpenses.Domain.Common;

namespace MyExpenses.Domain.Entity;
public class MenuAction : BaseEntity
{
    public string Name { get; private set; }
    public string MenuName { get; private set; }

    public MenuAction(int id, string name, string menuName)
    {
        Id = id;
        Name = name;
        MenuName = menuName;
    }
}