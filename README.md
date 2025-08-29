# NoSqlJsonDbApp

A simple NoSQL-style database application written in **C# (.NET 8)** that stores and manages data in JSON format.  
The project includes a console application and unit tests.

---

## 📂 Project Structure
```

NoSqlJsonDbApp\_Full/
│── NoSqlJsonDbApp.sln                # Solution file
│
├── src/
│   └── NoSqlJsonDbApp/               # Main console application
│       ├── Program.cs
│       ├── Models/
│       └── Services/
│
└── tests/
└── NoSqlJsonDbApp.Tests/         # Unit tests

````

---

## 🚀 Features
- Add documents to the JSON database  
- List all documents  
- Update documents  
- Delete documents  
- Persistent storage in `.json` file  
- Unit tests included  

---

## 🛠️ Requirements
- [.NET 8 SDK](https://dotnet.microsoft.com/download) (or higher)  
- Git (if cloning from repository)  

---

## ▶️ Run the Application
1. Clone the repository:
   ```
   git clone https://github.com/drednout23/Summer_prac.git
   cd Summer_prac/src/NoSqlJsonDbApp


2. Run the console application:
````
   dotnet run

````
## 🧪 Run Unit Tests

From the project root:

````
dotnet test
````

---

## 📖 Example Usage

When you run the app, you will see a console menu:

```
1. Add new document
2. Show all documents
3. Update document by ID
4. Delete document by ID
0. Exit
```

Example:

```
Enter your choice: 1
Enter document title: My Note
Enter content: Hello World
Document added successfully!
```

---

## 📜 License

This project is released under the MIT License.
Feel free to use, modify, and distribute it.
