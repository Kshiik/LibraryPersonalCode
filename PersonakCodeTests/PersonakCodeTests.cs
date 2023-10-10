using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibraryPersonalCode;

namespace PersonakCodeTests
{
    [TestClass]
    public class PersonakCodeTests
    {
        /// <summary>
        /// пустая строка
        /// </summary>
        [TestMethod]
        public void CheckPersonakCode_StringIsEmpty_ResultFalse()
        {
            string textString = "";

            bool result = new PersonalCode().CheckPersonakCode(textString);

            Assert.IsFalse(result);
        }
        /// <summary>
        /// мало цифр
        /// </summary>
        [TestMethod]
        public void CheckPersonakCode_StringFewNumb_ResultFalse()
        {
            string textString = "333";

            bool result = new PersonalCode().CheckPersonakCode(textString);

            Assert.IsFalse(result);
        }
        /// <summary>
        /// много цифр
        /// </summary>
        [TestMethod]
        public void CheckPersonakCode_StringMuchNumb_ResultFalse()
        {
            string textString = "999999999999999999999";

            bool result = new PersonalCode().CheckPersonakCode(textString);

            Assert.IsFalse(result);
        }
        /// <summary>
         /// буквы
         /// </summary>
        [TestMethod]
        public void CheckPersonakCode_String_ResultFalse()
        {
            string textString = "sdfg3478254";

            bool result = new PersonalCode().CheckPersonakCode(textString);

            Assert.IsFalse(result);
        }
        /// <summary>
        /// снилс с тире
        /// </summary>
        [TestMethod]
        public void CheckPersonakCode_PersonalCodeWhithTire_ResultTrue()
        {
            string textString = "112-233-445 95";

            bool result = new PersonalCode().CheckPersonakCode(textString);

            Assert.IsTrue(result);
        }
        /// <summary>
        /// корректный снилс1
        /// </summary>
        [TestMethod]
        public void CheckPersonakCode_CorrectPersonalCode1_ResultTrue()
        {
            string textString = "15795916329";

            bool result = new PersonalCode().CheckPersonakCode(textString);

            Assert.IsTrue(result);
        }
        /// <summary>
        /// корректный снилс2
        /// </summary>
        [TestMethod]
        public void CheckPersonakCode_CorrectPersonalCode2_ResultTrue()
        {
            string textString = "20401330880";

            bool result = new PersonalCode().CheckPersonakCode(textString);

            Assert.IsTrue(result);
        }
    }
}
