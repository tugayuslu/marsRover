using MarsRover.Biz.Models;

namespace MarsRover.Biz.Impls
{
    public static class Plateau
    {
        public static Location UpperRightBoundaries { get; set; }

        public static bool CheckBoundaries(this Location location)
        {
            return location.X >= 0
                && location.X <= UpperRightBoundaries.X

                && location.Y >= 0
                && location.Y <= UpperRightBoundaries.Y;
        }
    }
}
