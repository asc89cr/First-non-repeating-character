using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace First_non_repeating_character
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("a", Program.FirstNonRepeatingLetter("a"));
            Assert.AreEqual("t", Program.FirstNonRepeatingLetter("stress"));
            Assert.AreEqual("e", Program.FirstNonRepeatingLetter("moonmen"));
        }
    }
}
