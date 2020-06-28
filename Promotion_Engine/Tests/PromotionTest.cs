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
        readonly PromotionCD _promotionCD;
        public PromotionTest()
        {
            _promotionAB = new PromotionAB();
        }
        [Fact]
        public void  PrmotionAB()
        {
           int score = _promotionAB.GetPriceAfterPromotion();
                Assert.True(score == 225);  
        }

        public void PromotionCD()
        {
            int score = _promotionCD.GetPriceAfterPromotion();
            Assert.True(score == 50);
        }
    }
}
