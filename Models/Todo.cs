namespace Todo.Models;

public class Todo
{
    private static int _nextId = 0;
    public int Id { get; } = _nextId++;
    public string? Title { get; set; }
    public string? Detail { get; set; }
}