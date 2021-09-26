using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MarsRover.Biz.Impls
{
    public class RoverAgentManager
    {
        public List<RoverAgent> RoverAgents { get; set; }

        public RoverAgentManager()
        {
            RoverAgents = new List<RoverAgent>();
        }

        public StringWriter Explore()
        {
            foreach (var roverAgent in RoverAgents)
            {
                var otherRoverAgentLocations = RoverAgents.Where(x => !x.Location.Equals(roverAgent.Location)).Select(y => y.Location);
                roverAgent.SetRoverAgentLocations(otherRoverAgentLocations);

                roverAgent.ProcessCommands();
            }

            var stringWriter = new StringWriter();

            RoverAgents.ForEach(agent => stringWriter.WriteLine($"{agent.Location.X} {agent.Location.Y} {(char)agent.Direction.DirectionEnumeration}"));

            return stringWriter;
        }
    }
}
