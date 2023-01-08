using System.Collections.Generic;

namespace ShoppingList.Desktop.MVVM.Model.Domain.List
{
	public class ItemList
	{
		public string name { get; set; }
		public string description { get; set; }

		public List<Iteml> items { get; set; }

		public ItemList()
		{
			items = new List<Iteml>();
		}
		public ItemList(string Description)
		{
			description = Description;
			items = new List<Iteml>();
		}

		public void AddItem() { }
		public void EditItem(Iteml item) { }
		public void DeleteItem(Iteml item) { }
		public void BuyItem(Iteml item) { }

		public void CreateList() { }
		public void DeleteList(ItemList list) { }
		public void UpdateList(ItemList list) { }

		~ItemList() { }
	}
}