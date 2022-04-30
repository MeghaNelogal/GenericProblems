using GenericProblems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    internal class UnitTest1
    {
        [Test]
        public void Test2()
        {
            FindMaximum max = new FindMaximum();
            int value = max.MaximumElement(2, 44, 14);
            Assert.AreEqual(value, 44);
        }
    }
}
