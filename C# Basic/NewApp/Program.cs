// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

internal class Program
{
    private static void Main(string[] args)
    {
        string str = "123";  //gia tri dau vao can chuyen doi
        int ketQua;  //bien luu ket qua sau chuyen doi
        //bien kiem tra chuyen doi co thanh cong hay khong
        bool kiemTra = false;
        //chuyen doi kieu  du lieu
        kiemTra = int.TryParse(str, out(ketQua));
        System.Console.WriteLine("Ket qua = " + ketQua);
    }
}
