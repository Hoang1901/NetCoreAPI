namespace NewApp.Models
{
    public class SinhVien
    {
        public required string Hoten { get; set; }
        public required string Diachi { get; set;}
        public int NamSinh { get; set;}
        public int Sdt { get; set;}

        public void NhapDuLieu()
        {
            System.Console.WriteLine("Ten sinh vien: ");
            string? Hoten = Console.ReadLine();
            System.Console.WriteLine("Dia chi: ");
            string? Diachi = Console.ReadLine();
            System.Console.WriteLine("Nam sinh: ");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("So dien thoai: ");
            Sdt = Convert.ToInt32(Console.ReadLine());
        }

        public void Xuat()
        {
            System.Console.WriteLine("{0} - {1} - sinh nam {2} - {3}", Hoten, Diachi, NamSinh, Sdt);
        }
    }
}