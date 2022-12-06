using MyExpenses.App.Abstract;
using MyExpenses.Domain.Common;

namespace MyExpenses.App.Common;

public class BaseService<T> : IService<T> where T : BaseEntity
{
    public List<T> Items { get; set; }
    public BaseService() => Items = new();
    public List<T> GetAllItems() => Items;
    public T GetItemById(int id) => Items.SingleOrDefault(x => x.Id == id);
    public int GetLastId() => Items.Any() ? Items.OrderByDescending(x => x.Id).FirstOrDefault().Id : 0;
    public int AddItem(T item)
    {
        Items.Add(item);
        return item.Id;
    }
    public int UpdateItem(T item)
    {
        var entity = Items.SingleOrDefault(x => x.Id == item.Id);
        if (entity != null)
            entity = item;

        return entity.Id;
    }
    public void RemoveItem(T item) => Items.Remove(item);
}