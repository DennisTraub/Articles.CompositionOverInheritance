namespace CompositionOverInheritance._1___Inheritance
{
    public abstract class Fahrzeug
    {
        public int Geschwindigkeit { get; protected set; }
        public int H�chstgeschwindigkeit { get; protected set; }

        public virtual void Beschleunige(int geschwindigkeit)
        {
            if ( geschwindigkeit > H�chstgeschwindigkeit )
                Geschwindigkeit = H�chstgeschwindigkeit;
            else
                Geschwindigkeit = geschwindigkeit;
        }
    }
}