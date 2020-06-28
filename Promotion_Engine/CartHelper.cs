using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Engine
{
    public class CartHelper
    {
        List<Cart> GetItemsFromCart()
        {
            List<Cart> carts = new List<Cart>();
            Cart cartA = new Cart();
            cartA.Sku_Id = "A";
            cartA.Price = 50;
            cartA.Count = 4;
            carts.Add(cartA);
            Cart cartB = new Cart();
            cartB.Sku_Id = "B";
            cartB.Price = 30;
            cartB.Count = 3;
            carts.Add(cartB);
            Cart cartC = new Cart();
            cartC.Sku_Id = "C";
            cartC.Price = 20;
            cartC.Count = 2;
            carts.Add(cartC);
            Cart cartD = new Cart();
            cartD.Sku_Id = "D";
            cartD.Price = 15;
            cartD.Count = 1;
            carts.Add(cartD);
            return carts;
        }
    }
}
