namespace CompositionOverInheritance._3___Composition
{
    public class Auto : IFahrzeug, IMotor
    {
        private readonly IFahrzeug fahrzeug;
        private readonly IMotor motor;

        public Auto(IFahrzeug fahrzeug, IMotor motor)
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
            if (MotorLäuft())
                fahrzeug.Beschleunige(geschwindigkeit);
        }
        
        public void Starte()
        {
            motor.Starte();
        }
    }
}