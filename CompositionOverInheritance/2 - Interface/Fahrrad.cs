namespace CompositionOverInheritance._2___Interface
{
    public class Fahrrad : IFahrzeug
    {
        protected int h�chstgeschwindigkeit = 30;
        public int Geschwindigkeit { get; private set; }

        public void Beschleunige(int geschwindigkeit)
        {
            if (geschwindigkeit > h�chstgeschwindigkeit)
                Geschwindigkeit = h�chstgeschwindigkeit;
            else
                Geschwindigkeit = geschwindigkeit;
        }
    }
}