using Microsoft.VisualStudio.TestTools.UnitTesting;
using static MarsRover.Biz.Models.Enums;

namespace MarsRover.Biz.Impls.Tests
{
    [TestClass()]
    public class DirectionTests
    {
        [TestMethod()]
        public void TurnLeftTestNorth()
        {
            var direction = new Direction() { DirectionEnumeration = DirectionEnumeration.North };
            direction.TurnLeft();

            Assert.AreEqual(DirectionEnumeration.West, direction.DirectionEnumeration);
        }

        [TestMethod()]
        public void TurnLeftTestEast()
        {
            var direction = new Direction() { DirectionEnumeration = DirectionEnumeration.East };
            direction.TurnLeft();

            Assert.AreEqual(DirectionEnumeration.North, direction.DirectionEnumeration);
        }

        [TestMethod()]
        public void TurnLeftTestSouth()
        {
            var direction = new Direction() { DirectionEnumeration = DirectionEnumeration.South };
            direction.TurnLeft();

            Assert.AreEqual(DirectionEnumeration.East, direction.DirectionEnumeration);
        }

        [TestMethod()]
        public void TurnLeftTestWest()
        {
            var direction = new Direction() { DirectionEnumeration = DirectionEnumeration.West };
            direction.TurnLeft();

            Assert.AreEqual(DirectionEnumeration.South, direction.DirectionEnumeration);
        }

        [TestMethod()]
        public void TurnRightTestNorth()
        {
            var direction = new Direction() { DirectionEnumeration = DirectionEnumeration.North };
            direction.TurnRight();

            Assert.AreEqual(DirectionEnumeration.East, direction.DirectionEnumeration);
        }

        [TestMethod()]
        public void TurnRightTestEast()
        {
            var direction = new Direction() { DirectionEnumeration = DirectionEnumeration.East };
            direction.TurnRight();

            Assert.AreEqual(DirectionEnumeration.South, direction.DirectionEnumeration);
        }

        [TestMethod()]
        public void TurnRightTestSouth()
        {
            var direction = new Direction() { DirectionEnumeration = DirectionEnumeration.South };
            direction.TurnRight();

            Assert.AreEqual(DirectionEnumeration.West, direction.DirectionEnumeration);
        }

        [TestMethod()]
        public void TurnRightTestWest()
        {
            var direction = new Direction() { DirectionEnumeration = DirectionEnumeration.West };
            direction.TurnRight();

            Assert.AreEqual(DirectionEnumeration.North, direction.DirectionEnumeration);
        }
    }
}