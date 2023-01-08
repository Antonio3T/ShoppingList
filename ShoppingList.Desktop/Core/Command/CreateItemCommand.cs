using System;
using System.Windows.Input;

namespace ShoppingList.Desktop.Core.Command
{
	public class CreateItemCommand : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			//if (parameter is ShoppingListViewModel itemlist)
			//{
			//	itemlist.Items.Add(new ListViewModel() { Name = itemlist.ItemName, Complete = false });
			//}
		}
	}
}