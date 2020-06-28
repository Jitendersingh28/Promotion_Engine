using Promotion_Engine.Promotion;
using System;

namespace Promotion_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            PromotionAB A = new PromotionAB();
            int a =A.GetPriceAfterPromotion();
            Console.WriteLine(a);
        }
    }
}
