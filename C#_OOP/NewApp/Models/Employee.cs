namespace NewApp.Models
{
    public class Employee
    {
        public required string MaNV { get; set;}
        public required string TenNV { get; set;}
        public int Tuoi { get; set;}
        public int Luong { get; set;}

        public void EnterData()
        {
            System.Console.WriteLine("Ma nhan vien = ");
            string? MaNV = Console.ReadLine();
            System.Console.WriteLine("Ho ten = ");
            string? TenNV = Console.ReadLine();
            System.Console.WriteLine("Tuoi =");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Luong = ");
            Luong = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", MaNV, TenNV, Tuoi);
        }

        
    }
}