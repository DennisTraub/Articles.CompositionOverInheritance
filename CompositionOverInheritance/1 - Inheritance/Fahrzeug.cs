namespace CompositionOverInheritance._1___Inheritance
{
    public abstract class Fahrzeug
    {
        protected int h�chstgeschwindigkeit;
        public int Geschwindigkeit { get; protected set; }

        public virtual void Beschleunige(int geschwindigkeit)
        {
            if ( geschwindigkeit > h�chstgeschwindigkeit )
                Geschwindigkeit = h�chstgeschwindigkeit;
            else
                Geschwindigkeit = geschwindigkeit;
        }
    }
}