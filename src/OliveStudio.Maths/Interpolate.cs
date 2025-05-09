using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace OliveStudio;

public static class Interpolate
{
    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Lerp(float start, float end, float percent)
        => start + (end - start) * percent;

    [DebuggerStepThrough]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float EasingInterpolate(float start, float end, float percent, EasingFunction easing)
        => start + ((end - start) * easing.Invoke(percent));
}
