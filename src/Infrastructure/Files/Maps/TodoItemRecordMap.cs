using System.Globalization;
using demo2.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace demo2.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
