public struct ToDoMemento
{
    public ToDoOnDate[] DateToDos;
}

public struct ToDoOnDate
{
    public ToDoItem[] ToDos;
}

public struct ToDoItem
{
    public string Priority;
    public string ToDo;
}
