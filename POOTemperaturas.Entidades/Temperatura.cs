namespace POOTemperaturas.Entidades
{
    public class Temperatura
    {
        public float Valor { get; set; }

        //Constructor
        public Temperatura()
        {

        }
        public Temperatura(float valorTemp)
        {
            Valor = valorTemp;
        }
        public double GetEquivalenteFahrenheit()
        {
            return 1.8 * Valor + 32;
        }
        public double GetEquivalenteReaumur() => 0.8 * Valor;
    }
}
