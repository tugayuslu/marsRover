using MarsRover.Biz.Impls;
using System;

namespace MarsRover.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverAgentManager roverAgentManager = new RoverAgentManager();

            var line = Console.ReadLine();
            InputReader.ReadUpperRightBoundaries(line);

            while (true)
            {
                line = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(line))
                {
                    var roverAgent = InputReader.ReadRoverAgent(line);

                    line = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        roverAgent.SetCommands(InputReader.ReadCommands(line));
                        roverAgentManager.RoverAgents.Add(roverAgent);
                    }
                    else
                    {
                        throw new FormatException("InputData is invalid");
                    }
                }
                else
                {
                    break;
                }
            }

            if(roverAgentManager.RoverAgents.Count == 0)
            {
                throw new FormatException("InputData is invalid");
            }

            var stringWriter = roverAgentManager.Explore();

            Console.WriteLine(stringWriter.ToString());

            Console.ReadKey();
        }
    }
}
