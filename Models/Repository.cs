namespace Todo.Models;

public class Repository
{
    private static List<Todo> responses = new();

    public static IEnumerable<Todo> Responses => responses;

    public static void AddTodo(Todo newTodo)
    {
        responses.Add(newTodo);
    }
}