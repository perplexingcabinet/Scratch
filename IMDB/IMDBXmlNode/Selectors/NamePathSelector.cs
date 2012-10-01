using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMDBXmlNode.Interfaces;

namespace IMDBXmlNode.Selectors
{
    public class NamePathSelector : ISelector
    {
        private readonly string[] _namePath;

        public IList<IXmlNode> Match(IXmlNode xmlNode)
        {
            return _namePath.Aggregate(new List<IXmlNode>{xmlNode}, ProcessSubTree);
        }

        private static List<IXmlNode> ProcessSubTree(IEnumerable<IXmlNode> subTreeRoot, string name)
        {
            var result = new List<IXmlNode>();
            Parallel.ForEach(subTreeRoot, item => result.AddRange(item.GetDecendentsWithNameIncludingSelf(name)));
            return result;
        }

        public NamePathSelector(string[] namePath)
        {
            _namePath = namePath;
        }
    }
}