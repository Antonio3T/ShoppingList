using ShoppingList.Desktop.Core;
using ShoppingList.Desktop.MVVM.Model.Domain.List;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ShoppingList.Desktop.MVVM.ViewModel
{
	class CategoryViewModel : ViewModelBase
	{
		private Categoryl _category;
		private ObservableCollection<Categoryl> _categories { get; set; }
		private ICommand _AddCategoryCommand;

		public ObservableCollection<Categoryl> Categories
		{
			get { return _categories; }
			set { _categories = value; OnPropertyChanged("Categories"); }
		}

		public Categoryl Category
		{
			get { return _category; }
			set { _category = value; OnPropertyChanged("Category"); }
		}

		public ICommand AddCategoryCommand
		{
			get
			{
				if (_AddCategoryCommand == null)
				{
					_AddCategoryCommand = new RelayCommand(param => this.AddCategory(),
						null);
				}
				return _AddCategoryCommand;
			}
		}

		public CategoryViewModel()
		{
			Categories = new ObservableCollection<Categoryl>();
			Category = new Categoryl();
			Categories.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Category_CollectionChanged);
		}

		private void AddCategory()
		{
			Category = new Categoryl();
			Categories.Add(Category);
		}

		void Category_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			OnPropertyChanged("Categories");
		}
	}
}