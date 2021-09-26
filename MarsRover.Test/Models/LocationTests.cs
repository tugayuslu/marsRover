using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRover.Biz.Models.Tests
{
    [TestClass()]
    public class LocationTests
    {
        [TestMethod()]
        public void LocationToMoveTestNorth()
        {
            var result = new Location().LocationToMove(Enums.DirectionEnumeration.North);

            Assert.AreEqual(new Location(0, 1), result);
        }

        [TestMethod()]
        public void LocationToMoveTestEast()
        {
            var result = new Location().LocationToMove(Enums.DirectionEnumeration.East);

            Assert.AreEqual(new Location(1, 0), result);
        }

        [TestMethod()]
        public void LocationToMoveTestSouth()
        {
            var result = new Location().LocationToMove(Enums.DirectionEnumeration.South);

            Assert.AreEqual(new Location(0, -1), result);
        }

        [TestMethod()]
        public void LocationToMoveTestWest()
        {
            var result = new Location().LocationToMove(Enums.DirectionEnumeration.West);

            Assert.AreEqual(new Location(-1, 0), result);
        }
    }
}