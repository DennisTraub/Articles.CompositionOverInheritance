
using NUnit.Framework;

namespace CompositionOverInheritance._2___Interface
{
    [TestFixture]
    public class EinFahrrad
    {
        [Test]
        public void KannBeschleunigen()
        {
            var fahrrad = new Fahrrad();
            fahrrad.Beschleunige(20);
            Assert.AreEqual(20, fahrrad.Geschwindigkeit);
        }
    }

    [TestFixture]
    public class EinAutoDasNichtGestartetWurde
    {
        [Test]
        public void KannNichtBeschleunigen()
        {
            var auto = new Auto();
            auto.Beschleunige(120);
            Assert.AreEqual(0, auto.Geschwindigkeit);
        }
    }

    [TestFixture]
    public class EinAutoDasGestartetWurde
    {
        [Test]
        public void KannBeschleunigen()
        {
            var auto = new Auto();
            auto.Starte();
            auto.Beschleunige(120);
            Assert.AreEqual(120, auto.Geschwindigkeit);
        }
    }

    [TestFixture]
    public class EinPedelecDasGestartetWurde
    {
        [Test]
        public void KannBeschleunigen()
        {
            var pedelec = new Pedelec();
            pedelec.Starte();
            pedelec.Beschleunige(20);
            Assert.AreEqual(20, pedelec.Geschwindigkeit);
        }
    }

    [TestFixture]
    public class EinPedelecDasNichtGestartetWurde
    {
        [Test]
        public void KannBeschleunigen()
        {
            var pedelec = new Pedelec();
            pedelec.Beschleunige(20);
            Assert.AreEqual(20, pedelec.Geschwindigkeit);
        }
    }
}
