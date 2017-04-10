using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoFacTest.Interfaces;

namespace AutoFacTest.Classes
{
    public class MySecond : IMySecond
    {
        public string MySecondString(string s)
        {
            return s;
        }
    }
}
