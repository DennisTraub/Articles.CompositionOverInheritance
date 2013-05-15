namespace CompositionOverInheritance._2___Interface
{
    public class Auto : IFahrzeug, IMotorisiert
    {
        public int Geschwindigkeit { get; private set; }
        public bool MotorL�uft { get; private set; }
        
        public void Beschleunige(int geschwindigkeit)
        {
            if (MotorL�uft)
                this.Geschwindigkeit = geschwindigkeit;
        }

        public void Starte()
        {
            MotorL�uft = true;
        }
    }
}