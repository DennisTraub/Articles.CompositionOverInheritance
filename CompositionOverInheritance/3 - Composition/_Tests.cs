
using NUnit.Framework;

namespace CompositionOverInheritance._3___Composition
{
    [TestFixture]
    public class EinFahrrad
    {
        [Test]
        public void KannBis30KmhBeschleunigen()
        {
            IFahrzeug fahrzeug = new Fahrzeug(30);
            var fahrrad = new Fahrrad(fahrzeug);

            fahrrad.Beschleunige(20);
            Assert.AreEqual(20, fahrrad.Geschwindigkeit());

            fahrrad.Beschleunige(100);
            Assert.AreEqual(30, fahrrad.Geschwindigkeit());
        }
    }

    [TestFixture]
    public class EinAuto
    {
        private IFahrzeug fahrzeug;
        private IMotor motor;

        [SetUp]
        public void Setup()
        {
            fahrzeug = new Fahrzeug(180);
            motor = new Motor();
        }

        [Test]
        public void NichtGestartet_KannNichtBeschleunigen()
        {
            var auto = new Auto(fahrzeug, motor);

            auto.Beschleunige(120);
            Assert.AreEqual(0, auto.Geschwindigkeit());
        }

        [Test]
        public void Gestartet_KannBis180KmhBeschleunigen()
        {
            var auto = new Auto(fahrzeug, motor);
            auto.Starte();

            auto.Beschleunige(120);
            Assert.AreEqual(120, auto.Geschwindigkeit());

            auto.Beschleunige(250);
            Assert.AreEqual(180, auto.Geschwindigkeit());
        }
    }

    [TestFixture]
    public class EinPedelec
    {
        private IFahrzeug fahrrad = new Fahrrad(new Fahrzeug(30));
        private IMotor motor = new Motor();

        [SetUp]
        public void Setup()
        {
            var fahrzeug = new Fahrzeug(30);
            fahrrad = new Fahrrad(fahrzeug);
            motor = new Motor();
        }

        [Test]
        public void NichtGestartet_KannBis30KmhBeschleunigen()
        {
            var pedelec = new Pedelec(fahrrad, motor);

            pedelec.Beschleunige(20);
            Assert.AreEqual(20, pedelec.Geschwindigkeit());

            pedelec.Beschleunige(100);
            Assert.AreEqual(30, pedelec.Geschwindigkeit());
        }

        [Test]
        public void Gestartet_KannBis40KmhBeschleunigen()
        {
            var pedelec = new Pedelec(fahrrad, motor);
            pedelec.Starte();

            pedelec.Beschleunige(20);
            Assert.AreEqual(20, pedelec.Geschwindigkeit());

            pedelec.Beschleunige(100);
            Assert.AreEqual(40, pedelec.Geschwindigkeit());
        }
    }
}
