using System.Linq;

public class Store <T>
where T :class,IHasId
{
    
private Dictionary<int, T>  items = new();
 public void Add(T item)
{
    if (items.ContainsKey(item.Id))
      {
        throw new InvalidOperationException(
            $"An item with ID {item.Id} already exists.");}
    items.Add(item.Id,item);
}
public T? GetById(int id)
{
    if (items.TryGetValue(id, out T? item))
    {
        return item;
    }

    return null;
}

public IReadOnlyCollection<T> GetAll()
{
    return items.Values.ToList().AsReadOnly();
}

public void Remove(int id)
{
  items.Remove(id);
}

}