using NUnit.Framework;
using DataAccessLogicLayer;

namespace NUnitTesting
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
            //Assign or Arrange
            int pid = 1001;
            string ptype = "Margherita";

            //Act
            string acname = PizzaHelper.GetENameById(pid);

            //Assert

            Assert.AreEqual(ptype, acname);
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            //Assign or Arrange
            int pid = 1007;
            string ptype = "Veggie Farmhouse";

            //Act
            string acname = PizzaHelper.GetENameById(pid);

            //Assert

            Assert.AreEqual(ptype, acname);
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            //Assign or Arrange
            int pid = 1003;
            string ptype = "Mexican Greenwave";

            //Act
            string acname = PizzaHelper.GetENameById(pid);

            //Assert

            Assert.AreEqual(ptype, acname);
            Assert.Pass();
        }

        [Test]
        public void Test4()
        {
            //Assign or Arrange
            int pid = 1001;
            string ptype = "Peppy Paneer";

            //Act
            string acname = PizzaHelper.GetENameById(pid);

            //Assert

            Assert.AreEqual(ptype, acname);
            Assert.Pass();
        }

        [Test]
        public void Test5()
        {
            //Assign or Arrange
            int pid = 1006;
            string ptype = "Chicken Fiesta";

            //Act
            string acname = PizzaHelper.GetENameById(pid);

            //Assert

            Assert.AreEqual(ptype, acname);
            Assert.Pass();
        }
    }
}