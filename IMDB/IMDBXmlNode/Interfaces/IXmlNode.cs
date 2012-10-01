using System.Collections.Generic;

namespace IMDBXmlNode.Interfaces
{
    public interface IXmlNode
    {
        string Name { get; }
        IList<IAttribute> Attributes { get; }
        IList<IXmlNode> Children { get; }
        IXmlNode Parent { get; }

        void AddAttribute(IAttribute attribute);
        void AddChild(IXmlNode child);
        void SetParent(IXmlNode parent);
        IList<IXmlNode> GetDecendentsWithNameIncludingSelf(string name); 
        string Output();
    }
}