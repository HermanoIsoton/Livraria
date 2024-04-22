public class ContaBancaria
{
    public int NumeroDaConta;
    public double Saldo;

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
        }
    }
}