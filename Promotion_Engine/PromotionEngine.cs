using Promotion_Engine.Promotion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Engine
{
    public class PromotionEngine
    {
        readonly PromotionAB _Promotion1;
        readonly PromotionCD _Promotion2;
        public PromotionEngine()
        {
            _Promotion1 = new PromotionAB();
            _Promotion2 = new PromotionCD();
        }

        public int getTotalPrice()
        {
            int totalPrice = 0;
            totalPrice+= _Promotion1.GetPriceAfterPromotion();
            totalPrice += _Promotion1.GetPriceAfterPromotion();
            return totalPrice;
        }
    }
}
