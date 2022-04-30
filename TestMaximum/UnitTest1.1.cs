using GenericProblems;
using NUnit.Framework;

namespace TestMaximum
{
    public class Tests
    {
        [Test]
        public void GivenFloatInput_WhenTestMax_FirstPosition_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            float actual = max.FindMaxFloat(60.5f, 35.6f, 15.7f);
            Assert.AreEqual(actual, 60.5f);
        }
    }
}