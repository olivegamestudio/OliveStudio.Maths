namespace Utility;

public class StubRandomiser : IRandomiser
{
    int _value;

    public StubRandomiser(int value)
    {
        _value = value;
    }

    public int GetRandom(int minValue, int maxValue)
    {
        return _value;
    }

    public int GetRandom()
    {
        return _value;
    }

    public Task<int> GetRandomAsync()
    {
        return Task.FromResult(_value);
    }
}
