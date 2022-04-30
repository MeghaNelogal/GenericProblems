using GenericProblems;
using NUnit.Framework;
using static GenericProblems.FindMaximum;

namespace TestMaximums
{
    public class Tests
    {
        [Test]
        public void GivenIntInput_WhenTestMax_ShouldReturnMaxNum()
        {
            GenericMaximum<int> max = new GenericMaximum<int>();
            int[] array = { 1, 2, 3, 4, 6, 7, 10 };
            int actual = max.FindMaxElement(array);
            Assert.AreEqual(actual, 10);

        }
    }
}