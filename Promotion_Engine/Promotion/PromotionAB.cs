using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Engine.Promotion
{
    public class PromotionAB : IPromotion
    {
        readonly CartHelper cartHelper;
        public PromotionAB()
        {
            cartHelper = new CartHelper();
        }
        public int GetPriceAfterPromotion()
        {
            List<Cart> carts = cartHelper.GetItemsFromCart();
            int totalScore = 0;
            int countA = 0;
            int countADiv = 0;
            int countARem = 0;
            foreach(Cart cart in carts)
            {
                if (cart.Sku_Id == "A")
                {
                    countA = cart.Count;
                }
            }
            countADiv = countA / 3;
            countARem = countA % 3;
            totalScore = 130 * countADiv + 50 * countARem;
            return totalScore;
        }
    }
}
