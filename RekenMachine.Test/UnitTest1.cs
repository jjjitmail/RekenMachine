using RekenMachine.Lib;
using NUnit.Framework.Internal;

namespace RekenMachine.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double num1 = 9;
            int _operator = (int)ExpressionOperator.Divide;
            double num2 = 3;
            var result = num1.Calculate(_operator, num2);
            Assert.That(result == 3);

            var result2 = 10.Add(1).Sub(2).Sqrt().Square().Multiply(5).Tanh();
            Assert.That(result2 == 1);

            string expressionBuilder = "";
            string candidate = "3";
            bool isValid = expressionBuilder.Validate(candidate);
            Assert.That(isValid);
            expressionBuilder += candidate;

            candidate = ")";
            isValid = expressionBuilder.Validate(candidate);
            Assert.That(!isValid);
        }
    }
}
