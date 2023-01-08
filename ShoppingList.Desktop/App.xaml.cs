using ShoppingList.Desktop.MVVM.ViewModel;
using System.Windows;

namespace ShoppingList.Desktop
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		MainModel model { get; set; }

		public App()
		{
			model = new MainModel();
		}
	}
}