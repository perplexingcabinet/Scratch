using System.Collections.Generic;

namespace IMDBXmlNode.Interfaces
{
    public interface ISelector
    {
        IList<IXmlNode> Match(IXmlNode xmlNode);
    }
}