namespace Livraria;

class Program
{
	static void Main()
	{
		ContaPoupanca contaPoupanca = new ContaPoupanca { NumeroDaConta = 35432, Saldo = 46534, TaxaDeJuros = 0.50 };
		ContaCorrente contaCorrente = new ContaCorrente(74747, 43636, 10);

		contaPoupanca.Depositar(323);
		contaPoupanca.Sacar(35252);
		contaPoupanca.AplicarJuros();

		contaCorrente.Depositar(235253);
		contaCorrente.Sacar(235);
		
		Console.WriteLine("Saldo da Poupança: " + contaPoupanca.Saldo);
		Console.WriteLine("Saldo da Corrente: " + contaCorrente.Saldo);
	}
}