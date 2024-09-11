// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Program
{
    private static void Main(string[] args)
    {
        int a = 1;
        while (a < 10){
            System.Console.WriteLine("Vong lap thu {0}",a);
            //tang a len 1 don vi de dam bao co luc a >= 10
            //a >= 10 thi vong lap ket thuc
            a++;
        }
    }
}
