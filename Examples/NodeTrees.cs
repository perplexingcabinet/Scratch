using IMDBXmlNode;
using IMDBXmlNode.Attributes;

namespace Examples
{
    public static class NodeTrees
    {

        public static XmlNode ExampleFromOriginalProblem
        {
            get
            {
                var root = new XmlNode("library");

                var case1 = new XmlNode("case");
                case1.AddAttribute(new StringAttribute("size", "large"));

                var book1 = new XmlNode("book");
                book1.AddAttribute(new IntAttribute("id", 7));
                case1.AddChild(book1);

                var shelf1 = new XmlNode("shelf");
                shelf1.AddAttribute(new IntAttribute("row", 1));
                var book2 = new XmlNode("book");
                book2.AddAttribute(new IntAttribute("id", 5));
                shelf1.AddChild(book2);
                case1.AddChild(shelf1);

                var shelf2 = new XmlNode("shelf");
                shelf2.AddAttribute(new IntAttribute("row", 2));
                case1.AddChild(shelf2);

                root.AddChild(case1);

                var book3 = new XmlNode("book");
                book3.AddAttribute(new IntAttribute("id", 1));

                var case2 = new XmlNode("case");
                case2.AddAttribute(new StringAttribute("size", "tiny"));
                case2.AddAttribute(new StringAttribute("visible", "nope"));

                book3.AddChild(case2);
                root.AddChild(book3);
                return root;
            }
        }

        public static XmlNode DevTree
        {
            get
            {
                var root = new XmlNode("farm");

                var animal1 = new XmlNode("animal");
                animal1.AddAttribute(new StringAttribute("species", "goat"));
                animal1.AddAttribute(new StringAttribute("size", "medium"));
                animal1.AddAttribute(new IntAttribute("id", 1));

                var product1 = new XmlNode("product");
                product1.AddAttribute(new StringAttribute("name", "cheese"));
                product1.AddAttribute(new IntAttribute("amount", 0));
                animal1.AddChild(product1);

                var animal2 = new XmlNode("animal");
                animal2.AddAttribute(new StringAttribute("species", "sheep"));
                animal2.AddAttribute(new StringAttribute("size", "medium"));
                animal2.AddAttribute(new IntAttribute("id", 2));

                var product2 = new XmlNode("product");
                product2.AddAttribute(new StringAttribute("name", "wool"));
                product2.AddAttribute(new IntAttribute("amount", 10));
                animal2.AddChild(product2);

                var child1 = new XmlNode("child");
                child1.AddAttribute(new StringAttribute("description", "lamb"));
                child1.AddAttribute(new StringAttribute("birthdate", "11/01/01"));
                animal2.AddChild(child1);

                root.AddChild(animal1);
                root.AddChild(animal2);

                return root;
            }
        }
    }
}
