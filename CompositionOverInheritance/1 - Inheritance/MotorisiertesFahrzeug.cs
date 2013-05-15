namespace CompositionOverInheritance._1___Inheritance
{
    public abstract class MotorisiertesFahrzeug : Fahrzeug
    {
        private bool motorLäuft;

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