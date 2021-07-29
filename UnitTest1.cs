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

        [TestMethod]

        public void TestEmailValidation()
        {
            bool result = Program.EmailValidation("kiranravindrant@gmail.com");
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestMobileNumValidation()
        {
            bool result = Program.MobileNumValidation("91 9847256412");
            Assert.AreEqual(result, true);
        }

        [TestMethod]

        public void TestPasswordValidation()
        {
            bool result = Program.PassValidation("K123@sxl");
            Assert.AreEqual(result, true);
        }












    }
}
