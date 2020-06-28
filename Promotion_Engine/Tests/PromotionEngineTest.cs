using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Promotion_Engine.Tests
{
    public class PromotionEngineTest
    {
        readonly PromotionEngine engine;

        public PromotionEngineTest()
        {
            engine = new PromotionEngine();
        }
       
        public void PromotionEngineTest1()
        {
            int score = engine.getTotalPrice();
            Assert.True(score == 275);
        }
    }
}
