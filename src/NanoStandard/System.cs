
using System.Reflection;

[assembly: AssemblyKeyFile("netstandard.pub")]
[assembly: AssemblyVersion("2.0.0")]
//netstandard, Version=2.1.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
namespace System
{
    public class Object
    {
        public virtual string ToString()
        {
            return null;
        }
        
        public virtual bool Equals(object obj) => false;
        public virtual int GetHashCode() => 0;
    }

    public class String
    {
        
    }

    public abstract class Attribute
    {
        
    }

    public struct Void
    {
        
    }
    
    public struct Boolean // : IComparable, IComparable<bool>, IEquatable<bool> {
    {
        public static readonly string FalseString;
        public static readonly string TrueString;
        public int CompareTo(bool value) => 0;
        public bool Equals(bool obj) => false;
        public override bool Equals(object obj) => false;
        public override int GetHashCode() => 0;
        public static bool Parse(string value) => false;
        public override string ToString() => null;
        public static bool TryParse(string value, out bool result) => throw null;
    }
    
    public struct Int32 //: IComparable, IComparable<int>, IEquatable<int>, IFormattable
    {
        public const int MaxValue = 2147483647;
        public const int MinValue = -2147483648;
        public int CompareTo(int value) => 0;
        public bool Equals(int obj) => false;
        public override bool Equals(object obj) => false;
        public override int GetHashCode() => 0;

        public static int Parse(string s) => 0;
        //public static int Parse(string s, IFormatProvider provider);
        //public static int Parse(string s, NumberStyles style);
        //public static int Parse(string s, NumberStyles style, IFormatProvider provider);
        public override string ToString() => null;
        //public string ToString(IFormatProvider provider);
        //public string ToString(string format);
        //public string ToString(string format, IFormatProvider provider);
        //public static bool TryParse(string s, out int result);
        //public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result);
    }
    
    public struct UInt32 //: IComparable, IComparable<uint>, IEquatable<uint>, IFormattable
    {
        public const uint MaxValue = (uint)4294967295;
        public const uint MinValue = (uint)0;
        public int CompareTo(uint value) => 0;
        public override bool Equals(object obj) => throw null;
        public bool Equals(uint obj) => throw null;
        public override int GetHashCode() => throw null;
        //public static uint Parse(string s) => throw null;
        //public static uint Parse(string s, IFormatProvider provider);
        //public static uint Parse(string s, NumberStyles style);
        //public static uint Parse(string s, NumberStyles style, IFormatProvider provider);
        public override string ToString() => throw null;
        //public string ToString(IFormatProvider provider);
        //public string ToString(string format);
        //public string ToString(string format, IFormatProvider provider);
        //public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result);
        //public static bool TryParse(string s, out uint result);
    }
    
    public abstract class ValueType {
        protected ValueType(){}
        public override bool Equals(object obj) => false;
        public override int GetHashCode() => 0;
        public override string ToString() => null;
    }
    
    public class Exception {
        public Exception(){}
        public Exception(string message){}
        public Exception(string message, Exception innerException){}
        //public virtual IDictionary Data { get; }
        public virtual string HelpLink { get; set; }
        //public int HResult { get; protected set; }
        public Exception InnerException { get; }
        public virtual string Message { get; }
        public virtual string Source { get; set; }
        public virtual string StackTrace { get; }

        public virtual Exception GetBaseException()
        {
            throw null;
            
        }

        public override string ToString() => null;
    }
}
namespace System.Runtime.Versioning {
    public sealed class TargetFrameworkAttribute : Attribute {
        public TargetFrameworkAttribute(string frameworkName){}
        public string FrameworkDisplayName { get; set; }
        public string FrameworkName { get; }
    }
}

namespace System.Reflection
{
    public sealed class AssemblyVersionAttribute : Attribute {
        public AssemblyVersionAttribute(string version){}
        public string Version { get; }
    }
    public sealed class AssemblyKeyFileAttribute : Attribute {
        public AssemblyKeyFileAttribute(string keyFile){}
        public string KeyFile { get; }
    }
    
    public sealed class AmbiguousMatchException : Exception {
        public AmbiguousMatchException(){}
        public AmbiguousMatchException(string message){}
        public AmbiguousMatchException(string message, Exception inner){}
    }
}