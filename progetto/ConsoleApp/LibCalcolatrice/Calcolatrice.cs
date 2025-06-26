namespace LibCalcolatrice
{
    public class Calcolatrice
    {
        public int Somma(int addendo1, int addendo2)
        {
            return addendo1 + addendo2;
        }
        //crea metodi calcolatrice
        public int Sottrai(int minuendo, int sottraendo)
        {
            return minuendo - sottraendo;
        }
        public int Moltiplica(int fattore1, int fattore2)
        {
            return fattore1 * fattore2;
        }
        public int Dividi(int dividendo, int divisore)
        {
            if (divisore == 0)
            {
                throw new DivideByZeroException("Il divisore non può essere zero.");
            }
            return dividendo / divisore;
        }
    }
}
