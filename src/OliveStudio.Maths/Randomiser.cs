namespace OliveStudio;

public class Randomiser : IRandomiser
{
    static readonly Random Random = new();

    public int GetRandom(int minValue, int maxValue) => Random.Next(minValue, maxValue);

    public int GetRandom() => Random.Next(0, 100);

    public Task<int> GetRandomAsync() => Task.FromResult(Random.Next(0, 100));
}
