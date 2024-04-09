namespace Assignment_02;

public class ListManager
{
    private List<string> items = new List<string>();

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, -- to clear, exit to quit):");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            ProcessCommand(input);
            Console.WriteLine("Current List: " + ToString());
        }
    }

    private void ProcessCommand(string command)
    {
        if (command.StartsWith("+"))
        {
            AddItem(command.Substring(1).Trim());
        }
        
        if (command == "--")
        {
            ClearItems();
        } 
        else if (command.StartsWith("-"))
        {
            RemoveItem(command.Substring(1).Trim());
        }
    }

    private void AddItem(string item)
    {
        items.Add(item);
    }

    private void RemoveItem(string item)
    {
        items.Remove(item);
    }

    private void ClearItems()
    {
        items.Clear();
    }

    public override string ToString()
    {
        return String.Join(", ", items);
    }
}