namespace Todo.Models;

public class Repository
{
    private static List<Todo> responses = new();

    public static IEnumerable<Todo> Responses => responses;

    public static void AddTodo(Todo newTodo)
    {
        responses.Add(newTodo);
    }

    public static void DoneTodo(int id)
    {
        // Use FindIndex to find the index of the Todo with the specified id
        var existingTodoIndex = responses.FindIndex(todo => todo.Id == id);

        // Check if the Todo with the specified id exists
        if (existingTodoIndex != -1)
        {
            responses.RemoveAt(existingTodoIndex);
        }
    }
}