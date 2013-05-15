namespace CompositionOverInheritance._3___Composition
{
    internal class Motor : IMotor
    {
        private bool motorLäuft = false;

        public bool MotorLäuft()
        {
            return motorLäuft;
        }

        public void Starte()
        {
            this.motorLäuft = true;
        }
    }
}