using ShoppingList.Desktop.MVVM.Model.Domain.List;

namespace ShoppingList.Desktop.MVVM.Model.Domain.User
{
	public class RegisteredUser
	{
		public char nickname { get; set; }
		public string? foto { get; set; }
		public string? email { get; set; }
		public string? username { get; set; }
		public string? password { get; set; }
		public string? country { get; set; }
		public ItemList list { get; set; }

		public RegisteredUser(char Nickname, string Foto, string Email, string Username, string Password, string Country, ItemList List)
		{
			nickname = Nickname;
			foto = Foto;
			email = Email;
			username = Username;
			password = Password;
			country = Country;
			list = List;
		}

		public void SubmitList(ItemList list) { }

		~RegisteredUser() { }
	}
}