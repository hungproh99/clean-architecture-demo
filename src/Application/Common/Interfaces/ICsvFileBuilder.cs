using demo2.Application.TodoLists.Queries.ExportTodos;

namespace demo2.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
