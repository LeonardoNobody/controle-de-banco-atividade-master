namespace controle_de_banco_atividade.Models
{
    public abstract class Conta
    {
        public string? NomeCliente { get; set; }
        public string? NumConta { get; set; }
        public string? Agencia { get; set; }

        public float Saldo { get; protected set; }

        // Método virtual que pode ser substituído por classes derivadas
        public virtual void CriarConta(string nomeCliente, float saldo)
        {
            NomeCliente = nomeCliente;
            Saldo = saldo;
        }

        public virtual void Depositar(float saldo)
        {
            Saldo += saldo;
        }
    }
}
