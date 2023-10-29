using demo2.Application.Common.Mappings;
using demo2.Domain.Entities;

namespace demo2.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
