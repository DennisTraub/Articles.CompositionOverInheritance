namespace CompositionOverInheritance._2___Interface
{
    public class Fahrrad : IFahrzeug
    {
        protected int höchstgeschwindigkeit = 30;
        public int Geschwindigkeit { get; private set; }

        public void Beschleunige(int geschwindigkeit)
        {
            if (geschwindigkeit > höchstgeschwindigkeit)
                Geschwindigkeit = höchstgeschwindigkeit;
            else
                Geschwindigkeit = geschwindigkeit;
        }
    }
}