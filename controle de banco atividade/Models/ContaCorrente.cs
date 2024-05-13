namespace controle_de_banco_atividade.Models
{
    public class ContaCorrente : Conta
    {
        private static int contadorConta = 1;

        public ContaCorrente(String nomeCliente, float saldo)

        {
            CriarConta(nomeCliente, saldo);
        }

        public override void CriarConta(String nomeCliente, float saldo)

        {
            NomeCliente = nomeCliente;
            Saldo = saldo;
            Agencia = "Caixadobixo011";
            NumConta = $"CC{contadorConta++}";

            Depositar(saldo);
        }
    }

}
