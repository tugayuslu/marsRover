using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MarsRover.Biz.Models;
using static MarsRover.Biz.Models.Enums;

namespace MarsRover.Biz.Impls.Tests
{
    [TestClass()]
    public class RoverAgentTests
    {
        [TestMethod()]
        public void ProcessCommandsTest()
        {
            Plateau.UpperRightBoundaries = new Location(5, 5);

            var roverAgent = new RoverAgent(new Location(1, 2), new Direction() { DirectionEnumeration = DirectionEnumeration.North });

            roverAgent.SetCommands(new List<CommandEnumeration>()
            {
                CommandEnumeration.Left,
                CommandEnumeration.Move,
                CommandEnumeration.Left,
                CommandEnumeration.Move,
                CommandEnumeration.Left,
                CommandEnumeration.Move,
                CommandEnumeration.Left,
                CommandEnumeration.Move,
                CommandEnumeration.Move
            });

            roverAgent.SetRoverAgentLocations(new List<Location>()
            {
                new Location(3,3)
            });

            roverAgent.ProcessCommands();

            Assert.AreEqual("1 3 N", $"{roverAgent.Location.X} {roverAgent.Location.Y} {(char)roverAgent.Direction.DirectionEnumeration}");
        }

        [TestMethod()]
        public void ProcessCommandsTest2()
        {
            Plateau.UpperRightBoundaries = new Location(5, 5);

            var roverAgent = new RoverAgent(new Location(3, 3), new Direction() { DirectionEnumeration = DirectionEnumeration.East });

            roverAgent.SetCommands(new List<CommandEnumeration>()
            {
                CommandEnumeration.Move,
                CommandEnumeration.Move,
                CommandEnumeration.Right,
                CommandEnumeration.Move,
                CommandEnumeration.Move,
                CommandEnumeration.Right,
                CommandEnumeration.Move,
                CommandEnumeration.Right,
                CommandEnumeration.Right,
                CommandEnumeration.Move,
            });

            roverAgent.SetRoverAgentLocations(new List<Location>()
            {
                new Location(1,3)
            });

            roverAgent.ProcessCommands();

            Assert.AreEqual("5 1 E", $"{roverAgent.Location.X} {roverAgent.Location.Y} {(char)roverAgent.Direction.DirectionEnumeration}");
        }

        [TestMethod()]
        public void ProcessCommandsTest3()
        {
            Plateau.UpperRightBoundaries = new Location(5, 5);

            var roverAgent = new RoverAgent(new Location(1, 1), new Direction() { DirectionEnumeration = DirectionEnumeration.North });

            roverAgent.SetCommands(new List<CommandEnumeration>()
            {
                CommandEnumeration.Move,
                CommandEnumeration.Move,
                CommandEnumeration.Right,
                CommandEnumeration.Move,
                CommandEnumeration.Move,
                CommandEnumeration.Right,
                CommandEnumeration.Move,
                CommandEnumeration.Move,
                CommandEnumeration.Right,
                CommandEnumeration.Move,
                CommandEnumeration.Move,
                CommandEnumeration.Right,
            });

            roverAgent.SetRoverAgentLocations(new List<Location>()
            {
            });

            roverAgent.ProcessCommands();

            Assert.AreEqual("1 1 N", $"{roverAgent.Location.X} {roverAgent.Location.Y} {(char)roverAgent.Direction.DirectionEnumeration}");
        }

        [TestMethod()]
        public void ProcessCommandsTest4()
        {
            Plateau.UpperRightBoundaries = new Location(5, 5);

            var roverAgent = new RoverAgent(new Location(0, 0), new Direction() { DirectionEnumeration = DirectionEnumeration.West });

            roverAgent.SetCommands(new List<CommandEnumeration>()
            {
                CommandEnumeration.Move,
                CommandEnumeration.Move,
            });

            roverAgent.SetRoverAgentLocations(new List<Location>()
            {
            });

            roverAgent.ProcessCommands();

            Assert.AreEqual("0 0 W", $"{roverAgent.Location.X} {roverAgent.Location.Y} {(char)roverAgent.Direction.DirectionEnumeration}");
        }

        [TestMethod()]
        public void ProcessCommandsTest5()
        {
            Plateau.UpperRightBoundaries = new Location(5, 5);

            var roverAgent = new RoverAgent(new Location(1, 1), new Direction() { DirectionEnumeration = DirectionEnumeration.East });

            roverAgent.SetCommands(new List<CommandEnumeration>()
            {
                CommandEnumeration.Move,
                CommandEnumeration.Move,
                CommandEnumeration.Move,
                CommandEnumeration.Move,
            });

            roverAgent.SetRoverAgentLocations(new List<Location>()
            {
                new Location(2,1)
            });

            roverAgent.ProcessCommands();

            Assert.AreEqual("1 1 E", $"{roverAgent.Location.X} {roverAgent.Location.Y} {(char)roverAgent.Direction.DirectionEnumeration}");
        }
    }
}