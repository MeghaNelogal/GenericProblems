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
        public void Test3()
        {
            FindMaximum max = new FindMaximum();
            int value = max.MaximumElement(2, 14, 44);
            Assert.AreEqual(value, 44);
        }
    }
}
