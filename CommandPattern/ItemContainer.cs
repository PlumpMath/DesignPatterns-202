using System.Collections.Generic;

namespace CommandPattern
{
    /// <summary>
    /// Receiver class
    /// </summary>
    public class ItemContainer
    {
        public readonly List<string> items;

        public ItemContainer()
        {
            items = new List<string>();
        }

        public void AddItem(string value)
        {
            items.Add(value);
        }

        public void RemoveItem(string value)
        {
            items.Remove(value);
        }
    }
}
