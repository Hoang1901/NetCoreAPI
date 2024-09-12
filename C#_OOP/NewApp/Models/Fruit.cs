namespace NewApp.Models
{
    public class Fruit
    {
        public int FruitId { get; set;}
        public required string Name { get; set;}
        public int Y_packing { get; set;}
        public int Expiry  { get; set;}

        public void Enter()
        {
            System.Console.WriteLine("ID = ");
            FruitId = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Ten = ");
            string? Name = Console.ReadLine();
            System.Console.WriteLine("Nam dong goi = ");
            Y_packing = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Han su dung = ");
            Expiry = Convert.ToInt32(System.Console.ReadLine());
        }

        public void Exit()
        {
            System.Console.WriteLine("{0} - {1}", FruitId, Name);
            System.Console.WriteLine("Dong goi nam {0} - han su dung {1}", Y_packing, Expiry);
        }
    }
}