using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("    ИМЕНА    ");
        Console.WriteLine(new Name(firstName: "Клеопатра"));
        Console.WriteLine(new Name("Пушкин", "Александр", "Сергеевич"));
        Console.WriteLine(new Name("Маяковский", "Владимир"));

        Console.WriteLine("\n    ВРЕМЯ     ");
        Console.WriteLine(new Time(10));
        Console.WriteLine(new Time(10000));
        Console.WriteLine(new Time(100000));

        Console.WriteLine("\n    СОТРУДНИКИ И ОТДЕЛ    ");
        var it = new Department("IT");

        var petrov = new Employee("Петров", it);
        var kozlov = new Employee("Козлов", it);
        var sidorov = new Employee("Сидоров", it);

        it.SetBoss(kozlov);

        Console.WriteLine(petrov);
        Console.WriteLine(kozlov);
        Console.WriteLine(sidorov);

        Console.WriteLine("\n    СПИСОК СОТРУДНИКОВ       ");
        foreach (var e in it.Employees)
            Console.WriteLine(e.Name);

        Console.WriteLine("\n    СОЗДАНИЕ ВРЕМЕНИ    ");
        Console.WriteLine(new Time(10000));
        Console.WriteLine(new Time(2, 3, 5));

        Console.WriteLine("\n    СКОЛЬКО СЕЙЧАС ВРЕМЕНИ     ");
        Console.WriteLine($"Часы (34056): {new Time(34056).Hours}");
        Console.WriteLine($"Минуты (4532): {new Time(4532).Minutes}");
        Console.WriteLine($"Секунды (123): {new Time(123).Seconds}");
    }
}
