using DevelopmentAndBuildTools;

namespace MessageTests
{
    [TestClass]
    public class InputTests
    {
        [TestMethod]
        public void CheckOfTheEnteredChar()
        {
            Assert.AreEqual(3, Message.GetString("Hello"));
        }
        
        [TestMethod]
        public void CheckOfTheEnteredEmptyChar() 
        {
            Assert.AreEqual(0, Message.GetString(""));
        }

        [TestMethod]
        public void CheckOfTheRecurringChar() 
        {
            Assert.AreEqual(1, Message.GetString("dd"));
        }

        [TestMethod]
        public void CheckOfTheNonRecurringChar()
        {
            Assert.AreEqual(4, Message.GetString("yes!"));
        }

        [TestMethod]
        public void CheckOfTheOnlyPunctuationChar()
        {
            Assert.AreEqual(3, Message.GetString("*_*"));
        }
    }
}