using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFacTest.Interfaces;

namespace AutoFacTest
{
    public class TestController
    {
        private IMyFirst _first;
        private IMySecond _second;

        public TestController(IMyFirst first, IMySecond second)
        {
            _first = first;
            _second = second;
        }

        public void Execute()
        {
            Console.WriteLine(_first.MyString());
            Console.WriteLine(_second.MySecondString("test"));
        }
    }
}
