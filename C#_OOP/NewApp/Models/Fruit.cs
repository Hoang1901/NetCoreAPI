namespace NewApp.Models
{
    public class Fruit : Person
    {
        public int Packing { get; set;}
        public int Expiry  { get; set;}

        public void Enter()
        {
            base.EnterData();
            System.Console.WriteLine("Nam dong goi = ");
            Packing = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Han su dung = ");
            Expiry = Convert.ToInt32(System.Console.ReadLine());
        }

        public void Exit()
        {
            base.Display();
            System.Console.WriteLine("Dong goi nam {0} - han su dung {1}", Packing, Expiry);
        }
    }
}