public class ContaCorrente : ContaBancaria
{
    public double TaxaDeManutencao;

    public ContaCorrente(int numeroDaConta, double saldo, double taxaDeManutencao)
    {
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
        TaxaDeManutencao = taxaDeManutencao;
    }
}