namespace CompositionOverInheritance._3___Composition
{
    public interface IFahrzeug
    {
        int Geschwindigkeit();
        void Beschleunige(int geschwindigkeit);
    }

    internal class Fahrzeug : IFahrzeug
    {
        private int geschwindigkeit = 0;
        private readonly int höchstgeschwindigkeit;

        public Fahrzeug(int höchstgeschwindigkeit)
        {
            this.höchstgeschwindigkeit = höchstgeschwindigkeit;
        }

        public int Geschwindigkeit()
        {
            return geschwindigkeit;
        }

        public void Beschleunige(int geschwindigkeit)
        {
            if (geschwindigkeit > höchstgeschwindigkeit)
                this.geschwindigkeit = höchstgeschwindigkeit;
            else
                this.geschwindigkeit = geschwindigkeit;
        }
    }
}