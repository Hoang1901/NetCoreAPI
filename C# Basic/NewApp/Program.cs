// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

internal class Program
{
    private static void Main(string[] args)
    {
        string str = "123";  //gia tri dau vao can chuyen doi
        //chuyen doi kieu du lieu string (gia tri = '123')
        //sang kieu du lieu int (gia tri sau vhuye doi = 123)
        int a = Convert.ToInt32(str);
        System.Console.WriteLine("a = " + a);
    }
}
