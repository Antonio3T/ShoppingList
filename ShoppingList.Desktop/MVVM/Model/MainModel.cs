using ShoppingList.Desktop.MVVM.Model.Domain.List;
using System.Collections.Generic;

namespace ShoppingList.Desktop.MVVM.ViewModel
{
	public class MainModel
	{
		public List<Categoryl> Categories { get; private set; }
		public List<ItemList> Lists { get; private set; }

		public MainModel()
		{
			Categories = new List<Categoryl>();
			Lists = new List<ItemList>();
		}
	}
}