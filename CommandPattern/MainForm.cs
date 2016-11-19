using System;
using System.Windows.Forms;

namespace CommandPattern
{
    public partial class MainForm : Form
    {
        private readonly ItemOperationInvoker _invoker = new ItemOperationInvoker();
        public MainForm()
        {
            InitializeComponent();
            RefreshUIElement();

        }

        private void RefreshUIElement()
        {
            itemListBox.Items.Clear();
            foreach (var item in _invoker.GetItems())
            {
                itemListBox.Items.Add(item);
            }

            btnRemove.Enabled = _invoker.IsItemsRemovable();
            btnUndo.Enabled = _invoker.IsOperationUndoable();
            btnRedo.Enabled = _invoker.IsOperationRedoable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _invoker.AddItem();
            RefreshUIElement();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _invoker.RemoveItem();
            RefreshUIElement();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            _invoker.Undo();
            RefreshUIElement();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            _invoker.Redo();
            RefreshUIElement();
        }
    }
}
