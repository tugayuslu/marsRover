using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MarsRover.Biz.Models;
using static MarsRover.Biz.Models.Enums;

namespace MarsRover.Biz.Impls.Tests
{
    [TestClass()]
    public class RoverAgentManagerTests
    {
        [TestMethod()]
        public void ExploreTest()
        {
            Plateau.UpperRightBoundaries = new Location(5, 5);

            var roverAgentManager = new RoverAgentManager();

            roverAgentManager.RoverAgents.Add(new RoverAgent(new Location(1, 2), new Direction() { DirectionEnumeration = DirectionEnumeration.North }));
            roverAgentManager.RoverAgents[0].SetCommands(new List<CommandEnumeration>()
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


            roverAgentManager.RoverAgents.Add(new RoverAgent(new Location(3, 3), new Direction() { DirectionEnumeration = DirectionEnumeration.East }));
            roverAgentManager.RoverAgents[1].SetCommands(new List<CommandEnumeration>()
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

            var result = roverAgentManager.Explore();

            Assert.AreEqual("1 3 N\r\n5 1 E\r\n", result.ToString());
        }
    }
}