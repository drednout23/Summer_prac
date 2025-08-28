using Xunit;
using NoSqlJsonDbApp.Services;
using NoSqlJsonDbApp.Models;
using System.IO;

namespace NoSqlJsonDbApp.Tests;

public class JsonDatabaseTests
{
    [Fact]
    public void Create_AddsDocument()
    {
        var db = new JsonDatabase("test.json");
        var doc = new Document { Name = "TestDoc" };
        db.Create(doc);
        var all = db.ReadAll();
        Assert.Contains(all, d => d.Name == "TestDoc");
        File.Delete("test.json");
    }
}
