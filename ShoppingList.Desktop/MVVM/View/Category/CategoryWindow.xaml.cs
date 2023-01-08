using System;
using System.Windows;

namespace ShoppingList.Desktop.MVVM.View.Category
{
	/// <summary>
	/// Interaction logic for CategoryWindow.xaml
	/// </summary>
	public partial class CategoryWindow : Window
	{
		public CategoryWindow()
		{
			InitializeComponent();
		}

		private void ButtonClose_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		AddCategoryWindow addcategoryWindow;
		private void ButtonAddCategory_Click(object sender, RoutedEventArgs e)
		{
			if (addcategoryWindow == null)
			{
				addcategoryWindow = new AddCategoryWindow();
				addcategoryWindow.Closed += AddCategoryWindowClosed;
				addcategoryWindow.Show();
			}
			else
			{
				addcategoryWindow.Activate();
			}
		}

		private void AddCategoryWindowClosed(object sender, EventArgs args)
		{
			addcategoryWindow = null;
		}

		EditCategoryWindow editcategoryWindow;
		private void ButtonEditCategory_Click(object sender, RoutedEventArgs e)
		{
			if (editcategoryWindow == null)
			{
				editcategoryWindow = new EditCategoryWindow();
				editcategoryWindow.Closed += EditCategoryWindowClosed;
				editcategoryWindow.Show();
			}
			else
			{
				editcategoryWindow.Activate();
			}
		}

		private void EditCategoryWindowClosed(object sender, EventArgs args)
		{
			editcategoryWindow = null;
		}
	}
}