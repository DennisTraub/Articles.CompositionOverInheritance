namespace CompositionOverInheritance._3___Composition
{
    internal class Fahrzeug : IFahrzeug
    {
        public int Geschwindigkeit { get; private set; }

        public void Beschleunige(int geschwindigkeit)
        {
            Geschwindigkeit = geschwindigkeit;
        }
    }
}