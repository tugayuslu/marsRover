using System;
using static MarsRover.Biz.Models.Enums;

namespace MarsRover.Biz.Impls
{
    public class Direction
    {
        public DirectionEnumeration DirectionEnumeration { get; set; }

        public void TurnLeft()
        {
            switch (DirectionEnumeration)
            {
                case DirectionEnumeration.North:
                    DirectionEnumeration = DirectionEnumeration.West;
                    break;

                case DirectionEnumeration.East:
                    DirectionEnumeration = DirectionEnumeration.North;
                    break;

                case DirectionEnumeration.South:
                    DirectionEnumeration = DirectionEnumeration.East;
                    break;

                case DirectionEnumeration.West:
                    DirectionEnumeration = DirectionEnumeration.South;
                    break;

                default:
                    throw new NotSupportedException("Given direction not supported");
            }
        }

        public void TurnRight()
        {
            switch (DirectionEnumeration)
            {
                case DirectionEnumeration.North:
                    DirectionEnumeration = DirectionEnumeration.East;
                    break;

                case DirectionEnumeration.East:
                    DirectionEnumeration = DirectionEnumeration.South;
                    break;

                case DirectionEnumeration.South:
                    DirectionEnumeration = DirectionEnumeration.West;
                    break;

                case DirectionEnumeration.West:
                    DirectionEnumeration = DirectionEnumeration.North;
                    break;

                default:
                    throw new NotSupportedException("Given direction not supported");
            }
        }
    }
}
