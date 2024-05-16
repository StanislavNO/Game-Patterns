namespace Assets.Project4.Task5.Learn
{
    public interface IHealth
    {
        int MaxValue { get; }
        int Value { get; }

        void Add(int value);

        void Reduce(int value);
    }
}
