using System.Collections;
using System.Collections.Generic;

public class Stack<T> : IEnumerable<T>
{
    private List<T> items;

    public Stack()
    {
        items = new List<T>();
    }

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (items.Count == 0)
        {
            return default(T);
        }

        T item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }

    public int Count
    {
        get { return items.Count; }
    }

    public T Peek()
    {
        if (items.Count == 0)
        {
            return default(T);
        }

        return items[items.Count - 1];
    }

    // Implementasi enumerator
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = items.Count - 1; i >= 0; i--)
        {
            yield return items[i];
        }
    }

    // Implementasi IEnumerator non-generic untuk compatibility
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}