namespace IMDBXmlNode.Attributes
{
    public class StringAttribute : BaseAttribute<string>
    {
        public StringAttribute(string name, string value) : base(name, value){}
        public override string Value { get { return Data; } }
    }
}