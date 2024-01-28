namespace Todo.Models;

public class Todo
{
    public int Id { get; set; }
    public string? Title { get; set; }
    
    public string? Detail { get; set; }
    
    public string? Status { get; set; }
}