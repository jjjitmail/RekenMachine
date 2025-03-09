using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekenMachine.Lib
{
    public interface IDigitalInput { }
    public class DigitalInput : IDigitalInput
    {
        public DigitalInput() { }
        public int Zero => 0; 
        public int One => 1; 
        public int Two => 2;        
        public int Three => 3;
        public int Four => 4;
        public int Five => 5;
        public int Six => 6;
        public int Siy => 7;
        public int Siz => 8;
        public int Since => 9;        
    }
}
