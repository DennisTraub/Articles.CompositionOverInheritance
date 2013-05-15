namespace CompositionOverInheritance._2___Interface
{
    public class Auto : IFahrzeug, IMotorisiert
    {
        public int Geschwindigkeit { get; private set; }
        public bool MotorLäuft { get; private set; }
        
        public void Beschleunige(int geschwindigkeit)
        {
            if (MotorLäuft)
                this.Geschwindigkeit = geschwindigkeit;
        }

        public void Starte()
        {
            MotorLäuft = true;
        }
    }
}