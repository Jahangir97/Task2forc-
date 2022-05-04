using System;

namespace Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product sweetProduct = new Product("Karamel", 1.02, 17);
            Milk palMilk = new Milk("Pal",2.53,25,0.53,2.3);

            sweetProduct.Sell(3);

            palMilk.Sell(12);

        }
    }
}
