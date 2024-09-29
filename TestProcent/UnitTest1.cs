using HardProcent;
namespace TestProcent
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TryAllParametrsBelowZero_Test1_0()
        {
            double test = Checker.HardProcentFunction(-1, -1, -1, -1);

            Assert.AreEqual(4, test);
        }
        [TestMethod]
        public void TryStartCapitalAboveZero_Test2_1()
        {
            double test = Checker.HardProcentFunction(1, -1, -1, -1);

            Assert.AreEqual(4, test);
        }
        [TestMethod]
        public void TryStartCapitalAndProcentStavkaAboveZero_Test3_2()
        {
            double test = Checker.HardProcentFunction(1, 1, -1, -1);

            Assert.AreEqual(4, test);
        }
        [TestMethod]
        public void TryStartCapitalAndProcentStavkaAndTimeInYearsAboveZero_Test4_3()
        {
            double test = Checker.HardProcentFunction(1, 1, 1, -1);

            Assert.AreEqual(4, test);
        }
        [TestMethod]
        public void TryAllAboveZero_Test5_4()
        {
            double test = Checker.HardProcentFunction(1, 1, 1, 1);

            Assert.AreEqual(4, test);
        }

    }
}