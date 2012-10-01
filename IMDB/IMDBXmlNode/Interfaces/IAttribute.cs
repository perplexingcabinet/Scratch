namespace IMDBXmlNode.Interfaces
{
    public interface IAttribute<out T> : IAttribute
    {
        T Data { get; }
    }

    public interface IAttribute
    {
        string Name { get; }
        string Value { get; }
    }
}