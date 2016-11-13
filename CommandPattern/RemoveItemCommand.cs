using System.Linq;

namespace CommandPattern
{
    public class RemoveItemCommand : ICommand
    {
        private readonly ItemContainer _itemContainer;
        private readonly string _value;

        public RemoveItemCommand(ItemContainer itemContainer)
        {
            _itemContainer = itemContainer;
            _value = itemContainer.items.Last();
        }

        public void Execute()
        {
            _itemContainer.RemoveItem(_value);

        }

        public void UnExecute()
        {
            _itemContainer.AddItem(_value);
        }
    }
}
