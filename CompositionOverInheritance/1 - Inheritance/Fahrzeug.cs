namespace CompositionOverInheritance._1___Inheritance
{
    public abstract class Fahrzeug
    {
        protected int h�chstgeschwindigkeit;
        public int Geschwindigkeit { get; protected set; }

        protected Fahrzeug(int h�chstgeschwindigkeit)
        {
            this.h�chstgeschwindigkeit = h�chstgeschwindigkeit;
        }

        public virtual void Beschleunige(int geschwindigkeit)
        {
            if ( geschwindigkeit > h�chstgeschwindigkeit )
                Geschwindigkeit = h�chstgeschwindigkeit;
            else
                Geschwindigkeit = geschwindigkeit;
        }
    }
}