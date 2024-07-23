using System;

namespace Utility;

public class Randomiser : IRandomiser
{
    static readonly Random Random = new();

    public int GetRandom(int minValue, int maxValue)
    {
        return Random.Next(minValue, maxValue);
    }

    public int GetRandom()
    {
        return Random.Next(0, 100);
    }

    public Task<int> GetRandomAsync()
    {
        return Task.FromResult(Random.Next(0, 100));
    }
}
