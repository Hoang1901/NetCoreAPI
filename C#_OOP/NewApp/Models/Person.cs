namespace NewApp.Models
{
    public class Person
    {
        public string? FullName { get; set;}
        public string? Address { get; set;}
        public int Age { get; set;}

        public void EnterData()
        {
            System.Console.WriteLine("Full name = ");
            string? FullName = Console.ReadLine();
            System.Console.WriteLine("Address = ");
            string? Address = Console.ReadLine();
            System.Console.WriteLine("Age =");
            Age = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2} tuoi", FullName, Address, Age);
        }

        public void Display2 (string ten, int tuoi )
        {
            System.Console.WriteLine( "Sinh vien {0} - {1} tuoi", ten, tuoi);
        }
    }
}