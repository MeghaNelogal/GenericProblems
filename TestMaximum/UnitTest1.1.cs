using GenericProblems;
using NUnit.Framework;

namespace TestMaximum
{
    public class Tests
    {
        [Test]
        public void GivenStringInput_WhenTestMax_FirstPosition_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            string actual = max.FindMaxString("Banana", "Peach", "Apple");
            Assert.AreEqual(actual, "Banana");
        }
    }
}