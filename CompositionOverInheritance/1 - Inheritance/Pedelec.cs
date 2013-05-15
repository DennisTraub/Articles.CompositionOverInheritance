
namespace CompositionOverInheritance._1___Inheritance
{
    public class Pedelec : MotorisiertesFahrzeug
    {
        public Pedelec()
        {
            Höchstgeschwindigkeit = 30;
        }

        public override void Beschleunige(int geschwindigkeit)
        {
            if (geschwindigkeit > Höchstgeschwindigkeit)
                Geschwindigkeit = Höchstgeschwindigkeit;
            else
                Geschwindigkeit = geschwindigkeit;
        }

        public override void Starte()
        {
            base.Starte();
            Höchstgeschwindigkeit = 40;
        }
    }
}
