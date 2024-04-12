namespace CsharpDay3;

public class MyList<T>
{
    private List<T> elements = new List<T>();
    
    public void Add(T element)
    {
        elements.Add(element);
    }
    
    public T Remove(int index)
    {
        if (index < 0 || index >= elements.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }

        T item = elements[index];
        elements.RemoveAt(index);
        return item;
    }
    
    public bool Contains(T element)
    {
        return elements.Contains(element);
    }
    
    public void Clear()
    {
        elements.Clear();
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > elements.Count) // Allow insertion at the end of the list
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }

        elements.Insert(index, element);
    }
    
    public void DeleteAt(int index)
    {
        if (index < 0 || index >= elements.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }

        elements.RemoveAt(index);
    }
    
    public T Find(int index)
    {
        if (index < 0 || index >= elements.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }

        return elements[index];
    }
}