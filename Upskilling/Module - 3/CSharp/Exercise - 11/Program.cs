using System;

class BaseClass
{
    public string PublicValue = "Public Member";
    private string PrivateValue = "Private Member";
    protected string ProtectedValue = "Protected Member";

    public void ShowPrivate()
    {
        Console.WriteLine(PrivateValue);
    }
}

class DerivedClass : BaseClass
{
    public void Display()
    {
        Console.WriteLine(PublicValue);
        Console.WriteLine(ProtectedValue);
    }
}

class Program
{
    static void Main(string[] args)
    {
        BaseClass obj1 = new BaseClass();
        Console.WriteLine(obj1.PublicValue);
        obj1.ShowPrivate();

        DerivedClass obj2 = new DerivedClass();
        obj2.Display();
    }
}