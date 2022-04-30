using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GenericProblems.FindMaximum;

namespace TestMaximum
{
    public class UnitTest2
    {
        public void GivenFloatInput_WhenTestMax_ThirdPosition_ShouldReturnMaxNum()
        {
            GenericMaximum<string> max = new GenericMaximum<string>();
            string[] array = { "Peach", "Apple", "Banana", "Mango", "PineApple", "Graps" };
            string actual = max.FindMaxElement(array);
            Assert.AreEqual(actual, "PineApple");
        }
    }
}

