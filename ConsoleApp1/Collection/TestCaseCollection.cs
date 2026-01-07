using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1.Collection
{
    // Custom collection implementing IEnumerable
    public class TestCaseCollection : IEnumerable<string>
    {
        private readonly List<string> _testCases = new List<string>();

        public void Add(string testCase)
        {
            _testCases.Add(testCase);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return _testCases.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
