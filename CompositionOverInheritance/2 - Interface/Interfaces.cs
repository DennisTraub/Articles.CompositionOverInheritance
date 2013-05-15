namespace CompositionOverInheritance._2___Interface
{
    public interface IFahrzeug
    {
        int Geschwindigkeit { get; }
        void Beschleunige(int geschwindigkeit);
    }

    public interface IMotor
    {
        bool MotorLäuft { get; }
        void Starte();
    }
}