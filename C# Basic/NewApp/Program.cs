// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("I'm NguyenTranHoang_2021050282!");
// Console.Write("6");
// int c = 9;
// Console.WriteLine("a = " + c);
// int a = 9;
// int b = 3;
// Console.WriteLine("{0}+{1}={2}",a,b,a + b);
internal class First
{
    private static void Main(string[] args)
    {
        // Console.Write("Nhap vao du lieu: ");
        // int a = Console.Read();
        // Console.WriteLine("Du lieu vua nhap vao la: "+ a);

        Console.Write("Nhap vao du lieu: ");
        string str = Console.ReadLine();
        Console.WriteLine("Du lieu vua nhap vao la: "+ str);

        //khai bao bien kieu string va gan gia tri = Nguyen Van A
        const string hoten = "Nguyen Van A";
        //khai bao bien kieu int va gan gia tri = 18
        int tuoi = 18;
        //khai bao hang kieu int 
        const int namlamviec = 8;
        Console.WriteLine("Sinh vien {0} - {1} tuoi - {2} nam lam viec!",hoten,tuoi,namlamviec);

        string str1 = "123";
        int a = int.Parse(str1);
        System.Console.WriteLine("a = " + a);
        
    }
}
