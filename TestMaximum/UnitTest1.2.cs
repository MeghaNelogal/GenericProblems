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
        public void GivenStringInput_WhenTestMax_SecondPosition_ShouldReturnMaxNum()
        {
            FindMaximum max = new FindMaximum();
            string actual = max.FindMaxString("Peach","Banana","Apple");
            Assert.AreEqual(actual, "Banana");
        }
    }
}
