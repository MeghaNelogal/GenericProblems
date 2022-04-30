using GenericProblems;
using NUnit.Framework;

namespace TestMaximum
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            FindMaximum max = new FindMaximum();
            int value = max.MaximumElement(44, 2, 14);
            Assert.AreEqual(value, 44);

        }
    }
}