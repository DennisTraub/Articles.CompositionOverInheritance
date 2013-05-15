namespace CompositionOverInheritance._3___Composition
{
    public class Auto : IFahrzeug, IMotor
    {
        private readonly IFahrzeug fahrzeug = new Fahrzeug();
        private readonly IMotor motor = new Motor();

        public int Geschwindigkeit
        {
            get { return fahrzeug.Geschwindigkeit; }
        }

        public bool MotorLäuft
        {
            get { return motor.MotorLäuft; }
        }

        public void Beschleunige(int geschwindigkeit)
        {
            if (MotorLäuft)
                fahrzeug.Beschleunige(geschwindigkeit);
        }
        
        public void Starte()
        {
            motor.Starte();
        }
    }
}