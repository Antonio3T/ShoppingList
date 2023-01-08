using ShoppingList.Desktop.MVVM.Model.Domain.User;

namespace ShoppingList.Desktop.MVVM.Model.Domain.List
{
	internal class Gestor_Listas
	{
		private RegisteredUser? user;

		public Gestor_Listas(RegisteredUser User)
		{
			this.User = User;
		}

		public RegisteredUser? User { get; set; }

		public void SignUp() { }
		public void SignIn(RegisteredUser user) { }
		public void SignOut() { }
		public void CreateList() { }
		public void DeleteList(ItemList list) { }
		public void UpdateList(ItemList list) { }
		public void AddCategory(Categoryl category) { }
		public void DeleteCategory(Categoryl category) { }

		~Gestor_Listas() { }
	}
}