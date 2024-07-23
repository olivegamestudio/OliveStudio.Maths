using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Utility;

public static class Maths
{
    /// <summary>Return the angle between two points in radians.</summary>
    /// <param name="x1">The first x position.</param>
    /// <param name="y1">The first y position.</param>
    /// <param name="x2">The second x position.</param>
    /// <param name="y2">The second y position.</param>
    /// <returns>Returns the angle between two points in radians.</returns>
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float GetAngleBetweenPointsInRadians(float x1, float y1, float x2, float y2)
        => (float)Math.Atan2(y2 - y1, x2 - x1);

    /// <summary>A function to return a (direction) vector from radians.</summary>
    /// <param name="radians">The radians.</param>
    /// <returns>Returns X/Y vector.</returns>
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static (float x, float y) RadiansToVector(float radians)
    {
        float x = (float)Math.Cos(radians);
        float y = (float)Math.Sin(radians);
        return Normalize(x, y);
    }

    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static (float x, float y) Normalize(float x, float y)
    {
        float length = (float)Math.Sqrt(x * x + y * y);

        if (length > 0)
        {
            float invLength = 1.0f / length;
            return (x * invLength, y * invLength);
        }

        return (0,0);
    }

    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float GetDistance(float x1, float y1, float x2, float y2)
        => (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float AsRadians(float degrees)
        => (float)(Math.PI / 180) * degrees;

    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float AsDegrees(float radians)
        => (float)(180 / Math.PI) * radians;
}
