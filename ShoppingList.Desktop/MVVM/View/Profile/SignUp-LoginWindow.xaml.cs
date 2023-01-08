using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ShoppingList.Desktop.MVVM.View.Profile
{
	/// <summary>
	/// Interaction logic for SignUp_LoginWindow.xaml
	/// </summary>
	public partial class SignUp_LoginWindow : Window
	{
		public SignUp_LoginWindow()
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

		private void ButtonImage_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			if (openFileDialog != null)
			{
				openFileDialog.ShowDialog();
				string imagepath = openFileDialog.FileName;
				//ProfileImage.Source = Image.FromFile(imagepath);

				BitmapImage profileimage = new(new Uri(imagepath));

				if (profileimage != null)
				{
					ProfileImage.Source = profileimage;
				}
				else MessageBox.Show("Another One!");
			}
			else MessageBox.Show("Error");
		}
	}
}