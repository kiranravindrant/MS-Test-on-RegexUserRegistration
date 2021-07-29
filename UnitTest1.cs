using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexUserRegistration;


namespace RegexTestProject
{
    [TestClass]
    public class UnitTest1
    {
       


        [TestMethod]
        public void TestNameValidation()
        {
           bool result = Program.NameValidation("Kiran");
            Assert.AreEqual(result, true);
        }







    }
}
