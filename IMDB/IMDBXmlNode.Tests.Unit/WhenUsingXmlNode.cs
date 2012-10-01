using NUnit.Framework;

namespace IMDBXmlNode.Tests.Unit
{
    [TestFixture]
    public class WhenUsingXmlNode
    {
        private XmlNode _objectUnderTest;

        [Test]
        public void CanConstruct()
        {
            _objectUnderTest = new XmlNode("Undefined");
            Assert.That(_objectUnderTest, Is.Not.Null);
        }
    }
}
