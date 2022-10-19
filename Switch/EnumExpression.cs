using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studies.Switch
{
    public static class EnumExpression
    {
        public static Orientation ToOrientation(Direction direction) => direction switch
        {
            Direction.Up => Orientation.North,
            Direction.Right => Orientation.East,
            Direction.Down => Orientation.South,
            Direction.Left => Orientation.West,
            _ => throw new ArgumentOutOfRangeException(nameof(direction), $"Not expected direction value: {direction}")
        };
    }

    public enum Direction
    {
        Up,
        Down,
        Right,
        Left
    }

    public enum Orientation
    {
        North,
        South,
        East,
        West
    }
}