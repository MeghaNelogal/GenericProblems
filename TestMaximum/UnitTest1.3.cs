using GenericProblems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class UnitTest2
    {
        [Test]
        public void GivenStringInput_WhenTestMax_ThirdPosition_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            string actual = max.FindMaxString("Banana","Peach", "Apple");
            Assert.AreEqual(actual, "Banana");
        }
    }
}
