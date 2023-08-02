namespace PooAdvanced
{
    public class Gerente : Funcionario
    {
        public override void Reajustar() 
        {
            this.Salario += 1000;
        }
    }
}
