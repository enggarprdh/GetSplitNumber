using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GetSplitNumber;


namespace GetSplitNumberTest
{
    [TestClass]
    public class WordsTest
    {
        [TestMethod]
        public void LastNumber()
        {
            string param = "item code1";
            var word = new Words(param);
            string expectedValue = "1";
            Assert.AreEqual(expectedValue, word.GetLastNumberOnString());
        }

        [TestMethod]
        public void MidLastNumber()
        {
            string param = "item1 code1";
            var word = new Words(param);
            string expectedValue = "1";
            Assert.AreEqual(expectedValue, word.GetLastNumberOnString(), $"{word.GetLastNumberOnString()} is not match with {expectedValue}");
        }
        
        [TestMethod]
        public void StartMidLastNumber()
        {
            string param = "1item1 code1";
            var word = new Words(param);
            string expectedValue = "1";
            Assert.AreEqual(expectedValue, word.GetLastNumberOnString(), $"{word.GetLastNumberOnString()} is not match with {expectedValue}");
        }

        [TestMethod]
        public void RandomString()
        {
            string param = "1item1 code112";
            var word = new Words(param);
            string expectedValue = "112";
            Assert.AreEqual(expectedValue, word.GetLastNumberOnString(), $"{word.GetLastNumberOnString()} is not match with {expectedValue}");
        }

        [TestMethod]
        public void NumberOnCurrency()
        {
            string param = "1,3508.50 USD";
            var word = new Words(param);
            string expectedValue = "1,3508.50";
            Assert.AreEqual(expectedValue, word.GetNumberOnCurrency(), $"{word.GetNumberOnCurrency()} is not match with {expectedValue}");
        }


    }
}
