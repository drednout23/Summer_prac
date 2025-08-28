namespace NoSqlJsonDbApp.Models;

public class Document
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
}
