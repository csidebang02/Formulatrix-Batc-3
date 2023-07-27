class TodoItem
{
    public string Title { get; set; }
    public bool IsDone { get; set; }

    public TodoItem(string title)
    {
        Title = title;
        IsDone = false;
    }
}

class TodoList
{
    private List<TodoItem> items;

    public TodoList()
    {
        items = new List<TodoItem>();
    }

    public void AddTodoItem(string title)
    {
        var newItem = new TodoItem(title);
        items.Add(newItem);
    }

    public void MarkItemAsDone(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            items[index].IsDone = true;
        }
    }

    public void PrintTodoList()
    {
        Console.WriteLine("To-Do List:");
        for (int i = 0; i < items.Count; i++)
        {
            var status = items[i].IsDone ? "[Done]" : "[Not Done]";
            Console.WriteLine($"{i + 1}. {status} {items[i].Title}");
        }
    }

    // Destructor untuk menyimpan To-Do List ke dalam file sebelum objek dihapus dari memori.
    ~TodoList()
    {
        SaveTodoListToFile();
        Console.WriteLine("To-Do List telah disimpan ke dalam file.");
    }

    private void SaveTodoListToFile()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("todo_list.txt"))
            {
                foreach (var item in items)
                {
                    writer.WriteLine($"{item.Title},{item.IsDone}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Gagal menyimpan To-Do List: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        var todoList = new TodoList();

        todoList.AddTodoItem("Mengerjakan tugas kuliah");
        todoList.AddTodoItem("Beli bahan makanan");
        todoList.AddTodoItem("Olahraga selama 30 menit");

        todoList.PrintTodoList();

        // Simulasi aplikasi ditutup.
        todoList = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Aplikasi telah ditutup.");
    }
}
