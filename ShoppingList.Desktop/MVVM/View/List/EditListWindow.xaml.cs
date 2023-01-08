using System.Windows;

namespace ShoppingList.Desktop.MVVM.View.List
{
	/// <summary>
	/// Interaction logic for EditListWindow.xaml
	/// </summary>
	public partial class EditListWindow : Window
	{
		public EditListWindow()
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

		private void ButtonEditList_Click(object sender, RoutedEventArgs e)
		{
			if (((MainWindow)System.Windows.Application.Current.MainWindow).ListViewLists.SelectedIndex >= 0)
			{
				((MainWindow)System.Windows.Application.Current.MainWindow).model.Lists[((MainWindow)System.Windows.Application.Current.MainWindow).ListViewLists.SelectedIndex].name = TextBoxListName.Text.ToString();

				//((MainWindow)System.Windows.Application.Current.MainWindow).Save();
				this.Close();
				((MainWindow)System.Windows.Application.Current.MainWindow).Refresh();
			}
		}
	}
}