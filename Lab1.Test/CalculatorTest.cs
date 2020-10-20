using Lab1;
using NUnit.Framework;


namespace Lab1.Test
{
    public class Tests
    {
        private const string error = "E";

        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Calculator_Number()
        {
            Assert.IsTrue(calculator.Execute("1") == "1");
            Assert.IsTrue(calculator.Execute("2") == "12");
            Assert.IsTrue(calculator.Execute("3") == "123");
            Assert.IsTrue(calculator.Execute("=") == "123");
        }

        [Test]
        public void Calculator_Clear()
        {
            Assert.IsTrue(calculator.Execute("9") == "9");
            Assert.IsTrue(calculator.Execute("8") == "98");
            Assert.IsTrue(calculator.Execute("AC") == "0");
            Assert.IsTrue(calculator.Execute("=") == "0");
        }

        [Test]
        public void Calculator_Null()
        {
            Assert.IsTrue(calculator.Execute(null) == error);
        }

        [Test]
        public void Calculator_WrongSymbol()
        {
            Assert.IsTrue(calculator.Execute("A") == error);
        }

        [Test]
        public void Calculator_EverFirst()
        {
            Assert.IsTrue(calculator.Execute("=") == "0");
        }

        [Test]
        public void Calculator_Addition()
        {
            Assert.IsTrue(calculator.Execute("5") == "5");
            Assert.IsTrue(calculator.Execute("+") == "5");
            Assert.IsTrue(calculator.Execute("4") == "4");
            Assert.IsTrue(calculator.Execute("5") == "45");
            Assert.IsTrue(calculator.Execute("=") == "50");
        }

        [Test]
        public void Calculator_Substraction()
        {
            Assert.IsTrue(calculator.Execute("1") == "1");
            Assert.IsTrue(calculator.Execute("0") == "10");
            Assert.IsTrue(calculator.Execute("-") == "10");
            Assert.IsTrue(calculator.Execute("6") == "6");
            Assert.IsTrue(calculator.Execute("=") == "4");
        }

        [Test]
        public void Calculator_Multiplication()
        {
            Assert.IsTrue(calculator.Execute("2") == "2");
            Assert.IsTrue(calculator.Execute("*") == "2");
            Assert.IsTrue(calculator.Execute("4") == "4");
            Assert.IsTrue(calculator.Execute("*") == "8");
            Assert.IsTrue(calculator.Execute("2") == "2");
            Assert.IsTrue(calculator.Execute("=") == "16");
        }

        [Test]
        public void Calculator_Division()
        {
            Assert.IsTrue(calculator.Execute("1") == "1");
            Assert.IsTrue(calculator.Execute("0") == "10");
            Assert.IsTrue(calculator.Execute("/") == "10");
            Assert.IsTrue(calculator.Execute("2") == "2");
            Assert.IsTrue(calculator.Execute("=") == "5");
        }

        [Test]
        public void Calculator_DivisionByZero()
        {
            Assert.IsTrue(calculator.Execute("1") == "1");
            Assert.IsTrue(calculator.Execute("/") == "1");
            Assert.IsTrue(calculator.Execute("0") == "0");
            Assert.IsTrue(calculator.Execute("=") == error);
        }

        [Test]
        public void Calculator_Sequence()
        {
            Assert.IsTrue(calculator.Execute("3") == "3");
            Assert.IsTrue(calculator.Execute("*") == "3");
            Assert.IsTrue(calculator.Execute("2") == "2");
            Assert.IsTrue(calculator.Execute("+") == "6");
            Assert.IsTrue(calculator.Execute("4") == "4");
            Assert.IsTrue(calculator.Execute("-") == "10");
            Assert.IsTrue(calculator.Execute("1") == "1");
            Assert.IsTrue(calculator.Execute("0") == "10");
            Assert.IsTrue(calculator.Execute("/") == "0");
            Assert.IsTrue(calculator.Execute("5") == "5");
            Assert.IsTrue(calculator.Execute("=") == "0");
        }      

        [Test]
        public void Calculator_WrongSequence()
        {
            Assert.IsTrue(calculator.Execute("1") == "1");
            Assert.IsTrue(calculator.Execute("+") == "1");
            Assert.IsTrue(calculator.Execute("+") == error);
        }
    }
}