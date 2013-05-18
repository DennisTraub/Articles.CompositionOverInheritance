namespace CompositionOverInheritance._3___Composition
{
    public interface IFahrzeug
    {
        int Geschwindigkeit();
        void Beschleunige(int geschwindigkeit);
    }

    internal class Fahrzeug : IFahrzeug
    {
        private int geschwindigkeit;
        private int höchstgeschwindigkeit;

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

        public IFahrzeug MitHöchstgeschwindigkeit(int höchstgeschwindigkeit)
        {
            this.höchstgeschwindigkeit = höchstgeschwindigkeit;
            return this;
        }
    }
}