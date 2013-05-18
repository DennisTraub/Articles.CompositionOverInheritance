namespace CompositionOverInheritance._3___Composition
{
    public class Pedelec : IFahrzeug, IMotor
    {
        private IFahrzeug fahrzeug;
        private readonly IMotor motor;

        public Pedelec(IFahrzeug fahrzeug, IMotor motor)
        {
            this.fahrzeug = fahrzeug;
            this.motor = motor;
        }

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
            fahrzeug = new Fahrzeug().MitHöchstgeschwindigkeit(40);
        }
    }
}