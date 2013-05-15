namespace CompositionOverInheritance._1___Inheritance
{
    public abstract class Fahrzeug
    {
        protected int höchstgeschwindigkeit;
        public int Geschwindigkeit { get; protected set; }

        protected Fahrzeug(int höchstgeschwindigkeit)
        {
            this.höchstgeschwindigkeit = höchstgeschwindigkeit;
        }

        public virtual void Beschleunige(int geschwindigkeit)
        {
            if ( geschwindigkeit > höchstgeschwindigkeit )
                Geschwindigkeit = höchstgeschwindigkeit;
            else
                Geschwindigkeit = geschwindigkeit;
        }
    }
}