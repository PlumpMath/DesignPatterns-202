using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CommandPattern
{
    public class ItemOperationInvoker
    {
        private readonly ItemContainer itemContainer = new ItemContainer();
        private List<ICommand> _commands = new List<ICommand>();
        private int current = 0;

        public void AddItem()
        {
            var commmand = new AddItemsCommand(itemContainer);
            commmand.Execute();
            current++;
            _commands.Add(commmand);

        }

        public void RemoveItem()
        {
            if (itemContainer.items.Any())
            {
                var commmand = new RemoveItemCommand(itemContainer);
                commmand.Execute();
                current++;
                _commands.Add(commmand);
            }
            else
            {
                MessageBox.Show("You can not remove Items. Because there is currently no items in the list");
            }
        }

        public void Undo()
        {

            if (IsOperationUndoable())
            {
                ICommand command = _commands[--current];
                command.UnExecute();
            }
        }

        public void Redo()
        {
            if (IsOperationRedoable())
            {
                ICommand command = _commands[current++];
                command.Execute();
            }
        }

        public List<string> GetItems()
        {
            return itemContainer.items;
        }

        public bool IsItemsRemovable()
        {
            return itemContainer.items.Any();
        }

        public bool IsOperationUndoable()
        {
            return current > 0;
        }

        public bool IsOperationRedoable()
        {
            return current <= _commands.Count - 1;
        }
    }
}
