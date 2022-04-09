using System;
using NanoExtras;

namespace SampleLib
{
    public class TestClass
    {
        public static int Sum(string a, string b)
        {
            return ParseHelpers.ParseInt(a) + ParseHelpers.ParseInt(b);
        }

    }
}