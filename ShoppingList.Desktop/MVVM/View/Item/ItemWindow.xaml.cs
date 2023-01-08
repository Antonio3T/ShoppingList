using System;
using System.Windows;

namespace ShoppingList.Desktop.MVVM.View.Item
{
	/// <summary>
	/// Interaction logic for ItemWindow.xaml
	/// </summary>
	public partial class ItemWindow : Window
	{
		public ItemWindow()
		{
			InitializeComponent();
		}

		private void ButtonClose_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		AddItemWindow additemWindow;
		private void ButtonAddItem_Click(object sender, RoutedEventArgs e)
		{
			if (additemWindow == null)
			{
				additemWindow = new AddItemWindow();
				additemWindow.Closed += AddItemWindowClosed;
				additemWindow.Show();
			}
			else
			{
				additemWindow.Activate();
			}
		}

		private void AddItemWindowClosed(object sender, EventArgs args)
		{
			additemWindow = null;
		}

		EditItemWindow edititemWindow;
		private void ButtonEditItem_Click(object sender, RoutedEventArgs e)
		{
			if (edititemWindow == null)
			{
				edititemWindow = new EditItemWindow();
				edititemWindow.Closed += EditItemWindowClosed;
				edititemWindow.Show();
			}
			else
			{
				edititemWindow.Activate();
			}
		}

		private void EditItemWindowClosed(object sender, EventArgs args)
		{
			edititemWindow = null;
		}
	}
}