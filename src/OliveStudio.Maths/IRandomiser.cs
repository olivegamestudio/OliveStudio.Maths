namespace OliveStudio
{
    public interface IRandomiser
    {
        int GetRandom(int minValue, int maxValue);

        int GetRandom();

        Task<int> GetRandomAsync();
    }
}
