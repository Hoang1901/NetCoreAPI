namespace NewApp.Models
{
    public class Employee : Person
    {
        public int EmployeeCode { get; set;}
        public int Luong { get; set;}

        public void EnterData()
        {
            base.EnterData();
            System.Console.Write("EmployeeCode = ");
            EmployeeCode = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Luong = ");
            Luong = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {

            base.Display();
            System.Console.WriteLine("{0} - {1} - {2} tuoi", EmployeeCode, FullName, Age);
        }

        
    }
}