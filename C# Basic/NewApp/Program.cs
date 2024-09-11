// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

public class Program
{
    private static void Main(string[] args)
    {
        for (int i = 0; i <= 10; i++){
            if (i == 5) break;
                System.Console.WriteLine("Vong lap thu {0}",i);
        }
        // int a = 1;
        // do{
        //     System.Console.WriteLine("Vong lap thu {0}", a);
        //     //tang a len 1 don vi de dam bao co luc a >= 10
        //     //a >= 10 thi vong lap ket thuc
        //     a++;
        // } while(a <10);
    }
}
