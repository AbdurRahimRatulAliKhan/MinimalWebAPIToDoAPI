using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);

app.MapGet("/", () => Results.Json(new Todo
{
    Name = "Walk dog",
    IsComplete = false
}, options));

app.Run();

class Todo
{
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}