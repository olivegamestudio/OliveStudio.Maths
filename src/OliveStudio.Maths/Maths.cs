using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace OliveStudio;

public static class Maths
{
    /// <summary>
    /// Linearly interpolates between two values based on a percentage.
    /// </summary>
    /// <param name="from">The starting value.</param>
    /// <param name="to">The ending value.</param>
    /// <param name="percent">The interpolation percentage, where 0.0 represents the start value and 1.0 represents the end value.</param>
    /// <returns>The interpolated value.</returns>
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Lerp(float from, float to, float percent)
    {
        // Clamp the lower bound (ensures it's not less than 0.0f)
        float lowerClamped = Math.Max(percent, 0.0f);

        // Clamp the upper bound (ensures it's not greater than 1.0f)
        float clampedPercent = Math.Min(lowerClamped, 1.0f);

        // Standard Lerp calculation
        return from + ((to - from) * clampedPercent);
    }

    /// <summary>
    /// Linearly interpolates between two values based on a percentage.
    /// </summary>
    /// <param name="from">The starting value.</param>
    /// <param name="to">The ending value.</param>
    /// <param name="percent">The interpolation percentage, where 0.0 represents the start value and 1.0 represents the end value.</param>
    /// <returns>The interpolated value.</returns>
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double Lerp(double from, double to, double percent)
        => from + ((to - from) * Math.Min(percent, 1.0D));

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

    /// <summary>
    /// Normalize a vector.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
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

        return (0, 0);
    }

    /// <summary>
    /// Get the distance between two points.
    /// </summary>
    /// <param name="x1"></param>
    /// <param name="y1"></param>
    /// <param name="x2"></param>
    /// <param name="y2"></param>
    /// <returns></returns>
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float GetDistance(float x1, float y1, float x2, float y2)
        => (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    /// <summary>
    /// Degrees to radians.
    /// </summary>
    /// <param name="degrees"></param>
    /// <returns></returns>
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float AsRadians(float degrees)
        => (float)(Math.PI / 180) * degrees;

    /// <summary>
    /// Radians to degrees.
    /// </summary>
    /// <param name="radians"></param>
    /// <returns></returns>
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float AsDegrees(float radians)
        => (float)(180 / Math.PI) * radians;
}