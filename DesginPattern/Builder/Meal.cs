using System;
using System.Collections.Generic;

namespace Builder
{
    public class Meal
    {
        private List<Item> items = new List<Item>();
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public float GetCost()
        {
            var cost = 0.0f;
            this.items.ForEach(item =>
            { cost = cost + item.Price; }
            );
            return cost;
        }
        public void ShowItems()
        {
            this.items.ForEach(item =>
            {
                Console.WriteLine("Item Name: " + item.Name);
                Console.WriteLine("Item Price: " + item.Price);
                Console.WriteLine("Item Packing: " + item.packing.Pack());
            }
            );
            
        }
    }
}