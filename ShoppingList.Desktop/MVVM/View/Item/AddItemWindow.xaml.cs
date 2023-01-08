using ShoppingList.Desktop.MVVM.Model.Domain.List;
using System.Windows;

namespace ShoppingList.Desktop.MVVM.View.Item
{
	/// <summary>
	/// Interaction logic for AddItemWindow.xaml
	/// </summary>
	public partial class AddItemWindow : Window
	{
		public AddItemWindow()
		{
			InitializeComponent();
		}

		private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
		{
			this.WindowState = WindowState.Minimized;
		}

		private void ButtonClose_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void ButtonAdd_Click(object sender, RoutedEventArgs e)
		{
			Iteml i = new Iteml();
			i.name = AddItemNameTextBox.Text.ToString();
			i.quantity = AddQuantityNameTextBox.Text.ToString();
			i.category = AddCategoryNameTextBox.Text.ToString();

			if (((MainWindow)System.Windows.Application.Current.MainWindow).ListViewLists.SelectedIndex >= 0)
			{
				((MainWindow)System.Windows.Application.Current.MainWindow).model.Lists[((MainWindow)System.Windows.Application.Current.MainWindow).ListViewLists.SelectedIndex].items.Add(i);

				//((MainWindow)System.Windows.Application.Current.MainWindow).Save();
				((MainWindow)System.Windows.Application.Current.MainWindow).ListViewLists.ItemsSource = null;
				this.Close();
				((MainWindow)System.Windows.Application.Current.MainWindow).Refresh();
			}
		}
	}
}