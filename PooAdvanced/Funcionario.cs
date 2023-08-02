namespace PooAdvanced
{
    public abstract class Funcionario
    {
        private string Nome { get; set; } = string.Empty;
        public double Salario { get; protected set; }

        public abstract void Reajustar();

        public void AdicionarNome(string primeiroNome, string Sobrenome)
        {
            this.Nome = $"{primeiroNome} {Sobrenome}";
        }

        public void AdicionarSalarioPadrao(double salario)
        {
            this.Salario = salario;
        }
    }
}
