using System.Windows;

namespace ShoppingList.Desktop.MVVM.View.Profile
{
	/// <summary>
	/// Interaction logic for Login_SignUpWindow.xaml
	/// </summary>
	public partial class Login_SignUpWindow : Window
	{
		public Login_SignUpWindow()
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
	}
}