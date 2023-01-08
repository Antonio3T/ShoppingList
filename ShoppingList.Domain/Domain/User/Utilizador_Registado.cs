using ShoppingList.Desktop.MVVM.Model.Domain.List;

namespace ShoppingList.Desktop.MVVM.Model.Domain.User
{
	public class Utilizador_Registado
	{
		private char nomeabv;
		private string foto;
		private string email;
		private string username;
		private string password;
		private string pais;
		private Lista_Itens lista;

		public Utilizador_Registado(char Nomeabv, string Foto, string Email, string Username, string Password, string Pais, Lista_Itens Lista)
		{
			nomeabv = Nomeabv;
			foto = Foto;
			email = Email;
			username = Username;
			password = Password;
			pais = Pais;
			lista = Lista;
		}

		public char Nomeabv { get; set; }
		public string? Foto { get; set; }
		public string? Email { get; set; }
		public string? Username { get; set; }
		public string? Password { get; set; }
		public string? Pais { get; set; }

		public void RegistarLista(Lista_Itens lista) { }

		~Utilizador_Registado() { }
	}
}