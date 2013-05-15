namespace CompositionOverInheritance._1___Inheritance
{
    public abstract class Fahrzeug
    {
        public int Geschwindigkeit { get; protected set; }
        protected int höchstgeschwindigkeit;

        public virtual void Beschleunige(int geschwindigkeit)
        {
            if ( geschwindigkeit > höchstgeschwindigkeit )
                Geschwindigkeit = höchstgeschwindigkeit;
            else
                Geschwindigkeit = geschwindigkeit;
        }
    }
}