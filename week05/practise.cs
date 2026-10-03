using System.Reflection.Metadata.Ecma335;

public class Person
{
    private string name;
    private string surname;
    private string code;

    public Person(string surname, string name, string code)
    {
        this.name = name;
        this.surname = surname;
        this.code = code;
    }
    public string GetCode()
    {
        return code;
    }

    public string GetName()
    {
        return name;
    }
    public string GetSurname()
    {
        return surname;
    }
}

public class Student : Person
{
    private string _number;

    // calling the parent constructor using "base"!
    public Student(string name, string number, string surname, string code) : base(name, surname, code)
    {
        this._number = number;
    }

    public string GetNumber()
    {
        return _number;
    }
}

public class program
{
    public static void Main()
    {
        Student student = new Student("deon", "234", "smith", "ABC123");
        string name = student.GetName();
        string surname = student.GetSurname();
        string number = student.GetNumber();
        string code = student.GetCode();

        Console.WriteLine($"{name}, {surname}, {number}");
        Console.WriteLine(number);
        Console.WriteLine(surname);
        Console.WriteLine(code);
    }
}
