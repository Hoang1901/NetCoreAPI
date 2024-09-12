using NewApp.Models;
public class Program()
{
    private static void Main(string[] args)
    {
        //khoi tao 2 doi tuong tu class Person
        Person ps1 = new Person
        {
            //gan gia tri cho thuoc tinh doi tuong ps1
            FullName = "Nguyen Van A",
            Address = "Ha Noi",
            Age = 18
        };
        
        Person ps2 = new Person
        {
            //gan gia tri cho thuoc tinh doi tuong ps2
            FullName = "Nguyen Van B",
            Address = "Hai Duong",
            Age = 22
        };
    
        //goi phuong thuc hien thi thong tin
        ps1.Display();
        ps2.Display();

        //
    }
}