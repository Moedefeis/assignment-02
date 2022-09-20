namespace Assignment2;

public static class Extensions
{
    public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items)
    {
        foreach (var outer in items)
        {
            foreach (var inner in outer)
            {
                yield return inner;
            }
        }
    }
    
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate)
    {
        foreach (var item in items)
        {
            if (predicate(item))
            {
                yield return item;
            }
        }
    }
}
