using System;
using IMDBXmlNode.Selectors;

namespace Examples
{
    public static class ConsoleEntry
    {
        public static void Main(string[] args)
        {
            var root = NodeTrees.ExampleFromOriginalProblem;
            var selector = new NamePathSelector(new string[] { "case", "book" });
            var result = selector.Match(root);
            foreach (var resultNode in result)
            {
                Console.WriteLine(String.Format("Match: {0}", resultNode.Output()));
            }

            selector = new NamePathSelector(new string[] { "case", "shelf", "book" });
            result = selector.Match(root);
            foreach (var resultNode in result)
            {
                Console.WriteLine(String.Format("Match: {0}", resultNode.Output()));
            }
        }
    }
}