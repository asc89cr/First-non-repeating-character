// <copyright file="TestTest.cs">Copyright ©  2018</copyright>

using System;
using First_non_repeating_character;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace First_non_repeating_character.Tests
{
    [TestClass]
    [PexClass(typeof(Test))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TestTest
    {

        [PexMethod]
        [PexAllowedException(typeof(InvalidProgramException))]
        public void BasicTest([PexAssumeUnderTest]Test target)
        {
            target.BasicTest();
            // TODO: add assertions to method TestTest.BasicTest(Test)
        }
    }
}
