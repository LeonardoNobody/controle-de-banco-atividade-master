namespace controle_de_banco_atividade.Models
{
    public class ContaPoupanca : Conta
    {
        private static int contadorConta = 1;

        public ContaPoupanca(string nomeCliente, float saldo)
        {
            CriarConta(nomeCliente, saldo);
        }

        public override void CriarConta(String nomeCliente, float saldo)
        {
            NomeCliente = nomeCliente;
            Saldo = saldo;
            Agencia = "Caixadobixo022";
            NumConta = $"CP{contadorConta++}";

            Depositar(saldo);
        }
    }
}
