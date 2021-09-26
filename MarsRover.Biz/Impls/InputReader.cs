using MarsRover.Biz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using static MarsRover.Biz.Models.Enums;

namespace MarsRover.Biz.Impls
{
    public static class InputReader
    {
        public static void ReadUpperRightBoundaries(string line)
        {
            var splittedLine = line.Trim().Split(' ');
            int x, y;

            if (splittedLine.Count() == 2 && int.TryParse(splittedLine[0], out x) && int.TryParse(splittedLine[1], out y) && x > 0 && y > 0)
            {
                Plateau.UpperRightBoundaries = new Location(x, y);
            }
            else
            {
                throw new FormatException("UpperRightBoundaries line is invalid");
            }
        }

        public static RoverAgent ReadRoverAgent(string line)
        {
            var splittedLine = line.Trim().Split(' ');
            int x, y;

            if (splittedLine.Count() == 3 && int.TryParse(splittedLine[0], out x) && int.TryParse(splittedLine[1], out y))
            {
                var location = new Location(x, y);
                var directionEnumeration = (DirectionEnumeration)Convert.ToChar(splittedLine[2].ToUpper());

                if (location.CheckBoundaries() && Enum.IsDefined(typeof(DirectionEnumeration), directionEnumeration))
                {
                    return new RoverAgent(location, new Direction() { DirectionEnumeration = directionEnumeration });
                }
            }

            throw new FormatException("RoverAgent line is invalid");
        }

        public static IEnumerable<CommandEnumeration> ReadCommands(string line)
        {
            List<CommandEnumeration> commands = new List<CommandEnumeration>();

            line = line.Trim().ToUpper();

            foreach (var character in line)
            {
                var command = (CommandEnumeration)character;

                if (Enum.IsDefined(typeof(CommandEnumeration), command))
                {
                    commands.Add(command);
                }
                else
                {
                    throw new FormatException("Commands line is invalid");
                }
            }

            return commands;
        }
    }
}
