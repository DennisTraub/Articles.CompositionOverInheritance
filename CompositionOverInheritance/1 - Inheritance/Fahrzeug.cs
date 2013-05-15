namespace CompositionOverInheritance._1___Inheritance
{
    public abstract class Fahrzeug
    {
        public int Geschwindigkeit { get; protected set; }
        protected int h�chstgeschwindigkeit;

        public virtual void Beschleunige(int geschwindigkeit)
        {
            if ( geschwindigkeit > h�chstgeschwindigkeit )
                Geschwindigkeit = h�chstgeschwindigkeit;
            else
                Geschwindigkeit = geschwindigkeit;
        }
    }
}