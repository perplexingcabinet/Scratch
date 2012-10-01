using System.Globalization;

namespace IMDBXmlNode.Attributes
{
    public class IntAttribute : BaseAttribute<int>
    {
        public IntAttribute(string name, int data) : base(name, data){}

        public override string Value
        {
            get { return Data.ToString(CultureInfo.InvariantCulture); }
        }
    }
}