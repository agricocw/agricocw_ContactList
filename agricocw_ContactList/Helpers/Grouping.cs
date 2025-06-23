public class Grouping<K, T> : List<T>
{
    public K Name { get; private set; }

    public Grouping(K name, IEnumerable<T> items) : base(items)
    {
        Name = name;
    }
}
