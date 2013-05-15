
namespace CompositionOverInheritance._2___Interface
{
    public class Pedelec : IFahrzeug, IMotorisiert
    {
        public int Geschwindigkeit { get; private set; }
        public bool MotorLäuft { get; private set; }

        public void Beschleunige(int geschwindigkeit)
        {
                this.Geschwindigkeit = geschwindigkeit;
        }

        public void Starte()
        {
            MotorLäuft = true;
        }
    }
}
