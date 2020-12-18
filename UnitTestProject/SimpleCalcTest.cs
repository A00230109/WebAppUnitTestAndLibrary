using ClassLibraryCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{

    [TestClass]
    public class SimpleCalcTest
    {
        [TestMethod]
        public void AddTwoPositiveNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 2.4;
            double b = 3.9;
            double answer = a + b;    
            double methodReturn = calc.AddNumbers(a, b);
            Assert.AreEqual(answer, methodReturn);
        }

        [TestMethod]
        public void AddFirstPositiveNumberWithSecondNegativeNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 2.1;
            double b = -3.9;

            double answer = a + b;
            double methodReturn = calc.AddNumbers(a, b);
            
            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void AddTwoNegativeNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = -2.0;
            double b = -3.4;

            double answer = a + b;
            double methodReturn = calc.AddNumbers(a, b);
            
            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void AddFirstNegativeNumberWithSecondPositiveNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = -2.0;
            double b = 3.4;
            double answer = a + b;
            double methodReturn = calc.AddNumbers(a, b);
            
            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void AddZeroWithSecondPositiveNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 0.0;
            double b = 3.4;
            double answer = a + b;
            double methodReturn = calc.AddNumbers(a, b);
            
            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void AddZeroWithSecondNegativeNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 0.0;
            double b = -3.4;
            double answer = a + b;
            double methodReturn = calc.AddNumbers(a, b);
            
            Assert.AreEqual(answer, methodReturn);

        }


        [TestMethod]
        public void AddTwoIntegerPositiveNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            int a = 4;
            int b = 5;
            int answer = a + b;
            double methodReturn = calc.AddNumbers(a, b);
            
            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void AddTwoIntegerNegativeNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            int a = -4;
            int b = -5;
            int answer = a + b;
            double methodReturn = calc.AddNumbers(a, b);
            
            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void AddFirstIntegerNumberWithSecondDoubleNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            int a = 4;
            double b = 5.8;
            double answer = a + b;
            double methodReturn = calc.AddNumbers(a, b);
            
            Assert.AreEqual(answer, methodReturn);
        }

        [TestMethod]
        public void AddFirstDoubleNumberWithSecondIntegerNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 4.9;
            int b = 5;
            double answer = a + b;
            double methodReturn = calc.AddNumbers(a, b);
            
            Assert.AreEqual(answer, methodReturn);
        }


        [TestMethod]
        public void SubstractTwoPositiveNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 8.0;
            double b = 4.4;
            double answer = a - b;
            double methodReturn = calc.SubstractNumbers(a, b);
            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void SubstractFirstPositiveNumberFromSecondNegativeNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 2.1;
            double b = -3.9;

            double answer = a - b;
            double methodReturn = calc.SubstractNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void SubstractTwoNegativeNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = -2.0;
            double b = -3.4;

            double answer = a - b;
            double methodReturn = calc.SubstractNumbers(a, b);
            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void SubstractFirstNegativeNumberFromSecondPositiveNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = -2.0;
            double b = 3.4;
            double answer = a - b;
            double methodReturn = calc.SubstractNumbers(a, b);
            
            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void SubstractZeroFromSecondPositiveNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 0.0;
            double b = 3.4;
            double answer = a - b;
            double methodReturn = calc.SubstractNumbers(a, b);
            
            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void SubstractZeroFromSecondNegativeNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 0.0;
            double b = -3.4;
            double answer = a - b;
            double methodReturn = calc.SubstractNumbers(a, b);
            
            Assert.AreEqual(answer, methodReturn);

        }


        [TestMethod]
        public void SubstractTwoIntegerPositiveNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            int a = 4;
            int b = 5;
            int answer = a - b;
            double methodReturn = calc.SubstractNumbers(a, b);
            
            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void SubstractTwoIntegerNegativeNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            int a = -4;
            int b = -5;
            int answer = a - b;
            double methodReturn = calc.SubstractNumbers(a, b);
            
            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void SubstractFirstIntegerNumberFromSecondDoubleNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            int a = 4;
            double b = 5.8;
            double answer = a - b;
            double methodReturn = calc.SubstractNumbers(a, b);
            
            Assert.AreEqual(answer, methodReturn);
        }

        [TestMethod]
        public void SubstractFirstDoubleNumberFromSecondIntegerNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 4.9;
            int b = 5;
            double answer = a - b;
            double methodReturn = calc.SubstractNumbers(a, b);   
            Assert.AreEqual(answer, methodReturn);
        }



        [TestMethod]
        public void MultiplyTwoPositiveNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 2.4;
            double b = 3.9;
            double answer = a * b;
            double methodReturn = calc.MultiplyNumbers(a, b);
            Assert.AreEqual(answer, methodReturn);
        }

        [TestMethod]
        public void MultiplyFirstPositiveNumberWithSecondNegativeNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 2.1;
            double b = -3.9;

            double answer = a * b;
            double methodReturn = calc.MultiplyNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void MultiplyTwoNegativeNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = -2.0;
            double b = -3.4;

            double answer = a * b;
            double methodReturn = calc.MultiplyNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void MultiplyFirstNegativeNumberWithSecondPositiveNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = -2.0;
            double b = 3.4;
            double answer = a * b;
            double methodReturn = calc.MultiplyNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void MultiplyZeroWithSecondPositiveNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 0.0;
            double b = 3.4;
            double answer = a * b;
            double methodReturn = calc.MultiplyNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void MultiplyZeroWithSecondNegativeNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 0.0;
            double b = -3.4;
            double answer = a * b;
            double methodReturn = calc.MultiplyNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);

        }


        [TestMethod]
        public void MultiplyTwoIntegerPositiveNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            int a = 4;
            int b = 5;
            int answer = a * b;
            double methodReturn = calc.MultiplyNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void MultiplyTwoIntegerNegativeNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            int a = -4;
            int b = -5;
            int answer = a * b;
            double methodReturn = calc.MultiplyNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void MultiplyFirstIntegerNumberWithSecondDoubleNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            int a = 4;
            double b = 5.8;
            double answer = a * b;
            double methodReturn = calc.MultiplyNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);
        }

        [TestMethod]
        public void MultiplyFirstDoubleNumberWithSecondIntegerNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 4.9;
            int b = 5;
            double answer = a * b;
            double methodReturn = calc.MultiplyNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);
        }





        [TestMethod]
        public void DivideTwoPositiveNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 2.4;
            double b = 3.9;
            double answer = a / b;
            double methodReturn = calc.DivideNumbers(a, b);
            Assert.AreEqual(answer, methodReturn);
        }

        [TestMethod]
        public void DivideFirstPositiveNumberBySecondNegativeNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 2.1;
            double b = -3.9;

            double answer = a / b;
            double methodReturn = calc.DivideNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void DivideTwoNegativeNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = -2.0;
            double b = -3.4;

            double answer = a / b;
            double methodReturn = calc.DivideNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void DivideFirstNegativeNumberBySecondPositiveNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = -2.0;
            double b = 3.4;
            double answer = a / b;
            double methodReturn = calc.DivideNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void DivideZeroBySecondPositiveNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 0.0;
            double b = 3.4;
            double answer = a / b;
            double methodReturn = calc.DivideNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void DivideZeroBySecondNegativeNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 0.0;
            double b = -3.4;
            double answer = a / b;
            double methodReturn = calc.DivideNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);

        }


        [TestMethod]
        public void DivideTwoIntegerPositiveNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            int a = 4;
            int b = 5;
            double answer = a / b;
            double methodReturn = calc.DivideNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void DivideTwoIntegerNegativeNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            int a = -4;
            int b = -5;
            double answer = a / b;
            double methodReturn = calc.DivideNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);

        }

        [TestMethod]
        public void DivideFirstIntegerNumberBySecondDoubleNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            int a = 4;
            double b = 5.8;
            double answer = a / b;
            double methodReturn = calc.DivideNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);
        }

        [TestMethod]
        public void DivideFirstDoubleNumberBySecondIntegerNumber()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 4.9;
            int b = 5;
            double answer = a / b;
            double methodReturn = calc.DivideNumbers(a, b);

            Assert.AreEqual(answer, methodReturn);
        }

        [TestMethod]
        public void OperatorSwitchAddTwoPositiveNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 2.4;
            double b = 3.9;
            double answer = a + b;
            double methodReturn = calc.OpertorSwitch("add", a, b);
            Assert.AreEqual(answer, methodReturn);
        }

        [TestMethod]
        public void OperatorSwitchSubstractTwoPositiveNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 2.4;
            double b = 3.9;
            double answer = a - b;
            double methodReturn = calc.OpertorSwitch("substract", a, b);
            Assert.AreEqual(answer, methodReturn);
        }

        [TestMethod]
        public void OperatorSwitchMultiplyTwoPositiveNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 2.4;
            double b = 3.9;
            double answer = a * b;
            double methodReturn = calc.OpertorSwitch("multiply", a, b);
            Assert.AreEqual(answer, methodReturn);
        }

        [TestMethod]
        public void OperatorSwitchDivideTwoPositiveNumbers()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 2.4;
            double b = 3.9;
            double answer = a / b;
            double methodReturn = calc.OpertorSwitch("divide", a, b);
            Assert.AreEqual(answer, methodReturn);
        }
        [TestMethod]
        public void OperatorSwitchDivideNumberByZero()
        {
            SimpleCalc calc = new SimpleCalc();
            double a = 2.4;
            double b = 0.0;
            double answer = a / b;
            double methodReturn = calc.OpertorSwitch("divide", a, b);
            Assert.AreEqual(answer, methodReturn);
        }

    }



}
