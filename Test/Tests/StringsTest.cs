using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using OmSULab;
using OmSULab.MenuItems;
using NUnit.Framework;

namespace Tests.OmSULab
{
    [TestFixture]
    public class StringsTest
    {
        [TestCase("test", "Test")]
        public void StringToLower_ValidInputs_Success(string str1, string str2)
        {
            Assert.That(Strings.StringToLower(str2, str1), Is.EqualTo(Strings.StringToLower(str1, str2)));

        }
        [TestCase("test", " test ")]
        public void StringRemovingSpaces_ValidInputs_Success(string str1, string str2)
        {
            Assert.That(Strings.StringRemovingSpaces(str2, str1), Is.EqualTo(Strings.StringRemovingSpaces(str1, str2)));

        }
        [TestCase("test 2", "test  2")]
        public void StringDuplicateSpaces_ValidInputs_Success(string str1, string str2)
        {
            Assert.That(Strings.StringDuplicateSpaces(str2, str1), Is.EqualTo(Strings.StringDuplicateSpaces(str1, str2)));

        }
        [TestCase("test", "tset")]
        public void StringReverse_ValidInputs_Success(string str1, string str2)
        {
            Assert.That(Strings.StringReverse(str1, str2), Is.EqualTo(expected: Strings.StringReverse(str1, str2)));

        }
    }
}
