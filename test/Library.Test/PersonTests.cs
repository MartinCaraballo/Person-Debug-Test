using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void IDValidSet() // Caso en el que si se asigna una id que es válida, realmente cambie.
        {
            // Insertá tu código  de pruebaaquí
            Person Carlos = new Person("Carlos", "5.303.799-7");
            Carlos.ID = "3.705.159-9";
            Assert.AreEqual("3.705.159-9", Carlos.ID);
        }

        [Test]
        public void IDInvalidSet() // Caso en el que se asigna una id que no es válida.
        {
            Person Juan = new Person("Juan", "5.303.799-7");
            Juan.ID = "2.12212.222";
            Assert.AreEqual("5.303.799-7", Juan.ID);
        }

        [Test]
        public void IDWithoutDotsorDashes() // Caso en el que se asigna una id que no tiene puntos o guiones.
        {
            Person Mario = new Person ("Mario", "37051599");
            Assert.AreEqual("37051599", Mario.ID);
        }

        
        
    }
}