// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Program
{
    private static void Main(string[] args)
    {
        int day = 2;
        switch (day){
            case 1: System.Console.WriteLine("Chu nhat"); break;
            case 2: System.Console.WriteLine("Thu hai"); break;
            case 3: System.Console.WriteLine("Thu ba"); break;
            case 4: System.Console.WriteLine("Thu tu"); break;
            case 5: System.Console.WriteLine("Thu nam"); break;
            case 6: System.Console.WriteLine("Thu sau"); break;
            case 7: System.Console.WriteLine("Thu bay");break;
            default: System.Console.WriteLine("Khong phai ngay trong tuan"); break;
        }
    }
}
