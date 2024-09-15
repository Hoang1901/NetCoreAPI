namespace NewApp.Models
{
    public class Student : Person
    {
        public string? StudentCode { get; set; }
        public string? Lop { get; set; }

        public void EnterData()
        {
            //ke thua phuong thuc
            base.EnterData();
            //phat trien them
            System.Console.Write("Ma hoc sinh: ");
            StudentCode =  Console.ReadLine();
            System.Console.Write("Lop: ");
            string? Lop = Console.ReadLine();
        }

        public void Display()
        {
            base.Display();
            System.Console.Write(" - Ma sinh vien - Lop {1}", StudentCode, Lop);
        }
    }
}