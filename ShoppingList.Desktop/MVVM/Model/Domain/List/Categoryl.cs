namespace ShoppingList.Desktop.MVVM.Model.Domain.List
{
	public class Categoryl
	{
		public string name { get; set; }
		public bool predefined { get; set; }

		public Categoryl() { }

		public Categoryl(string Name)
		{
			name = Name;
		}

		public void AddCategory() { }
		public void UpdateCategory(Categoryl category) { }
		public void DeleteCategory(Categoryl category) { }

		~Categoryl() { }
	}
}