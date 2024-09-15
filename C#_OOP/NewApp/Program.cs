using NewApp.Models;
public class Program()
{
    private static void Main(string[] args)
    {
        //khoi tao
        GiaiPT giaiPT= new GiaiPT();
        Console.Write("Giai phuong trinh bac: ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x == 1)
        {
#pragma warning disable CS8974 // Converting method group to non-delegate type
            Console.WriteLine(giaiPT.Bac1);
#pragma warning restore CS8974 // Converting method group to non-delegate type
        }
        else
        {
            Console.WriteLine(giaiPT.Bac2());
        }
        
    }
}