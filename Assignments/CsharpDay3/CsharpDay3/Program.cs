using CsharpDay3;
using CsharpDay3.Models;
using CsharpDay3.Repository;
// 1. Create a custom Stack class MyStack<T> that can be used with any data type which
//     has following methods
// 1. int Count()
// 2. T Pop()
// 3. Void Push()

MyStack<int> stack = new MyStack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.printStack();
Console.WriteLine($"Stack size: {stack.Count()}");
stack.Pop();
stack.Pop();
stack.printStack();
Console.WriteLine($"Stack size: {stack.Count()}");




// 2. Create a Generic List data structure MyList<T> that can store any data type.
//     Implement the following methods.
// 1. void Add (T element)
// 2. T Remove (int index)
// 3. bool Contains (T element)
// 4. void Clear ()
// 5. void InsertAt (T element, int index)
// 6. void DeleteAt (int index)
// 7. T Find (int index)

MyList<string> myList = new MyList<string>();
myList.Add("Jake");
myList.Add("Lily");
myList.InsertAt("Ben", 1);  
Console.WriteLine(myList.Find(0));  //Returns Jake
Console.WriteLine(myList.Contains("1"));  // Returns false
Console.WriteLine(myList.Remove(0));  // Removes and returns "Jake"
myList.Clear();  // Clears all items




// 3. Implement a GenericRepository<T> class that implements IRepository<T> interface
//     that will have common /CRUD/ operations so that it can work with any data source
// such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
//     on T were it should be of reference type and can be of type Entity which has one
//     property called Id. IRepository<T> should have following methods
// 1. void Add(T item)
// 2. void Remove(T item)
// 3. Void Save()
// 4. IEnumerable<T> GetAll()
// 5. T GetById(int id)
IRepository<Person> repository = new GenericRepository<Person>();
repository.Add(new Person(1, "Jake"));
repository.Add(new Person(2, "Ben"));
repository.Add(new Person(3, "Lily"));

Console.WriteLine("data in the repository:");
foreach (var person in repository.GetAll())
{
    Console.WriteLine($"Name: {person.Name}, ID: {person.Id}");
}

var p = repository.GetById(2);
repository.Remove(p);
Console.WriteLine("remove ID = 2:");
foreach (var person in repository.GetAll())
{
    Console.WriteLine($"Name: {person.Name}, ID: {person.Id}");
}

repository.Save();