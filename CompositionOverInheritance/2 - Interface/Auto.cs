namespace CompositionOverInheritance._2___Interface
{
    public class Auto : IFahrzeug, IMotorisiert
    {
        protected int höchstgeschwindigkeit = 180;
        public int Geschwindigkeit { get; private set; }
        public bool MotorLäuft { get; private set; }
        
        public void Beschleunige(int geschwindigkeit)
        {
            if (MotorLäuft)
            {
                if (geschwindigkeit > höchstgeschwindigkeit)
                    Geschwindigkeit = höchstgeschwindigkeit;
                else
                    Geschwindigkeit = geschwindigkeit;
            }
        }

        public void Starte()
        {
            MotorLäuft = true;
        }
    }
}