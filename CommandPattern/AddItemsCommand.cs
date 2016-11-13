using System;

namespace CommandPattern
{
    public class AddItemsCommand : ICommand
    {
        private readonly ItemContainer _itemContainer;
        private readonly string _value;

        public AddItemsCommand(ItemContainer itemContainer)
        {
            _itemContainer = itemContainer;
            _value = Guid.NewGuid().ToString();
        }

        public void Execute()
        {
            _itemContainer.AddItem(_value);

        }

        public void UnExecute()
        {
            _itemContainer.RemoveItem(_value);
        }
    }
}
