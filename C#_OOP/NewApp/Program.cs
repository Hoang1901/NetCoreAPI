using NewApp.Models;
public class Program()
{
    private static void Main(string[] args)
    {
        //khoi tao doi tuong ps tu class Person
        Person ps = new Person();
        //khai bao 2 bien va gan gia tri
        string str = "Nguyen Van A";
        int a = 22;
        Console.WriteLine("{0} sinh nam {1}", str, ps.GetYearOfBirth(a));
    }

}