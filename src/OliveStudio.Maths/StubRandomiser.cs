namespace OliveStudio;

public class StubRandomiser : IRandomiser
{
    int _value;

    public StubRandomiser(int value)
    {
        _value = value;
    }

    public int GetRandom(int minValue, int maxValue) => _value;

    public int GetRandom() => _value;

    public Task<int> GetRandomAsync() => Task.FromResult(_value);
}
