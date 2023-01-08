namespace ShoppingList.Desktop.MVVM.Model.Domain.List
{
	public class Lista_Itens
	{
		private string descricao;

		public Lista_Itens(string Descricao)
		{
			descricao = Descricao;
		}

		public void AdicionarItem() { }
		public void EditarItem(Item item) { }
		public void ApagarItem(Item item) { }
		public void ComprarItem(Item item) { }

		~Lista_Itens() { }
	}
}