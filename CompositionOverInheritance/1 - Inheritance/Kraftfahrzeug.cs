namespace CompositionOverInheritance._1___Inheritance
{
    public abstract class Kraftfahrzeug : Fahrzeug
    {
        private bool motorLäuft;

        protected Kraftfahrzeug(int höchstgeschwindigkeit)
            : base(höchstgeschwindigkeit) {}

        public virtual void Starte()
        {
            this.motorLäuft = true;
        }

        public override void Beschleunige(int geschwindigkeit)
        {
            if (motorLäuft)
                base.Beschleunige(geschwindigkeit);
        }
    }
}