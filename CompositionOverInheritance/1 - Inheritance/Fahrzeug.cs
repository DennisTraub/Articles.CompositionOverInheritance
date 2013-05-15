namespace CompositionOverInheritance._1___Inheritance
{
    public abstract class Fahrzeug
    {
        public int Geschwindigkeit { get; protected set; }
        public int Höchstgeschwindigkeit { get; protected set; }

        public virtual void Beschleunige(int geschwindigkeit)
        {
            if ( geschwindigkeit > Höchstgeschwindigkeit )
                Geschwindigkeit = Höchstgeschwindigkeit;
            else
                Geschwindigkeit = geschwindigkeit;
        }
    }
}