using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure_Quest_RPG.Inventory_System
{
    public class Inventory
    {
        private List<Element> items = new List<Element>();
        public int ItemsCount => items.Count;

        public void AddItem(Element item)
        {
            items.Add(item);
            Console.WriteLine($"{item.Name} has been added to your inventory.");
        }
        public void RemoveItem(Element item)
        {
            items.Remove(item);
            Console.WriteLine($"{item.Name} has been used from your inventory.");
        }
        public void DisplayItems()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {items[i].Name} - {items[i].Description}");
            }
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        public Element GetItem(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                return items[index];
            }
            return null;
        }

        public Element GetItem(string itemName)
        {
            return items.Find(item => item.Name == itemName);
        }
    }
}
