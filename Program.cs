namespace Livraria;

class Program
{
	static void Main(string[] args)
	{
		Estoque estoque = new Estoque();
		estoque.Quantidade = 300;
		estoque.venderEstoque(20);
		Console.WriteLine(estoque.Quantidade);
	}
}

class Estoque
{
	public string Titulo, Autor;
	public int isbn, Quantidade;
	
	public void addEstoque(int quantia)
	{
		Quantidade = Quantidade + quantia;
	}
	public void venderEstoque(int quantia)  
	{
		Quantidade = Quantidade - quantia;
		
	}
	
}

