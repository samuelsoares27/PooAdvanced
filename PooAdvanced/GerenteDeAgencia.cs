namespace PooAdvanced
{
    public class GerenteDeAgencia : Gerente
    {
        public override void Reajustar()
        {
            this.Salario += 1200;
        }
    }
}
