using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    [TestFixture]
    class FizzBuzzTest
    {
        [TestCase]
        public void FizzBuzz()
        {
            Kata test = new Kata();
            Assert.AreEqual("fizz", test.FizzBuzz(3));
            Assert.AreEqual("buzz", test.FizzBuzz(5));
            Assert.AreEqual("fizzbuzz", test.FizzBuzz(15));
            Assert.AreEqual("1", test.FizzBuzz(1));
            Assert.AreEqual("2", test.FizzBuzz(2));
        }
    }
}
