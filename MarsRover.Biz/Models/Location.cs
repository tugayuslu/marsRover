using System;
using static MarsRover.Biz.Models.Enums;

namespace MarsRover.Biz.Models
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class Location
#pragma warning restore CS0659 
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Location()
        {
                
        }

        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if(obj is Location castedObj)
            {
                return this.X == castedObj.X && this.Y == castedObj.Y;
            }

            return false;
        }

        public Location LocationToMove(DirectionEnumeration directionEnumeration)
        {
            if (directionEnumeration == DirectionEnumeration.North)
            {
                return new Location(X, Y + 1);
            }
            else if (directionEnumeration == DirectionEnumeration.East)
            {
                return new Location(X + 1, Y);
            }
            else if (directionEnumeration == DirectionEnumeration.South)
            {
                return new Location(X, Y - 1);
            }
            else if (directionEnumeration == DirectionEnumeration.West)
            {
                return new Location(X - 1, Y);
            }

            throw new NotSupportedException("Given direction not supported");
        }
    }
}
