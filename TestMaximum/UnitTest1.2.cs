using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GenericProblems.FindMaximum;

namespace TestMaximum
{
    public class UnitTest1
    {
        public void GivenStringInput_WhenTestMax_SecondPosition_ShouldReturnMaxNum()
        {
            GenericMaximum<float> max = new GenericMaximum<float>();
            float[] array = { 10.5f, 11.5f, 12.5f, 15.8f, 99.33f };
            float actual = max.FindMaxElement(array);
            Assert.AreEqual(actual, 99.33f);
        }
    }
}
