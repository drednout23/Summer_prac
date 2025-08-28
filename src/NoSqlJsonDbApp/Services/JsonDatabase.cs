using System.Text.Json;
using NoSqlJsonDbApp.Models;

namespace NoSqlJsonDbApp.Services;

public class JsonDatabase
{
    private readonly string _filePath;
    private List<Document> _documents;

    public JsonDatabase(string filePath)
    {
        _filePath = filePath;
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            _documents = JsonSerializer.Deserialize<List<Document>>(json) ?? new List<Document>();
        }
        else
        {
            _documents = new List<Document>();
        }
    }

    private void SaveChanges()
    {
        var json = JsonSerializer.Serialize(_documents, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_filePath, json);
    }

    public void Create(Document doc)
    {
        _documents.Add(doc);
        SaveChanges();
    }

    public List<Document> ReadAll() => _documents;

    public void Update(string? id, string newName)
    {
        var doc = _documents.FirstOrDefault(d => d.Id == id);
        if (doc != null)
        {
            doc.Name = newName;
            SaveChanges();
        }
    }

    public void Delete(string? id)
    {
        var doc = _documents.FirstOrDefault(d => d.Id == id);
        if (doc != null)
        {
            _documents.Remove(doc);
            SaveChanges();
        }
    }
}
