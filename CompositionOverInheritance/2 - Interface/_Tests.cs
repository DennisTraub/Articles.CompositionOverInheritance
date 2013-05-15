
using NUnit.Framework;

namespace CompositionOverInheritance._2___Interface
{
    [TestFixture]
    public class EinFahrrad
    {
        [Test]
        public void KannBis30KmhBeschleunigen()
        {
            var fahrrad = new Fahrrad();

            fahrrad.Beschleunige(20);
            Assert.AreEqual(20, fahrrad.Geschwindigkeit);

            fahrrad.Beschleunige(100);
            Assert.AreEqual(30, fahrrad.Geschwindigkeit);
        }
    }

    [TestFixture]
    public class EinAuto
    {
        [Test]
        public void NichtGestartet_KannNichtBeschleunigen()
        {
            var auto = new Auto();

            auto.Beschleunige(120);
            Assert.AreEqual(0, auto.Geschwindigkeit);
        }

        [Test]
        public void Gestartet_KannBis180KmhBeschleunigen()
        {
            var auto = new Auto();
            auto.Starte();

            auto.Beschleunige(120);
            Assert.AreEqual(120, auto.Geschwindigkeit);

            auto.Beschleunige(250);
            Assert.AreEqual(180, auto.Geschwindigkeit);
        }
    }

    [TestFixture]
    public class EinPedelec
    {
        [Test]
        public void NichtGestartet_KannBis30KmhBeschleunigen()
        {
            var pedelec = new Pedelec();

            pedelec.Beschleunige(20);
            Assert.AreEqual(20, pedelec.Geschwindigkeit);

            pedelec.Beschleunige(100);
            Assert.AreEqual(30, pedelec.Geschwindigkeit);
        }

        [Test]
        public void Gestartet_KannBis40KmhBeschleunigen()
        {
            var pedelec = new Pedelec();
            pedelec.Starte();

            pedelec.Beschleunige(20);
            Assert.AreEqual(20, pedelec.Geschwindigkeit);

            pedelec.Beschleunige(100);
            Assert.AreEqual(40, pedelec.Geschwindigkeit);
        }
    }
}
