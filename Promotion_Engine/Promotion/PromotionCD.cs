using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Engine.Promotion
{
    public class PromotionCD : IPromotion
    {
        readonly CartHelper cartHelper;
        public PromotionCD()
        {
            cartHelper = new CartHelper();
        }

        public int GetPriceAfterPromotion()
        {
            int minPrice = 0;
            int countC = 0;
            int countD = 0;
            int minCount = 0;
            List<Cart> carts = cartHelper.GetItemsFromCart();
            foreach (Cart cart in carts)
            {
                if (cart.Sku_Id == "C")
                {
                    countC = cart.Count;
                }
                if (cart.Sku_Id == "D")
                {
                    countD = cart.Count;
                }
            }
            if (countC > countD)
            {
                minCount = countC - countD;
                minPrice = 20 * minCount;
                return minPrice + minCount * 30;
            }
            else
            {
                minCount = countD - countC;
                minPrice = 15 * minCount;
                return minPrice + minCount * 30;
            }
           
        }
    }
}
