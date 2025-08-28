using NoSqlJsonDbApp.Services;
using NoSqlJsonDbApp.Models;

var db = new JsonDatabase("data.json");

while (true)
{
    Console.WriteLine("\nВыберите действие:");
    Console.WriteLine("1. Создать документ");
    Console.WriteLine("2. Показать все документы");
    Console.WriteLine("3. Обновить документ");
    Console.WriteLine("4. Удалить документ");
    Console.WriteLine("5. Выход");

    var choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            var doc = new Document { Name = name ?? "Безымянный" };
            db.Create(doc);
            Console.WriteLine("Документ создан.");
            break;
        case "2":
            var all = db.ReadAll();
            foreach (var d in all)
                Console.WriteLine($"{d.Id}: {d.Name}");
            break;
        case "3":
            Console.Write("Введите Id документа: ");
            var idToUpdate = Console.ReadLine();
            Console.Write("Введите новое имя: ");
            var newName = Console.ReadLine();
            db.Update(idToUpdate, newName ?? "Безымянный");
            Console.WriteLine("Документ обновлен.");
            break;
        case "4":
            Console.Write("Введите Id документа: ");
            var idToDelete = Console.ReadLine();
            db.Delete(idToDelete);
            Console.WriteLine("Документ удален.");
            break;
        case "5":
            return;
    }
}
