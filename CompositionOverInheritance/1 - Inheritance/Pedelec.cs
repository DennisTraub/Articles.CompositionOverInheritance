
namespace CompositionOverInheritance._1___Inheritance
{
    public class Pedelec : MotorisiertesFahrzeug
    {
        public override void Beschleunige(int geschwindigkeit)
        {
            this.Geschwindigkeit = geschwindigkeit;
        }
    }
}
