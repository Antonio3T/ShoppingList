using ShoppingList.Desktop.MVVM.Model.Domain.List;
using ShoppingList.Desktop.MVVM.View.Category;
using ShoppingList.Desktop.MVVM.View.Item;
using ShoppingList.Desktop.MVVM.View.List;
using ShoppingList.Desktop.MVVM.View.Profile;
using ShoppingList.Desktop.MVVM.ViewModel;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Xml.Linq;

namespace ShoppingList.Desktop.MVVM.View
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public App app;

		public MainWindow()
		{
			app = App.Current as App;

			InitializeComponent();
			LoadList();
			ShowList();
		}

		public MainModel model = new MainModel();
		private void LoadList()
		{
			XDocument xdoc = XDocument.Load("ListData.xml");

			var cats = from al in xdoc.Descendants("Category") select al;

			foreach (var aux in cats)
			{
				Categoryl c = new Categoryl();
				c.name = aux.Attribute("name").Value;
				c.predefined = aux.Attribute("predefined").Value == "true";

				model.Categories.Add(c);
			}

			var lists = from lst in xdoc.Root.Elements("Lists").Descendants("List") select lst;

			foreach (var aux in lists)
			{
				ItemList newlist = new ItemList() { name = aux.Attribute("name").Value };
				var items = from al in aux.Descendants("Item") select al;

				foreach (var tmp in items)
				{
					Iteml i = new Iteml();
					i.name = tmp.Attribute("name").Value;
					//i.description = tmp.Attribute("description").Value;
					i.quantity = tmp.Attribute("quantity").Value;
					i.category = tmp.Attribute("category").Value;
					i.bought = tmp.Attribute("bought").Value == "true";

					newlist.items.Add(i);
				}
				model.Lists.Add(newlist);
			}
		}

		private void ShowList()
		{
			ListBoxCategories.Items.Refresh();
			ListViewLists.Items.Refresh();
			ListViewItems.Items.Refresh();

			ListBoxCategories.ItemsSource = model.Categories;
			ListViewLists.ItemsSource = model.Lists;
		}

		public void Refresh()
		{
			MainWindow mainwindow = new MainWindow();
			//LoadList();
			ShowList();
			//mainwindow.Show();
		}

		private void ButtonClose_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
		private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
		{
			this.WindowState = WindowState.Minimized;
		}

		ProfileWindow profileWindow;
		private void ButtonProfile_Click(object sender, RoutedEventArgs e)
		{
			if (profileWindow == null)
			{
				profileWindow = new ProfileWindow();
				profileWindow.Closed += ProfileWindowClosed;
				profileWindow.Show();
			}
			else
			{
				profileWindow.Activate();
			}
		}

		CategoryWindow categoryWindow;
		private void ButtonCategory_Click(object sender, RoutedEventArgs e)
		{
			if (categoryWindow == null)
			{
				categoryWindow = new CategoryWindow();
				categoryWindow.Closed += CategoryWindowClosed;
				categoryWindow.Show();
			}
			else
			{
				categoryWindow.Activate();
			}
		}

		ItemWindow itemWindow;
		private void ButtonItem_Click(object sender, RoutedEventArgs e)
		{
			if (itemWindow == null)
			{
				itemWindow = new ItemWindow();
				itemWindow.Closed += ItemWindowClosed;
				itemWindow.Show();
			}
			else
			{
				itemWindow.Activate();
			}
		}

		ListWindow listWindow;
		private void ButtonList_Click(object sender, RoutedEventArgs e)
		{
			if (listWindow == null)
			{
				listWindow = new ListWindow();
				listWindow.Closed += ListWindowClosed;
				listWindow.Show();
			}
			else
			{
				listWindow.Activate();
			}
		}

		private void ProfileWindowClosed(object sender, EventArgs args)
		{
			profileWindow = null;
		}

		private void CategoryWindowClosed(object sender, EventArgs args)
		{
			categoryWindow = null;
		}

		private void ItemWindowClosed(object sender, EventArgs args)
		{
			itemWindow = null;
		}

		private void ListWindowClosed(object sender, EventArgs args)
		{
			listWindow = null;
		}

		private void ListViewLists_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (ListViewLists.SelectedIndex >= 0)
			{
				ListViewItems.ItemsSource = model.Lists[ListViewLists.SelectedIndex].items;
			}

			CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListViewItems.ItemsSource);
			PropertyGroupDescription groupDescription = new PropertyGroupDescription("category");
			view.GroupDescriptions.Clear();
			view.GroupDescriptions.Add(groupDescription);
		}

		private void ButtonSave_Click(object sender, RoutedEventArgs e)
		{
			Save();
		}

		public void Save()
		{

			XDocument xdoc = new XDocument();

			xdoc.Add(new XElement("ListData"));
			xdoc.Element("ListData").Add(new XElement("Categories"));
			xdoc.Element("ListData").Add(new XElement("Lists"));

			XElement cats = xdoc.Root.Element("Categories");

			foreach (Categoryl aux in model.Categories)
			{
				XElement no = new XElement("Category");
				no.Add(new XAttribute("name", aux.name));
				no.Add(new XAttribute("predefined", aux.predefined));

				cats.Add(no);
			}

			XElement lists = xdoc.Root.Element("Lists");

			foreach (ItemList aux in model.Lists)
			{
				XElement no = new XElement("List");
				no.Add(new XAttribute("name", aux.name));

				foreach (Iteml i in aux.items)
				{
					XElement temp = new XElement("Item");
					temp.Add(new XAttribute("name", i.name));
					temp.Add(new XAttribute("quantity", i.quantity));
					temp.Add(new XAttribute("category", i.category));
					temp.Add(new XAttribute("bought", i.bought));

					no.Add(temp);
				}
				lists.Add(no);
			}
			xdoc.Save("ListData.xml");

			//MessageBox.Show("File saved!");
		}

		private void ListViewLists_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if (ListViewLists.SelectedIndex >= 0)
			{
				model.Lists.Remove((ItemList)ListViewLists.SelectedItem);
				//Save();
				Refresh();
			}
		}

		private void ListBoxCategories_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			model.Categories.Remove((Categoryl)ListBoxCategories.SelectedItem);
			//Save();
			Refresh();
		}

		private void ListViewItems_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if (ListViewLists.SelectedIndex >= 0)
			{
				model.Lists[ListViewLists.SelectedIndex].items.Remove((Iteml)ListViewItems.SelectedItem);
				ListViewLists.ItemsSource = null;
				//Save();
				Refresh();
			}
		}

		EditCategoryWindow editCategoryWindow;
		private void ListBoxCategories_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if (editCategoryWindow == null)
			{
				editCategoryWindow = new EditCategoryWindow();
				editCategoryWindow.Closed += EditCategoryWindowClosed;
				editCategoryWindow.Show();
			}
			else
			{
				editCategoryWindow.Activate();
			}
		}

		private void EditCategoryWindowClosed(object sender, EventArgs args)
		{
			editCategoryWindow = null;
		}

		EditItemWindow editItemWindow;
		private void ListViewItems_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if (editItemWindow == null)
			{
				editItemWindow = new EditItemWindow();
				editItemWindow.Closed += EditItemWindowClosed;
				editItemWindow.Show();
			}
			else
			{
				editItemWindow.Activate();
			}
		}

		private void EditItemWindowClosed(object sender, EventArgs args)
		{
			editItemWindow = null;
		}

		EditListWindow editListWindow;
		private void ListViewLists_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			if (editListWindow == null)
			{
				editListWindow = new EditListWindow();
				editListWindow.Closed += EditListWindowClosed;
				editListWindow.Show();
			}
			else
			{
				editListWindow.Activate();
			}
		}

		private void EditListWindowClosed(object sender, EventArgs args)
		{
			editListWindow = null;
		}
	}
}