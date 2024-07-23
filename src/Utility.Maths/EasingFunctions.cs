namespace Utility;

public static class EasingFunctions
{
    public static float Linear(float t)
    {
        return t;
    }

    public static float EaseInQuad(float t)
    {
        return t * t;
    }

    public static float EaseOutQuad(float t)
    {
        return t * (2 - t);
    }

    public static float EaseInOutQuad(float t)
    {
        return t < 0.5 ? 2 * t * t : -1 + (4 - 2 * t) * t;
    }

    public static float EaseInCubic(float t)
    {
        return t * t * t;
    }

    public static float EaseOutCubic(float t)
    {
        float f = (t - 1);
        return f * f * f + 1;
    }

    public static float EaseInOutCubic(float t)
    {
        float f = t < 0.5 ? 2 * t : 2 * (t - 1);
        return (float)(0.5f * f * f * f + (t < 0.5 ? 0 : 0.5));
    }

    public static float EaseInQuart(float t)
    {
        return t * t * t * t;
    }

    public static float EaseOutQuart(float t)
    {
        float f = (t - 1);
        return f * f * f * (1 - t) + 1;
    }

    public static float EaseInOutQuart(float t)
    {
        float f = t < 0.5 ? 2 * t : 2 * (t - 1);
        return (float)(0.5f * f * f * f * f + (t < 0.5 ? 0 : 0.5));
    }

    public static float EaseInQuint(float t)
    {
        return t * t * t * t * t;
    }

    public static float EaseOutQuint(float t)
    {
        float f = (t - 1);
        return f * f * f * f * f + 1;
    }

    public static float EaseInOutQuint(float t)
    {
        float f = t < 0.5 ? 2 * t : 2 * (t - 1);
        return (float)(0.5f * f * f * f * f * f + (t < 0.5 ? 0 : 0.5));
    }
}
