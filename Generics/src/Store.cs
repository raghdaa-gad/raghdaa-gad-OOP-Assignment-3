public class Store <T>
{
    
private List<T> items = new();
 public void Add(T item)
{
    items.Add(item);
}

public T? GetById(int id)
{
    foreach (T item in items)
    {
        if (item.Id == id)
        {
            return item;
        }
    }

    return null;
}

public List<T> GetAll()
{
    return items;
}

public void Remove(int id)
{
    T? item = GetById(id);

    if (item != null)
    {
        items.Remove(item);
    }
}

}