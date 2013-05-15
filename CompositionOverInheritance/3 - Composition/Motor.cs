namespace CompositionOverInheritance._3___Composition
{
    internal class Motor : IMotor
    {
        public bool MotorLäuft { get; private set; }
        public void Starte()
        {
            MotorLäuft = true;
        }
    }
}