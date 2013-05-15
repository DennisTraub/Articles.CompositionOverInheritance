namespace CompositionOverInheritance._3___Composition
{
    public interface IMotor
    {
        bool MotorLäuft();
        void Starte();
    }

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