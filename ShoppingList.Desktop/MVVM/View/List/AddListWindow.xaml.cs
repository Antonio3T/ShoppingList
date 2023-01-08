using ShoppingList.Desktop.MVVM.Model.Domain.List;
using System.Windows;

namespace ShoppingList.Desktop.MVVM.View.List
{
	/// <summary>
	/// Interaction logic for AddListWindow.xaml
	/// </summary>
	public partial class AddListWindow : Window
	{
		public AddListWindow()
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

		private void ButtonAdd_Click(object sender, RoutedEventArgs e)
		{
			ItemList newlist = new ItemList() { name = TextBoxListName.Text.ToString() };

			((MainWindow)System.Windows.Application.Current.MainWindow).model.Lists.Add(newlist);
			//((MainWindow)System.Windows.Application.Current.MainWindow).Save();
			this.Close();
			((MainWindow)System.Windows.Application.Current.MainWindow).Refresh();
		}
	}
}