using GenericProblems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class UnitTest1
    {
        [Test]
        public void GivenFloatInput_WhenTestMax_SecondPosition_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            float actual = max.FindMaxFloat(35.6f, 60.5f, 15.7f);
            Assert.AreEqual(actual, 60.5f);

        }
    }
}
