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
            int countB = 0;
            int countADiv, countBDiv;
            int countARem, countBRem;
            foreach(Cart cart in carts)
            {
                if (cart.Sku_Id == "A")
                {
                    countA = cart.Count;
                }
                if (cart.Sku_Id == "B")
                {
                    countB = cart.Count;
                }
            }
            countADiv = countA / 3;
            countARem = countA % 3;
            countBDiv = countA / 2;
            countBRem = countA % 2;
            totalScore = (130 * countADiv + 50 * countARem)+ (45*countBDiv +30*countBRem);
            return totalScore;
        }
    }
}
