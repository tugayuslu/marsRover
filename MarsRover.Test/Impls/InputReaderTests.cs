using MarsRover.Biz.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using static MarsRover.Biz.Models.Enums;

namespace MarsRover.Biz.Impls.Tests
{
    [TestClass()]
    public class InputReaderTests
    {
        [TestMethod()]
        public void ReadUpperRightBoundariesTest()
        {
            InputReader.ReadUpperRightBoundaries("5 6");

            Assert.AreEqual(new Location(5, 6), Plateau.UpperRightBoundaries);
        }

        [TestMethod()]
        public void ReadUpperRightBoundariesTest2()
        {
            InputReader.ReadUpperRightBoundaries("  1 2  ");

            Assert.AreEqual(new Location(1, 2), Plateau.UpperRightBoundaries);
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void ReadUpperRightBoundariesTest3()
        {
            InputReader.ReadUpperRightBoundaries("-1 2");
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void ReadUpperRightBoundariesTest4()
        {
            InputReader.ReadUpperRightBoundaries("a 2");
        }

        [TestMethod()]
        public void ReadRoverAgentTest()
        {
            Plateau.UpperRightBoundaries = new Location(5, 5);

            var roverAgent = InputReader.ReadRoverAgent("1 2 N");

            Assert.AreEqual($"{1} {2} {(char)DirectionEnumeration.North}",
                $"{roverAgent.Location.X} {roverAgent.Location.Y} {(char)roverAgent.Direction.DirectionEnumeration}");
        }

        [TestMethod()]
        public void ReadRoverAgentTes2()
        {
            Plateau.UpperRightBoundaries = new Location(5, 5);

            var roverAgent = InputReader.ReadRoverAgent(" 3 3 s ");

            Assert.AreEqual($"{3} {3} {(char)DirectionEnumeration.South}",
                $"{roverAgent.Location.X} {roverAgent.Location.Y} {(char)roverAgent.Direction.DirectionEnumeration}");
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void ReadRoverAgentTes3()
        {
            Plateau.UpperRightBoundaries = new Location(1, 5);

            InputReader.ReadRoverAgent("1 2 N a");
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void ReadRoverAgentTes4()
        {
            Plateau.UpperRightBoundaries = new Location(1, 1);

            InputReader.ReadRoverAgent("1 2 N");
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void ReadRoverAgentTes5()
        {
            Plateau.UpperRightBoundaries = new Location(1, 5);

            InputReader.ReadRoverAgent("1 2 a");
        }

        [TestMethod()]
        public void ReadCommandsTest()
        {
            var commands = InputReader.ReadCommands(" LrMLR ");

            var expectedCommands = new List<CommandEnumeration>()
            {
                CommandEnumeration.Left,
                CommandEnumeration.Right,
                CommandEnumeration.Move,
                CommandEnumeration.Left,
                CommandEnumeration.Right
            };

            Assert.AreEqual(true, Enumerable.SequenceEqual(commands, expectedCommands));
        }

        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void ReadCommandsTest2()
        {
            InputReader.ReadCommands(" La ");
        }

    }
}