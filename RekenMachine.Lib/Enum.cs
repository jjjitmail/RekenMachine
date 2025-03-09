using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekenMachine.Lib
{
    public enum EvaluateOperator
    {
        Enter,
        Reset        
    }

    public enum PreEvaluateOperator
    {
        Backspace,
        Reverse,
        Sinus,
        Cosinus,
        Tangens,
        MemoryAdd,
        MemorySub,
        Log,
        SquareRoot
    }

    public enum ExpressionOperator
    {
        Add = 0,
        Sub = 1,
        Multiply = 2,
        Divide = 3,
        Sqrt = 4,
        Square = 5,
    }

    public enum PriorityOperator
    {
        [StringValue("(")]
        BracketOpen = 0,
        [StringValue(")")]
        BracketClose = 1
    }

    //public enum DigitalInput
    //{
    //    Zero,
    //    One,
    //    Two,
    //    Three,
    //    Four,
    //    Five,
    //    Six,
    //    Seven,
    //    Eight,
    //    Nine
    //}
}
