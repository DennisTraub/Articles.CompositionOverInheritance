namespace CompositionOverInheritance._1___Inheritance
{
    public abstract class MotorisiertesFahrzeug : Fahrzeug
    {
        private bool motorL�uft;

        public virtual void Starte()
        {
            this.motorL�uft = true;
        }

        public override void Beschleunige(int geschwindigkeit)
        {
            if (motorL�uft)
                base.Beschleunige(geschwindigkeit);
        }
    }
}