namespace ShoppingList.Desktop.MVVM.Model.Domain.List
{
	public class Iteml
	{
		public string? name { get; set; }
		public string? description { get; set; }
		public string? quantity { get; set; }
		public string category { get; set; }
		public bool bought { get; set; }

		public Iteml() { }
		public Iteml(string Name, string Description, string Quantity, string Category, bool Bought)
		{
			name = Name;
			description = Description;
			quantity = Quantity;
			category = Category;
			bought = false;
		}

		~Iteml() { }
	}
}