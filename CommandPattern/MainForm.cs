using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            btnRemove.Visible = _invoker.IsItemsRemovable();
            btnUndo.Visible = _invoker.IsOperationUndoable();
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
    }
}
