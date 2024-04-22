public class ContaPoupanca : ContaBancaria
{
    public double TaxaDeJuros;

    public void AplicarJuros()
    {
        Saldo += Saldo * TaxaDeJuros;
    }
}