using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover.Biz.Models;

namespace MarsRover.Biz.Impls.Tests
{
    [TestClass()]
    public class PlateauTests
    {
        [TestMethod()]
        public void CheckBoundariesTest()
        {
            Plateau.UpperRightBoundaries = new Location(2, 5);

            Assert.AreEqual(true, Plateau.CheckBoundaries(new Location(1, 3)));
        }

        [TestMethod()]
        public void CheckBoundariesTest2()
        {
            Plateau.UpperRightBoundaries = new Location(2, 5);

            Assert.AreEqual(true, Plateau.CheckBoundaries(new Location(2, 5)));
        }

        [TestMethod()]
        public void CheckBoundariesTest3()
        {
            Plateau.UpperRightBoundaries = new Location(2, 5);

            Assert.AreEqual(true, Plateau.CheckBoundaries(new Location(0, 0)));
        }

        [TestMethod()]
        public void CheckBoundariesTest4()
        {
            Plateau.UpperRightBoundaries = new Location(2, 5);

            Assert.AreEqual(false, Plateau.CheckBoundaries(new Location(2, 6)));
        }

        [TestMethod()]
        public void CheckBoundariesTest5()
        {
            Plateau.UpperRightBoundaries = new Location(2, 5);

            Assert.AreEqual(false, Plateau.CheckBoundaries(new Location(-1, 5)));
        }
    }
}