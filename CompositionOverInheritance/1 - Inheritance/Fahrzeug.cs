namespace CompositionOverInheritance._1___Inheritance
{
    public abstract class Fahrzeug
    {
        public int Geschwindigkeit { get; protected set; }

        public virtual void Beschleunige(int geschwindigkeit)
        {
            this.Geschwindigkeit = geschwindigkeit;
        }
    }
}