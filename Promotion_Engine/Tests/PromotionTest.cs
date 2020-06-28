using Promotion_Engine.Promotion;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Promotion_Engine.Tests
{
    public class PromotionTest
    {
        readonly PromotionAB _promotionAB;
        public PromotionTest()
        {
            _promotionAB = new PromotionAB();
        }
        [Fact]
        public void  PrmotionA()
        {
           int score = _promotionAB.GetPriceAfterPromotion();
                Assert.True(score == 180);  
        }
    }
}
