using System.Windows;

namespace ShoppingList.Desktop.MVVM.View.Category
{
	/// <summary>
	/// Interaction logic for EditCategoryWindow.xaml
	/// </summary>
	public partial class EditCategoryWindow : Window
	{
		public EditCategoryWindow()
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
			if (((MainWindow)System.Windows.Application.Current.MainWindow).ListBoxCategories.SelectedIndex >= 0)
			{
				((MainWindow)System.Windows.Application.Current.MainWindow).model.Categories[((MainWindow)System.Windows.Application.Current.MainWindow).ListBoxCategories.SelectedIndex].name = TextBoxCategoryName.Text.ToString();

				//((MainWindow)System.Windows.Application.Current.MainWindow).Save();
				this.Close();
				((MainWindow)System.Windows.Application.Current.MainWindow).Refresh();
			}
		}
	}
}
