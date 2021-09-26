using MarsRover.Biz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static MarsRover.Biz.Models.Enums;

namespace MarsRover.Biz.Impls
{
    public class RoverAgent
    {
        public Location Location { get; private set; }
        public Direction Direction { get; private set; }
        private IEnumerable<Location> RoverAgentLocations { get; set; }
        private IEnumerable<CommandEnumeration> Commands { get; set; }

        public RoverAgent(Location location, Direction direction)
        {
            Location = location;
            Direction = direction;
        }

        public void SetRoverAgentLocations(IEnumerable<Location> roverAgentLocations)
        {
            RoverAgentLocations = roverAgentLocations;
        }

        public void SetCommands(IEnumerable<CommandEnumeration> commands)
        {
            Commands = commands;
        }

        public void ProcessCommands()
        {
            foreach (var command in Commands)
            {
                ProcessCommand(command);
            }
        }

        private void ProcessCommand(CommandEnumeration command)
        {
            switch (command)
            {
                case CommandEnumeration.Left:
                    Direction.TurnLeft();
                    break;

                case CommandEnumeration.Right:
                    Direction.TurnRight();
                    break;

                case CommandEnumeration.Move:
                    MoveForward();
                    break;

                default:
                    throw new NotSupportedException("Given command not supported");
            }
        }

        private void MoveForward()
        {
            var locationToMove = Location.LocationToMove(Direction.DirectionEnumeration);

            if (locationToMove.CheckBoundaries() && CheckCollision(locationToMove))
            {
                Location = locationToMove;
            }
        }

        private bool CheckCollision(Location location)
        {
            return !RoverAgentLocations.Any(x => x.Equals(location));
        }
    }
}
