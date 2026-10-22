

public static class EnumerableExtensions
{
     public static  IEnumerable<T> Page<T>(this IEnumerable<T> source,int pageNumber,int pageSize)
    {
         if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        if (pageNumber < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(pageNumber));
        }

        if (pageSize < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(pageSize));
        }

        int itemsToSkip = (pageNumber - 1) * pageSize;
        int itemsSkipped = 0;
        int itemsReturned = 0;

        foreach (T item in source)
        {
            if (itemsSkipped < itemsToSkip)
            {
                itemsSkipped++;
                continue;
            }

            if (itemsReturned >= pageSize)
            {
                yield break;
            }

            itemsReturned++;
            yield return item;
        }
    }
      
        public static T? FindById<T>(
        this IEnumerable<T> source,
        int id) where T : IHasId
    {
        foreach (T item in source)
        {
            if (item.Id == id)
            {
                return item;
            }
        }

        return default;
    }


   public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(
        this IEnumerable<T> source)       where T : IHasId
    {
        Dictionary<int, T> result = new();

        foreach (T item in source)
        {
            if (result.ContainsKey(item.Id))
            {
                throw new InvalidOperationException(
                    $"An item with ID {item.Id} already exists.");
            }

            result.Add(item.Id, item);
        }

        return result;
    }

}