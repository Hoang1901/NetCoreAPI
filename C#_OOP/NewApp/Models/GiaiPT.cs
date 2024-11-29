using System.ComponentModel.DataAnnotations;

namespace NewApp.Models
{
    public class GiaiPT()
    {
        public string Bac1()
        {
            int b, c;
            double x1;
            string str;
            Console.Write("\n Nhap vao so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Chuong trinh ban vua nhap la {1}x + {2} = 0.", b, c);
            if (b == 0)
            {
                if (c == 0)
                {
                    str = "\n Phuong trinh co vo so nghiem.";
                }
                else
                {
                    str = "\n Phuong trinh vo nghiem.";
                }
            }
            else
            {
                x1 = -c/b;
                str = "\n Phuong trinh co nghiem duy nhat x = " + Math.Round(x1, 2);
            }
             return str;
        }

        public string Bac2()
        {
            int a, b, c;
            double x1, x2, delta;
            string str;
            Console.Write("\n Nhap vao so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Chuong trinh ban vua nhap la {0}x^2 + {1}x + {2} = 0.", a, b, c);
            //tinh delta
            delta = Math.Pow(b, 2) - 4 * a * c;
            //delta < 0 thi phuong trinh vo nghiem
            if (delta < 0)  
            {
                str = "\n Phuong trinh vo nghiem.";
            }
            //delta = 0 thi phuong trinh co nghiem kep
            else if (delta == 0)
            {
                x1 = x2 = -b / (2 * a);
                str = "\n Phuong trinh co nghiem kep x1 = x2 = {0}" + x1;
            }
            //delta > 0 thi phuong trinh co hai nghiem phan biet
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                str = "\n Phuong trinh hai nghiem phan biet:\n X1 = " + x1 + "\n X2 = {1}" + x2;
            }            
            return str;
        }
    }
}