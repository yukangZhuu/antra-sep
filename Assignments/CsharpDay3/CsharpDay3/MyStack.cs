namespace CsharpDay3;

public class MyStack<T>
{
    private List<T> elements = new List<T>();
    
    public int Count()
    {
        return elements.Count;
    }
    
    public T Pop()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty!");
        }

        T item = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return item;
    }
    
    public void Push(T item)
    {
        elements.Add(item);
    }

    public void printStack()
    {
        Console.WriteLine("Stack: " + string.Join(", ", elements));
    }
}