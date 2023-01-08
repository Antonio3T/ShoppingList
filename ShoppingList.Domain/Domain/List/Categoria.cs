namespace ShoppingList.Desktop.MVVM.Model.Domain.List
{
	public class Categoria
	{
		private string nome;

		public Categoria() { }

		public Categoria(string Nome)
		{
			nome = Nome;
		}

		public string? Nome { get; set; }

		public void CriarCategoria() { }
		public void AlterarCategoria(Categoria categoria) { }
		public void EliminarCategoria(Categoria categoria) { }

		~Categoria() { }
	}
}