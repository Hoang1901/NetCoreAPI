namespace NewApp.Models
{
    public class Student
    {
        public int MaHS { get; set; }
        public required string TenHS { get; set;}
        public required string DiaChi { get; set;}
        public required string Lop { get; set;}

        public void Nhap()
        {
            System.Console.WriteLine("Ma hoc sinh: ");
            MaHS = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Ten hoc sinh: ");
            string? TenHS = Console.ReadLine();
            System.Console.WriteLine("Dia chi: ");
            string? DiaChi = Console.ReadLine();
            System.Console.WriteLine("Lop: ");
            string? Lop = Console.ReadLine();
        }

        public void Xuat()
        {
            System.Console.WriteLine("{0} - {1} - Lop {2}", MaHS, TenHS, Lop);
        }
    }
}