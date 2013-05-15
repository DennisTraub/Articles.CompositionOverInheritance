
namespace CompositionOverInheritance._2___Interface
{
    public class Pedelec : IFahrzeug, IMotor
    {
        protected int höchstgeschwindigkeit = 30;
        
        public int Geschwindigkeit { get; private set; }

        public bool MotorLäuft { get; private set; }

        public void Beschleunige(int geschwindigkeit)
        {
            if ( geschwindigkeit > höchstgeschwindigkeit )
                Geschwindigkeit = höchstgeschwindigkeit;
            else
                Geschwindigkeit = geschwindigkeit;
        }

        public void Starte()
        {
            MotorLäuft = true;
            höchstgeschwindigkeit = 40;
        }
    }
}
