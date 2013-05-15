namespace CompositionOverInheritance._3___Composition
{
    internal class Fahrzeug : IFahrzeug
    {
        private int geschwindigkeit = 0;

        public int Geschwindigkeit()
        {
            return geschwindigkeit;
        }

        public void Beschleunige(int geschwindigkeit)
        {
            this.geschwindigkeit = geschwindigkeit;
        }
    }
}