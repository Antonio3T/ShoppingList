using ShoppingList.Desktop.MVVM.Model.Domain.List;
using System.Windows;

namespace ShoppingList.Desktop.MVVM.View.Category
{
	/// <summary>
	/// Interaction logic for AddCategoryWindow.xaml
	/// </summary>
	public partial class AddCategoryWindow : Window
	{
		public AddCategoryWindow()
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
			Categoryl c = new Categoryl();
			c.name = TextBoxCategoryName.Text.ToString();

			((MainWindow)System.Windows.Application.Current.MainWindow).model.Categories.Add(c);
			//((MainWindow)System.Windows.Application.Current.MainWindow).Save();
			this.Close();
			((MainWindow)System.Windows.Application.Current.MainWindow).Refresh();
		}
	}
}