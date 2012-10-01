using System.Diagnostics;
using Examples;
using IMDBXmlNode.Selectors;
using NUnit.Framework;

namespace IMDBXmlNode.Tests.Unit
{
    [TestFixture]
    public class WhenUsingBlobFromOriginalProblem
    {
        private XmlNode _root;

        [SetUp]
        public void SetUpBlob()
        {
            _root = NodeTrees.ExampleFromOriginalProblem;
        }

        [Test]
        public void SelectorExample1()
        {
            var selector = new NamePathSelector(new string[] {"case", "book"});
            var result = selector.Match(_root);
            Assert.That(result.Count, Is.EqualTo(2));
            foreach(var resultNode in result)
            {
                Debug.WriteLine(string.Format("Match: {0}", resultNode.Output()));
            }
        }

        [Test]
        public void SelectorExample2()
        {
            var selector = new NamePathSelector(new string[] {"case", "shelf", "book"});
            var result = selector.Match(_root);
            Assert.That(result.Count, Is.EqualTo(1));
            foreach (var resultNode in result)
            {
                Debug.WriteLine(string.Format("Match: {0}", resultNode.Output()));
            }
        }
    }
}