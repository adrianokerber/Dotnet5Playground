namespace TestProject.Models
{
    public readonly struct ValueObjectFromStruct
    {
        public readonly string Value { get; init; }

        public ValueObjectFromStruct(string value) => Value = value;
    }
}
