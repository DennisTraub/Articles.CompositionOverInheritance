﻿
namespace CompositionOverInheritance._1___Inheritance
{
    public class Pedelec : Kraftfahrzeug
    {
        public Pedelec() : base(30) {}

        public override void Beschleunige(int geschwindigkeit)
        {
            if (geschwindigkeit > höchstgeschwindigkeit)
                Geschwindigkeit = höchstgeschwindigkeit;
            else
                Geschwindigkeit = geschwindigkeit;
        }

        public override void Starte()
        {
            base.Starte();
            höchstgeschwindigkeit = 40;
        }
    }
}
