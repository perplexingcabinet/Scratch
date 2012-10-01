using IMDBXmlNode.Interfaces;

namespace IMDBXmlNode.Attributes
{
    public abstract class BaseAttribute<T> : IAttribute<T>
    {
        protected BaseAttribute(string name, T data)
        {
            Name = name;
            Data = data;
        }

        public string Name { get; private set; }
        public abstract string Value { get; }
        public T Data { get; private set; }
    }
}