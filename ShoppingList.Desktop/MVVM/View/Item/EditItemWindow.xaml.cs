using ShoppingList.Desktop.MVVM.Model.Domain.List;
using System.Windows;

namespace ShoppingList.Desktop.MVVM.View.Item
{
	/// <summary>
	/// Interaction logic for EditItemWindow.xaml
	/// </summary>
	public partial class EditItemWindow : Window
	{
		public EditItemWindow()
		{
			InitializeComponent();
		}

		private void ButtonClose_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
		{
			this.WindowState = WindowState.Minimized;
		}

		private void ButtonEdit_Click(object sender, RoutedEventArgs e)
		{
			Iteml i = new Iteml();
			i.name = EditItemNameTextBox.Text.ToString();
			i.quantity = EditQuantityNameTextBox.Text.ToString();
			i.category = EditCategoryNameTextBox.Text.ToString();

			if (((MainWindow)System.Windows.Application.Current.MainWindow).ListViewLists.SelectedIndex >= 0)
			{
				((MainWindow)System.Windows.Application.Current.MainWindow).model.Lists[((MainWindow)System.Windows.Application.Current.MainWindow).ListViewLists.SelectedIndex].items.Remove((Iteml)((MainWindow)System.Windows.Application.Current.MainWindow).ListViewItems.SelectedItem);
				((MainWindow)System.Windows.Application.Current.MainWindow).model.Lists[((MainWindow)System.Windows.Application.Current.MainWindow).ListViewLists.SelectedIndex].items.Add(i);

				//((MainWindow)System.Windows.Application.Current.MainWindow).model.Lists[((MainWindow)System.Windows.Application.Current.MainWindow).ListViewLists.SelectedIndex].EditItem(i);

				//((MainWindow)System.Windows.Application.Current.MainWindow).Save();
				((MainWindow)System.Windows.Application.Current.MainWindow).ListViewLists.ItemsSource = null;
				this.Close();
				((MainWindow)System.Windows.Application.Current.MainWindow).Refresh();
			}
		}
	}
}