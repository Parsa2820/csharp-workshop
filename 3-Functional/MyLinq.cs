namespace _3_Functional;
public static class MyLinq
{
    // Extension method
    public static IEnumerable<T> MySelect<T>(this IEnumerable<T> source, Func<T, T> selector)
    {
        foreach (var item in source)
        {
            // Lazy evaluation
            yield return selector(item);
        }
    }
}