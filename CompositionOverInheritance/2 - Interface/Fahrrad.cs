namespace CompositionOverInheritance._2___Interface
{
    public class Fahrrad : IFahrzeug
    {
        public int Geschwindigkeit { get; private set; }
        public void Beschleunige(int geschwindigkeit)
        {
            this.Geschwindigkeit = geschwindigkeit;
        }
    }
}