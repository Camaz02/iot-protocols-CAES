namespace NetCoreClient.ValueObjects
{
    internal class Fuel
    {
        public int Value { get; private set; }

        public Fuel(int value)
        {
            this.Value = value;
        }
    }
}
