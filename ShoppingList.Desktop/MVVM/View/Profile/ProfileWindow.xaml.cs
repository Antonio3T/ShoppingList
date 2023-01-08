using System;
using System.Windows;

namespace ShoppingList.Desktop.MVVM.View.Profile
{
	/// <summary>
	/// Interaction logic for ProfileWindow.xaml
	/// </summary>
	public partial class ProfileWindow : Window
	{
		public ProfileWindow()
		{
			InitializeComponent();
		}

		private void ButtonClose_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		Login_SignUpWindow loginsignupWindow;
		SignUp_LoginWindow signuploginWindow;
		private void ButtonSignUp_Click(object sender, RoutedEventArgs e)
		{
			if (signuploginWindow == null)
			{
				signuploginWindow = new SignUp_LoginWindow();
				signuploginWindow.Closed += SignUpWindowClosed;
				signuploginWindow.Show();
			}
			else
			{
				signuploginWindow.Activate();
			}
		}

		private void ButtonSignIn_Click(object sender, RoutedEventArgs e)
		{
			if (loginsignupWindow == null)
			{
				loginsignupWindow = new Login_SignUpWindow();
				loginsignupWindow.Closed += LoginWindowClosed;
				loginsignupWindow.Show();
			}
			else
			{
				loginsignupWindow.Activate();
			}
		}

		private void LoginWindowClosed(object sender, EventArgs args)
		{
			loginsignupWindow = null;
		}

		private void SignUpWindowClosed(object sender, EventArgs args)
		{
			signuploginWindow = null;
		}

		EditProfileWindow editprofileWindow;
		private void ButtonEditProfile_Click(object sender, RoutedEventArgs e)
		{
			if (editprofileWindow == null)
			{
				editprofileWindow = new EditProfileWindow();
				editprofileWindow.Closed += EditProfileWindowClosed;
				editprofileWindow.Show();
			}
			else
			{
				editprofileWindow.Activate();
			}
		}

		private void EditProfileWindowClosed(object sender, EventArgs args)
		{
			editprofileWindow = null;
		}
	}
}