﻿
using NUnit.Framework;

namespace CompositionOverInheritance._1___Inheritance
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

    [TestFixture]
    public class EinFahrradHatEineHöchstgeschwindigkeit
    {
        [Test]
        public void DieNichtÜberschrittenWerdenKann()
        {
            var fahrrad = new Fahrrad();
            fahrrad.Beschleunige(100);
            var höchstgeschwindigkeit = fahrrad.Höchstgeschwindigkeit;
            Assert.AreEqual(höchstgeschwindigkeit, fahrrad.Geschwindigkeit);
        }
    }

    [TestFixture]
    public class EinAutoHatEineHöchstgeschwindigkeit
    {
        [Test]
        public void DieNichtÜberschrittenWerdenKann()
        {
            var auto = new Auto();
            auto.Starte();
            auto.Beschleunige(250);
            var höchstgeschwindigkeit = auto.Höchstgeschwindigkeit;
            Assert.AreEqual(höchstgeschwindigkeit, auto.Geschwindigkeit);
        }
    }

    [TestFixture]
    public class EinPedelecHatEineHöchstgeschwindigkeit
    {
        [Test]
        public void DieNichtÜberschrittenWerdenKann()
        {
            var pedelec = new Pedelec();
            var höchstgeschwindigkeit = pedelec.Höchstgeschwindigkeit;
            Assert.AreEqual(30, höchstgeschwindigkeit);

            pedelec.Beschleunige(50);
            Assert.AreEqual(höchstgeschwindigkeit, pedelec.Geschwindigkeit);
        }
    }

    [TestFixture]
    public class EinGestartetesPedelec
    {
        [Test]
        public void HatEineAndereHöchstgeschwindigkeit()
        {
            var pedelec = new Pedelec();
            pedelec.Starte();
            var höchstgeschwindigkeit = pedelec.Höchstgeschwindigkeit;
            Assert.AreEqual(40, höchstgeschwindigkeit);

            pedelec.Beschleunige(50);
            Assert.AreEqual(höchstgeschwindigkeit, pedelec.Geschwindigkeit);
        }
    }
}
