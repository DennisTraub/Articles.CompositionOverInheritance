namespace CompositionOverInheritance._3___Composition
{
    public class Fahrrad : IFahrzeug
    {
        private readonly IFahrzeug fahrzeug = new Fahrzeug();

        public int Geschwindigkeit()
        {
            return fahrzeug.Geschwindigkeit();
        }

        public void Beschleunige(int geschwindigkeit)
        {
            // Delegation
            fahrzeug.Beschleunige(geschwindigkeit);
        }
    }
}