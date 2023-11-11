
using Lab3Wo.Models;
using Lab3Wo.Classes;

namespace Testing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            InfTriangle actual = Controller.GetControl("@", "$", "^");
            string expect = "Нечисловые данные";
            Assert.That(actual.Type, Is.EqualTo(expect));
        }
        [Test]
        public void Test2()
        {
            InfTriangle actual = Controller.GetControl("@", ")", "^");
            string expect = "Нечисловые данные";
            Assert.That(actual.Type, Is.EqualTo(expect));
        }


    }
}