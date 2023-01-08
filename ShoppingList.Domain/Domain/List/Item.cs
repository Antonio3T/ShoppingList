namespace ShoppingList.Desktop.MVVM.Model.Domain.List
{
	public class Item
	{
		private string nome;
		private string descricao;
		private string quantidade;
		private Categoria? categoria;

		public Item(string Nome, string Descricao, string Quantidade, Categoria Categoria)
		{
			nome = Nome;
			descricao = Descricao;
			quantidade = Quantidade;
			this.Categoria = Categoria;
		}

		public string? Nome { get; set; }
		public string? Descricao { get; set; }
		public string? Quantidade { get; set; }
		public Categoria Categoria { get; set; }

		~Item() { }
	}
}