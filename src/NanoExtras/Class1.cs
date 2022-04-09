using System;

namespace NanoExtras
{
    public class ParseHelpers
    {
        public static int ParseInt(string s)
        {
#if NETSTANDARD2_0
            return int.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
#else
            return 0;
#endif
        }
    }
}

namespace System
{
    public struct Double
    {
        
    }
}