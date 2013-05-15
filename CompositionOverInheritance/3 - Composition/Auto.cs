namespace CompositionOverInheritance._3___Composition
{
    public class Auto : IFahrzeug, IMotor
    {
        private readonly IFahrzeug fahrzeug = new Fahrzeug(180);
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
            if (MotorLäuft())
                fahrzeug.Beschleunige(geschwindigkeit);
        }
        
        public void Starte()
        {
            motor.Starte();
        }
    }
}