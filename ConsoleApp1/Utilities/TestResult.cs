using System;

namespace ConsoleApp1.Utilities
{
    // Represents a test result object
    public class TestResult
    {
        public string TestName { get; set; }
        public bool IsPassed { get; set; }

        // Overriding Equals for object comparison
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            TestResult other = (TestResult)obj;
            return TestName == other.TestName && IsPassed == other.IsPassed;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TestName, IsPassed);
        }
    }
}
