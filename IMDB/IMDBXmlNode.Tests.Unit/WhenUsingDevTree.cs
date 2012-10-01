using System.Diagnostics;
using Examples;
using IMDBXmlNode.Selectors;
using NUnit.Framework;

namespace IMDBXmlNode.Tests.Unit
{
    [TestFixture]
    public class WhenUsingDevTree
    {
        private XmlNode _root;

        [SetUp]
        public void SetUpBlob()
        {
            _root = NodeTrees.DevTree;
        }

        [Test]
        public void SelectorExample1()
        {
            var selector = new NamePathSelector(new[] { "animal" });
            var result = selector.Match(_root);
            Assert.That(result.Count, Is.EqualTo(2));
            foreach (var resultNode in result)
            {
                Debug.WriteLine(string.Format("Match: {0}", resultNode.Output()));
            }
        }

        [Test]
        public void SelectorExample2()
        {
            var selector = new NamePathSelector(new string[] { "animal", "product" });
            var result = selector.Match(_root);
            Assert.That(result.Count, Is.EqualTo(2));
            foreach (var resultNode in result)
            {
                Debug.WriteLine(string.Format("Match: {0}", resultNode.Output()));
            }
        }
    }
}