using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekenMachine.Lib
{
    public static class CalculatorExtension
    {
        private static string _bracketOpen = PriorityOperator.BracketOpen.GetAttributeValue();
        private static string _bracketClose = PriorityOperator.BracketClose.GetAttributeValue();

        public static double Calculate(string expression)
        {
            double result = 0;
            bool isValid = expression.Validate();

            // extract the expression....

            return result;
        }
        public static bool Validate(this string expression, string candidate = "")
        {
            if (candidate == _bracketClose && !expression.Contains(_bracketOpen))
                return false;
            //More validation...
            return true;
        }
        public static double Calculate(this double num1, int Operator, double num2 = 0 )
        {
            double result = 0;
            ExpressionOperator expOperator = (ExpressionOperator)Operator;

            switch (expOperator)
            {
                case ExpressionOperator.Sub:
                    result = num1.Sub(num2);
                    break;
                case ExpressionOperator.Add:
                    result = num1.Add(num2);
                    break;
                case ExpressionOperator.Multiply:
                    result = num1.Multiply(num2);
                    break;
                case ExpressionOperator.Divide:
                    result = num1.Divide(num2);
                    break;
                case ExpressionOperator.Sqrt:
                    result = num1.Sqrt();
                    break;
                case ExpressionOperator.Square:
                    result = num1.Square();
                    break;
                default:
                    break;
            }

            return result;
        }
        public static double Add(this double value, double param)
        {
            return value + param;
        }
        public static double Add(this int value, double param)
        {
            return value + param;
        }
        public static double Sub(this double value, double param)
        {
            return value - param;
        }
        public static double Multiply(this double value, double param)
        {
            return value * param;
        }
        public static double Divide(this double value, double param)
        {
            return value / param;
        }
        public static double Sqrt(this double value)
        {
            return Math.Sqrt(value);
        }
        public static double Square(this double value)
        {
            return value * value;
        }
        public static double Tan(this double value)
        {
            return Math.Tan(value);
        }
        public static double Tanh(this double value)
        {
            return Math.Tanh(value);
        }
        public static T GetAttribute<T>(this Enum value) where T : Attribute
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString()).FirstOrDefault();
            var attributes = memberInfo.GetCustomAttributes(typeof(T), false);            

            return attributes.Length > 0 ? (T)attributes[0] : null;
        }

        public static string GetAttributeValue(this Enum value)
        {
            var attribute = value.GetAttribute<StringValueAttribute>();
            return attribute == null ? value.ToString() : attribute.Value;
        }
    }
}
