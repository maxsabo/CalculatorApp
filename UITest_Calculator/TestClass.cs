using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace UITest_Calculator
{
    public class TestClass
    {
        MainScreenModel _msModel = new MainScreenModel();
        [SetUp]
        public void StartAppBeforeEachTest()
        {
            AppInitializer.StartApp();
        }
        [Test]
        public void MyFirstMobileTest()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnOne()
                .TapOnPlus()
                .TapOnTwo()
                .TapOnEqual();
            Assert.AreEqual("3", _msModel.GetTextFromTextField());
        }
        [Test]
        public void SumTwoFractionalNumbers()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnThree()
                .TapOnComma()
                .TapOnFour()
                .TapOnPlus()
                .TapOnFive()
                .TapOnComma()
                .TapOnSix()
                .TapOnEqual();
            Assert.AreEqual("9", _msModel.GetTextFromTextField());
        }
        [Test]
        public void SumFractionalAndIntegerNumbers()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnSeven()
                .TapOnComma()
                .TapOnEight()
                .TapOnPlus()
                .TapOnNine()
                .TapOnEqual();
            Assert.AreEqual("16,8", _msModel.GetTextFromTextField());
        }
        [Test]
        public void SubTwoIntNumbers()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnSeven()      
                .TapOnMinus()
                .TapOnOne()
                .TapOnEqual();
            Assert.AreEqual("6", _msModel.GetTextFromTextField());
        }
        [Test]
        public void SubTwoFractionalNumbers()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnSeven()
                .TapOnComma()
                .TapOnEight()
                .TapOnMinus()
                .TapOnTwo()
                .TapOnComma()
                .TapOnEight()
                .TapOnEqual();
            Assert.AreEqual("5", _msModel.GetTextFromTextField());
        }
        [Test]
        public void SubThreeDifferentNumbers()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnSeven()
                .TapOnComma()
                .TapOnEight()
                .TapOnMinus()
                .TapOnTwo()
                .TapOnMinus()
                .TapOnSix()
                .TapOnComma()
                .TapOnEight()
                .TapOnEqual();
            Assert.AreEqual("-1", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MultiplyTwoPositiveIntegerNums()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnSeven()
                .TapOnMultiply()
                .TapOnTwo()
                .TapOnEqual();
            Assert.AreEqual("14", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MultiplyNegativeAndPositiveNums()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnMinus()
                .TapOnFive()
                .TapOnMultiply()
                .TapOnTwo()
                .TapOnEqual();
            Assert.AreEqual("-10", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MultiplyByZero()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnZero()
                .TapOnMultiply()
                .TapOnTwo()
                .TapOnEqual();
            Assert.AreEqual("0", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MultiplyFractionalNums()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnNine()
                .TapOnComma()
                .TapOnFive()
                .TapOnMultiply()
                .TapOnTwo()
                .TapOnComma()
                .TapOnFive()
                .TapOnEqual();
            Assert.AreEqual("23,75", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MultiplyFractAndIntNums()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnFour()
                .TapOnComma()
                .TapOnTwo()
                .TapOnMultiply()
                .TapOnTwo()
                .TapOnEqual();
            Assert.AreEqual("8,4", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MultiplyNegativeFracNums()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnMinus()
                .TapOnFour()
                .TapOnComma()
                .TapOnTwo()
                .TapOnMultiply()
                .TapOnMinus()
                .TapOnTwo()
                .TapOnEqual();
            Assert.AreEqual("8,4", _msModel.GetTextFromTextField());
        }
        [Test]
        public void IntegerDivision()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnEight()
                .TapOnDivide()
                .TapOnTwo()
                .TapOnEqual();
            Assert.AreEqual("4", _msModel.GetTextFromTextField());
        }
        [Test]
        public void FractionalDivision()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnFour()
                .TapOnComma()
                .TapOnTwo()
                .TapOnDivide()
                .TapOnTwo()
                .TapOnComma()
                .TapOnFive()
                .TapOnEqual();
            Assert.AreEqual("1,68", _msModel.GetTextFromTextField());
        }
        [Test]
        public void FirstNegativeNumlDivision()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnMinus()
                .TapOnSix()
                .TapOnComma()
                .TapOnTwo()
                .TapOnDivide()
                .TapOnTwo()
                .TapOnComma()
                .TapOnFive()
                .TapOnEqual();
            Assert.AreEqual("-2,48", _msModel.GetTextFromTextField());
        }
        [Test]
        public void DivisionByZero()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnEight()
                .TapOnFour()
                .TapOnTwo()
                .TapOnDivide()
                .TapOnZero()
                .TapOnEqual();
            Assert.AreEqual("Infinity", _msModel.GetTextFromTextField());
        }
        [Test]
        public void ZeroDivision()
        {
            //AppInitializer.App.Repl(); для визова консоли с айдишниками
            _msModel.TapOnZero()
                .TapOnDivide()
                .TapOnEight()
                .TapOnFour()
                .TapOnTwo()
                .TapOnEqual();
            Assert.AreEqual("0", _msModel.GetTextFromTextField());
        }
    }
}
