namespace CompositionOverInheritance._3___Composition
{
    public class Fahrrad : IFahrzeug
    {
        private readonly IFahrzeug fahrzeug;

        public Fahrrad(IFahrzeug fahrzeug)
        {
            this.fahrzeug = fahrzeug;
        }

        public int Geschwindigkeit()
        {
            return fahrzeug.Geschwindigkeit();
        }

        public void Beschleunige(int geschwindigkeit)
        {
            fahrzeug.Beschleunige(geschwindigkeit);
        }
    }
}