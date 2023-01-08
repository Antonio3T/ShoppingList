using ShoppingList.Desktop.MVVM.Model.Domain.User;

namespace ShoppingList.Desktop.MVVM.Model.Domain.List
{
	internal class Gestor_Listas
	{
		private Utilizador_Registado? utilizador;

		public Gestor_Listas(Utilizador_Registado Utilizador)
		{
			this.Utilizador = Utilizador;
		}

		public Utilizador_Registado? Utilizador { get; set; }

		public void SignUp() { }
		public void SignIn(Utilizador_Registado utilizador) { }
		public void SignOut() { }
		public void CriarLista() { }
		public void RemoverLista(Lista_Itens lista) { }
		public void AlterarLista(Lista_Itens lista) { }
		public void AdicionarCategoria(Categoria categoria) { }
		public void RemoverCategoria(Categoria categoria) { }

		~Gestor_Listas() { }
	}
}