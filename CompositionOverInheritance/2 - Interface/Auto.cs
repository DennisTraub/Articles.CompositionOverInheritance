namespace CompositionOverInheritance._2___Interface
{
    public class Auto : IFahrzeug, IMotorisiert
    {
        protected int h�chstgeschwindigkeit = 180;
        public int Geschwindigkeit { get; private set; }
        public bool MotorL�uft { get; private set; }
        
        public void Beschleunige(int geschwindigkeit)
        {
            if (MotorL�uft)
            {
                if (geschwindigkeit > h�chstgeschwindigkeit)
                    Geschwindigkeit = h�chstgeschwindigkeit;
                else
                    Geschwindigkeit = geschwindigkeit;
            }
        }

        public void Starte()
        {
            MotorL�uft = true;
        }
    }
}