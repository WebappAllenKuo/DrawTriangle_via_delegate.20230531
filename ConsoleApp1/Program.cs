using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 20000;
            var order = new Order();
            
            PromoHandler handler = new PromoHandler(PromoB);
            handler              =                  PromoB;

            handler = delegate (int p)    { return p * 2; };
            handler =          (int p) => { return p * 2; };
            handler =          (p)     => { return p * 2; };
            handler =           p      => { return p * 2; };
            handler =           p =>               p * 2   ;

            handler = p => p * 2;

            int total = order.CalcTotal(price, handler);

            Console.WriteLine(total);

        }
        public static int PromoB(int price)
            => (price >= 10000) ? price - 1000 : price;

        public static int PromoC(string price)
            => 99;

        public static int Discount20(int price)
            => price * 80 / 100;
    }

    public delegate int PromoHandler(int price);

    public class Order
    {
        public int CalcTotal(int price, PromoHandler handler)
        {
            return handler(price);
        }
    }
}
