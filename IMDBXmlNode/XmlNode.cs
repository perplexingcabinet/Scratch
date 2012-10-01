using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IMDBXmlNode.Interfaces;

namespace IMDBXmlNode
{
    public class XmlNode : IXmlNode
    {
        public string Name { get; private set; }
        public IList<IAttribute> Attributes { get; private set; }
        public IList<IXmlNode> Children { get; private set; }
        public IXmlNode Parent { get; private set; }
        public void AddAttribute(IAttribute attribute)
        {
            Attributes.Add(attribute);
        }

        public void AddChild(IXmlNode child)
        {
            if(child.Parent != this) child.SetParent(this);
            if(!Children.Contains(child)) Children.Add(child);
        }

        public void SetParent(IXmlNode parent)
        {
            Parent = parent;
        }

        public IList<IXmlNode> GetDecendentsWithNameIncludingSelf(string name)
        {
            var result = new List<IXmlNode>();
            if (Name == name) result.Add(this);
            Parallel.ForEach(Children, child => result.AddRange(child.GetDecendentsWithNameIncludingSelf(name)));
            return result;
        }

        public XmlNode(string name)
        {
            Name = name;
            Attributes = new List<IAttribute>();
            Children = new List<IXmlNode>();
            Parent = null;
        }

        public string Output()
        {
            var result = new StringBuilder();
            result.Append(string.Format("<{0}", Name));
            foreach (var attribute in Attributes)
            {
                result.Append(string.Format(" {0}={1}", attribute.Name, attribute.Value));
            }
            if (Children.Count > 0)
            {
                result.Append(">");
                foreach (var child in Children)
                {
                    result.Append(child.Output());
                }
                result.Append(string.Format("</{0}>", Name));
            }
            else
            {
                result.Append(Attributes.Count > 0 ? " />" : "/>");
            }
            return result.ToString();
        }
    }
}
