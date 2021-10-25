using NUnit.Framework;
using System;
using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void TestName() // Cambiá el nombre para indicar qué estás probando
        {
            Person john = new Person("John Doe", "1.234.567-8","32/07/1998");
            string expected = "John Doe";
            Assert.AreEqual(expected,john.Name);
            // john.IntroduceYourself();
        }
        [Test]
        public void TestDate() // Cambiá el nombre para indicar qué estás probando
        {
            Person john = new Person("John Doe", "1.234.567-8","18/07/1898");
            String expected = "18/07/1998";
            Assert.AreEqual(expected,john.BornDate);
            // john.IntroduceYourself();
        }
    }
}