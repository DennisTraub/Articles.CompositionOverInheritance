namespace CompositionOverInheritance._3___Composition
{
    public class Pedelec : IFahrzeug, IMotor
    {
        private IFahrzeug fahrzeug = new Fahrzeug(30);
        private readonly IMotor motor = new Motor();

        public int Geschwindigkeit()
        {
            return fahrzeug.Geschwindigkeit();
        }

        public bool MotorLäuft()
        {
            return motor.MotorLäuft();
        }

        public void Beschleunige(int geschwindigkeit)
        {
            fahrzeug.Beschleunige(geschwindigkeit);
        }

        public void Starte()
        {
            motor.Starte();
            fahrzeug = new Fahrzeug(40);
        }
    }
}