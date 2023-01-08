using System;
using System.Windows;

namespace ShoppingList.Desktop.MVVM.View.List
{
	/// <summary>
	/// Interaction logic for ListWindow.xaml
	/// </summary>
	public partial class ListWindow : Window
	{
		public ListWindow()
		{
			InitializeComponent();
		}

		private void ButtonClose_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		AddListWindow addlistWindow;
		private void ButtonAddList_Click(object sender, RoutedEventArgs e)
		{
			if (addlistWindow == null)
			{
				addlistWindow = new AddListWindow();
				addlistWindow.Closed += WindowClosed;
				addlistWindow.Show();
			}
			else
			{
				addlistWindow.Activate();
			}
		}

		private void WindowClosed(object sender, EventArgs args)
		{
			addlistWindow = null;
		}

		EditListWindow editListWindow;
		private void ButtonEditList_Click(object sender, RoutedEventArgs e)
		{
			if (editListWindow == null)
			{
				editListWindow = new EditListWindow();
				editListWindow.Closed += EditListWindowClosed;
				editListWindow.Show();
			}
			else
			{
				editListWindow.Activate();
			}
		}

		private void EditListWindowClosed(object sender, EventArgs args)
		{
			editListWindow = null;
		}
	}
}