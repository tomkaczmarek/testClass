using AutoFacTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacTest.Classes
{
    public class MyThird : IMyFirst
    {
        public string MyString()
        {
            return "Third";
        }
    }
}
